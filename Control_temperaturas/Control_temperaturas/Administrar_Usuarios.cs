using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_temperaturas
{
    public partial class Administrar_Usuarios : Form
    {
        //Mandar a llamar al manejador de los usuarios
        Manejador_usuarios mu = new Manejador_usuarios();

        //Variables para la tabla
        int fila = 0, columna = 0; 
        
        //Variables publicas estaticas
        public static int id_usuario = 0;
        public static string nombre = "", apellido = "", nivel = "", nickname = "", pass = "";

        //Evento para el boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        //Evento para guardar y modificar los registros de la tabla usuarios
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(id_usuario > 0)
            {
                mu.Modificar(id_usuario, txtNombre, txtApellidos, txtNivel, txtNickname, txtPass); 
            }
            else
            {
                mu.Guardar(txtNombre, txtApellidos, txtNivel, txtNickname, txtPass); 
            }
            Close(); 
        }

        //Evento para poder agregar los botones de modificar y eliiminar al dataGrid
        private void dtgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;

            switch (columna)
            {
                case 5:
                    {
                        id_usuario = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString()); 
                        mu.Borrar(id_usuario, dtgvUsuarios.Rows[fila].Cells[2].Value.ToString());
                        dtgvUsuarios.Visible = false; 

                    }break; 
                case 6:
                    {
                        id_usuario = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString()); 
                        nombre = dtgvUsuarios.Rows[fila].Cells[1].ToString();
                        apellido = dtgvUsuarios.Rows[fila].Cells[2].ToString();
                        nivel = dtgvUsuarios.Rows[fila].Cells[3].ToString();
                        nickname = dtgvUsuarios.Rows[fila].Cells[4].ToString();
                        pass = dtgvUsuarios.Rows[fila].Cells[5].ToString();

                    }break;
            }
        }

        //Evento para usar un TextBox para usarlo como una barra buscadora
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true; 
            mu.MostrarUsuarios(dtgvUsuarios, txtBuscar.Text);
        }

        public Administrar_Usuarios()
        {
            InitializeComponent();
            mu = new Manejador_usuarios();
        }

        //Otro boton para poder cerrar la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
