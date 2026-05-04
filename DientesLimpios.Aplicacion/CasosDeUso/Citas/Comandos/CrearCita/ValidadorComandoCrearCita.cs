using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CrearCita
{
    public class ValidadorComandoCrearCita : AbstractValidator<ComandoCrearCita>
    {
        public ValidadorComandoCrearCita()
        {
            RuleFor(x => x.FechaInicio)
                .GreaterThan(x => x.FechaFin).WithMessage("La fecha fin debe de ser posterior a la fecha de inicio")
                .GreaterThan(DateTime.UtcNow).WithMessage("La fecha de inicio no puede estar en el pasado");
        }
    }
}
