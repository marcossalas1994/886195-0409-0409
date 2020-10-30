using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Dolar
    {
        [DataMember]
        private DateTime fecha;
        [DataMember]
        private string oficial_venta;
        [DataMember]
        private string blue_venta;


        public Dolar()
        {

        }
        public Dolar(DateTime fecha, string oficial_venta, string blue_venta)
        {
            this.fecha = fecha;
            this.oficial_venta = oficial_venta;
            this.blue_venta = blue_venta;
        }

        
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public string OficialVenta
        {
            get
            {
                return this.oficial_venta;
            }
            set
            {
                this.oficial_venta = value;
            }
        }
        public string BlueVenta    
        {
            get
            {
                return this.blue_venta;
            }
            set
            {
                this.blue_venta = value;
            }
        }
        public override string ToString()
        {
            return fecha + " " + oficial_venta + " " + blue_venta;
        }

        public override bool Equals(object obj)
        {
            return (obj != null && obj is Dolar && this.fecha == ((Dolar)obj).fecha);

        }

    }
}

