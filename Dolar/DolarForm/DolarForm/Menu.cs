using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLayer.Negocio;

namespace DolarForm
{
    public partial class Menu : Form
    {
        private DolarServicio dolar;

    //    private AltaClienteForm altaClienteForm;
    //    private AltaCuentaForm altaCuentaForm;
        public Menu()
        {
            InitializeComponent();
            dolar = new DolarServicio();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }

        private void btnAltaCuenta_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           listBox1.DataSource = dolar.TraerDolar();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
