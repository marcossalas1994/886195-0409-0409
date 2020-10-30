using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Datos;
using NLayer.Entidades;


namespace NLayer.Negocio
{
    public class DolarServicio
    {
        private DolarMapper mapper;
        public DolarServicio()
        {
            mapper = new DolarMapper();
        }

        public List<Dolar> TraerDolar()
        {
            return mapper.TraerTodos();
        }

        public Dolar TraerDolarPorFecha(DateTime fecha)
        {
            List<Dolar> result = mapper.TraerTodos();
            Dolar dol = null;
            foreach (Dolar d in result)
            {
                if (d.Fecha == fecha)
                    dol = d;
            }
            return dol;

        }

        public bool ExisteElDolar(Dolar dolar)
        {
            List<Dolar> dolars = TraerDolar();
            return dolars.Any(d => d.Equals(dolar));
        }



    }
}
