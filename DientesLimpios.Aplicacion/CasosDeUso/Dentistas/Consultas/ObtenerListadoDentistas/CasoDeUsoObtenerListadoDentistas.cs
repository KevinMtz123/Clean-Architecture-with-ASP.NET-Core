using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Utilidades.Comunes;
using DientesLimpios.Aplicacion.Utilidades.Mediador;
using DientesLimpios.Dentistas.CasosDeUso.ObtenerListadoDentistas.Consultas.ObtenerListadoPacientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentistas
{
    public class CasoDeUsoObtenerListadoDentistas : IRequestHandler<ConsultaObtenerListadoDentistas, PaginadoDTO<DentistaListadoDTO>>
    {
        private readonly IRepositorioDentistas repositorio;

        public CasoDeUsoObtenerListadoDentistas(IRepositorioDentistas repositorio)
        {
            this.repositorio = repositorio;
        }
        public async Task<PaginadoDTO<DentistaListadoDTO>> Handle(ConsultaObtenerListadoDentistas request)
        {
            var Dentistas = await repositorio.ObtenerFiltrado(request);
            var totalDentistas = await repositorio.ObtenerCantidadTotalRegistros();
            var DentistasDTO = Dentistas.Select(Dentista => Dentista.ADto()).ToList();

            var paginadoDTO = new PaginadoDTO<DentistaListadoDTO>
            {
                Elementos = DentistasDTO,
                Total = totalDentistas
            };
            return paginadoDTO;
        }
    }
}
