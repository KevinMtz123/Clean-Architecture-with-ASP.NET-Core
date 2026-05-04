using DientesLimpios.Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DientesLimpios.Dominio.ObjetosDeValor
{
    public record IntervaloDeTiempo
    {
        public DateTime Inicio { get;}
        public DateTime Fin { get;}

        private IntervaloDeTiempo()
        {
            
        }
        public IntervaloDeTiempo(DateTime inicio, DateTime fin)
        {
            if (inicio > fin)
            {
                throw new ExcepcionDeReglaDeNegocio($"La fecha de inicio no puede ser posterior a la fecha fin");
            }

            //if (inicio < DateTime.UtcNow)
            //{
            //    throw new ExcepcionDeReglaDeNegocio($"La fecha de inicio no puede ser anterior a la fecha actual");
            //}
            Inicio = inicio;
            Fin = fin;
        }
    }
}
