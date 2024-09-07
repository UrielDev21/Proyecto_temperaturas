using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_temperaturas
{
    public partial class Temperaturas : Form
    {
        //Mandar a llamar el metodo de los sensores
        Manejador_sensores ms;

        public Temperaturas()
        {
            InitializeComponent();
            ms = new Manejador_sensores(); 
        }

        //Evento para cerrar la ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        //Evento para poder usar un TextBox como una barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvTemperaturas.Visible = true;
            ms.MostrarSensores(dtgvTemperaturas, txtBuscar.Text);
        }
    }
}
