using DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerDetalleDentista;
using DientesLimpios.Aplicacion.Contratos.Repositorios;
using DientesLimpios.Aplicacion.Excepciones;
using DientesLimpios.Aplicacion.Utilidades.Mediador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentistas
{
    public class CasoDeUsoObtenerDetalleDentista : IRequestHandler<ConsultaObtenerDetalleDentista, DentistaDetalleDTO>
    {
        private readonly IRepositorioDentistas repositorio;

        public CasoDeUsoObtenerDetalleDentista(IRepositorioDentistas repositorio)
        {
            this.repositorio = repositorio;
        }
        public async Task<DentistaDetalleDTO> Handle(ConsultaObtenerDetalleDentista request)
        {
            var Dentista = await repositorio.ObtenerPorId(request.Id);
            if (Dentista is null)
                throw new ExcepcionNoEncontrado();

            return Dentista.ADto();
        }
    }
}
