using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Aplicacion.Excepciones
{
    public class ExcepcionDeValidacion : Exception
    {
        public List<string> ErroresDeValidacion { get; set; } = [];
        public ExcepcionDeValidacion(string mensajeError)
        {
            ErroresDeValidacion.Add(mensajeError);
        }
        public ExcepcionDeValidacion(ValidationResult validationResult)
        {
            foreach (var errorDeValidacion in validationResult.Errors)
            {
                ErroresDeValidacion.Add(errorDeValidacion.ErrorMessage);
            }
        }
    }
}
