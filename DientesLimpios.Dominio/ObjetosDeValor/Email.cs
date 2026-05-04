using DientesLimpios.Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Dominio.ObjetosDeValor
{
    public record Email
    {
        public string Valor { get; } = null!;
        private Email()
        {
            
        }
        public Email(string email)
        {
            
            if (string.IsNullOrWhiteSpace(email))
                throw new ExcepcionDeReglaDeNegocio($"The {nameof(email)} is null");
            if (!email.Contains("@"))
                throw new ExcepcionDeReglaDeNegocio($"The {nameof(email)} isn't valid");
            Valor = email;  
        }
    }
}
