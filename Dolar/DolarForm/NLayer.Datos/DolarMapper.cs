using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidades;
using System.Configuration;
using NLayer.Datos;

namespace NLayer.Datos
{
    public class DolarMapper
    {
        public List<Dolar> TraerTodos()
        {
            string json2 = WebHelper.Get("/data.json?=1603396503"); // trae un texto en formato json de una web
            return MapList(json2);
        }

        private List<Dolar> MapList(string json)
        {
            //devuelve el json deserializado
            return JsonConvert.DeserializeObject<List<Dolar>>(json);
        }
        private NameValueCollection ReverseMap(Dolar dolar)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("fecha", dolar.Fecha.ToShortDateString()); // DateTime
            n.Add("dolar_blue", dolar.BlueVenta.ToString()); // INT
            n.Add("dolar_oficial", dolar.OficialVenta.ToString()); // INT
            return n;
        }

    }

}
