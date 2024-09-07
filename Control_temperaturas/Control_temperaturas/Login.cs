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
    public partial class Login : Form
    {

        //Mandar a llamar al manejador de login
        Manejador_login ml;

        public Login()
        {
            InitializeComponent();
            ml = new Manejador_login();
        }

        //Evento para poder cerrar el programa
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Evento para poder validar el usuario y la contraseña
         usando el metodo de validar del manejador login*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] r = new string[2];
            r = ml.Validar(txtUsuario.Text, txtPass.Text);
            if (r[0].Equals("Correcto"))
            {
                this.Hide(); 
                int nivelUsuario = int.Parse(r[1]);
                Menu m = new Menu(nivelUsuario);
                m.Show();
            }
            else
            {
                MessageBox.Show("Error de credenciales");
            }

            }
        //Evento para mostrar un mensaje presionando un linklabel
        private void lLOlvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Esta opción todavia no esta disponible", "ATENCION!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }
    }
    }
