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
        Manejador_sensores ms;

        public Temperaturas()
        {
            InitializeComponent();
            ms = new Manejador_sensores(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvTemperaturas.Visible = true;
            ms.MostrarSensores(dtgvTemperaturas, txtBuscar.Text);
        }
    }
}
