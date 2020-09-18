using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Expendedora
{
    class Program
    {//
     //ESTA MAL, NO VI QUE HABÍA UN PDF CON UN UML
     //
     //ESTA MAL, NO VI QUE HABÍA UN PDF CON UN UML
     //
     //ESTA MAL, NO VI QUE HABÍA UN PDF CON UN UML
     //
     //ESTA MAL, NO VI QUE HABÍA UN PDF CON UN UML
     //
     //ESTA MAL, NO VI QUE HABÍA UN PDF CON UN UML
     //Tampoco está terminado
        static void Main(string[] args)
        {
            List<Caja> ValorEnCaja = new List<Caja>();
            Caja CJ = new Caja();
            CJ.CargarCaja();
            ValorEnCaja.Add(CJ);

            List<ItemExpendedora> itemExpendedora = new List<ItemExpendedora>();
            ItemExpendedora A = new ItemExpendedora();
            A.CargarExpendedora();
            itemExpendedora.Add(A);

            Console.WriteLine(A.ToString());

            //RealizarCompra();

        }
    }



    class Cliente
    {
        private int iditem;
        private int itemCantidad;
        private int total;
        bool flag = false;

        private int _item
        {
            get { return iditem; }
            set { this.iditem = value; }
        }

        private int _itemCantidad
        {
            get { return itemCantidad; }
            set { this.itemCantidad = value; }
        }

        public void RealizarCompra()
        {
            this.iditem = _item;
            this.itemCantidad = _itemCantidad;

            do
            {
                Console.WriteLine("Ingrese la posición en la máquina a cargar:");
                _item = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_item);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la cantidad de mercadería a comprar en el slot: " + _item);
                _itemCantidad = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_itemCantidad);
            } while (flag == false);

            bool ValidarInt(int numero)
            {
                bool flag = false;
                if (numero < 0)
                {
                    Console.WriteLine("Debe ingresar un número mayor a 0");
                }

                else
                {
                    flag = true;
                }

                return flag;
            }



        }

    }
    class Caja
    {
        private int caja;
        private int _caja
        {
            get { return caja; }
            set { this.caja = value; }
        }

        public void CargarCaja()

        {
            this.caja = _caja;
            bool flag = false;
            do
                {
                Console.WriteLine("Ingrese el el total en caja disponible: ");
                _caja = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_caja);
                }while (flag == false);

            bool ValidarInt(int numero)
            {
                bool flag = false;
                if (numero < 0)
                {
                    Console.WriteLine("Debe ingresar un número mayor a 0");
                }

                else
                {
                    flag = true;
                }

                return flag;
            }
        }


    }
class ItemExpendedora
    {
        private int iditem;
        private int itemCantidad;
        private string nombreitem;
        private int precio;



        private int _item
        {
            get { return iditem; }
            set { this.iditem = value; }
        }

        private int _itemCantidad
        {
            get { return itemCantidad; }
            set { this.itemCantidad = value; }
        }
        private string _nombreitem
        {
            get { return nombreitem; }
            set { this.nombreitem = value; }
        }

        private int _precio
        {
            get { return precio; }
            set { this.precio = value; }
        }



       
        public void CargarExpendedora()
        {
            this.iditem = _item;
            this.itemCantidad = _itemCantidad;
            this.nombreitem = _nombreitem;
            this.precio = _precio;
            string nombreitem = _nombreitem;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese la posición en la máquina a cargar: ");
                _item = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_item);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la cantidad de mercadería cargada en los slots: " + _item);
                _itemCantidad = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_itemCantidad);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el nombre de la golosina o bebida cargada en el slot " + _item);
                _nombreitem = Console.ReadLine();
                flag = ValidarString(_nombreitem);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el precio a vender del item: " + _item);
                _precio = Convert.ToInt32(Console.ReadLine());
                flag = ValidarInt(_precio);
            } while (flag == false);


            bool ValidarString(string userinput)
            {
                bool validar = false;
                if (string.IsNullOrEmpty(userinput))
                {
                    Console.WriteLine("Error. No ingreso ningun dato.");
                }
                else
                {
                    validar = true;
                }
                return validar;
            }


            bool ValidarInt(int numero)
            {
                bool flagg = false;
                if (numero < 0)
                {
                    Console.WriteLine("Debe ingresar un número mayor a 0");
                }

                else
                {
                    flagg = true;
                }

                return flagg;
            }


        }

        public override string ToString()
        {
            return string.Format("Id en maquina: {0} - Cantidad: {1} - Nombre Item: {2} - Precio: {3}",
        iditem,
        itemCantidad,
        nombreitem,
        precio);
        }
    }
}

