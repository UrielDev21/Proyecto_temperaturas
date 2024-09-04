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
        Manejador_login ml;

        public static string Nombre_usuario = "";
        public static int IDU;

        public Login()
        {
            InitializeComponent();
            ml = new Manejador_login();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        private int Obtener_id_usuario(string nickname)
        {
            return ml   .Obtener_id_usuario(nickname);
        }
    }
    }
