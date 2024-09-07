using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_temperaturas
{
    public partial class Menu : Form
    {
        private int nivelUsuario; 
         
        public Menu(int nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            Condicion(); 
        }
        //Todos estos eventos solo son para presionar un boton y acceder al formulario

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void optAdministrar_usuarios_Click(object sender, EventArgs e)
        {
            Administrar_Usuarios adu = new Administrar_Usuarios();
            adu.Show();
            adu.MdiParent = this;
        }

        private void optSensores_Click(object sender, EventArgs e)
        {
            Sensores sen = new Sensores();
            sen.Show(); 
            sen.MdiParent = this;
        }

        private void optTemperatura_Click(object sender, EventArgs e)
        {
            Temperaturas temp = new Temperaturas();
            temp.Show();
            temp.MdiParent = this;
        }

        /*Metodo para poder validar el nivel de usuario  
         y dependiendo el nivel se le mostraran distintas opciones*/
        public void Condicion()
        {
            if (nivelUsuario == 1)
            {
                optAdministrar_usuarios.Visible = true; 
                optSensores.Visible = true;
                optTemperatura.Visible = true;  
                optSalir.Visible = true;
            }
            if(nivelUsuario == 2)
            {
                optAdministrar_usuarios.Visible = false;
                optSensores.Visible = true;
                optTemperatura.Visible = true; 
                optSalir.Visible = true;
            }
            if(nivelUsuario == 3)

            {
                optAdministrar_usuarios.Visible = false;
                optSensores.Visible = false;    
                optTemperatura.Visible = true;
                optSalir.Visible = true; 
            }
        }
    }
}
