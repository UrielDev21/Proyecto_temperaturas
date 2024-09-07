using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso; 
using Microsoft.Win32;

namespace Controller
{
    public class Manejador_usuarios
    {
        //Mandar a llamar la clase de las funciones
        Funciones f = new Funciones();

        //Metodo para guardar los datos en la tabla de los usuarios
        public void Guardar(TextBox Nombre, TextBox Apellido, TextBox Nivel, TextBox Nickname, TextBox Pass)
        {
            MessageBox.Show(f.Guardar($"call p_insertar_usuarios('{Nombre.Text}', '{Apellido.Text}', '{Nivel.Text}', '{Nickname.Text}', sha1('{Pass.Text}'))"),
                "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo para modificar los datos de los usuarios
        public void Modificar(int Id_usuario, TextBox Nombre, TextBox Apellido, TextBox Nivel, TextBox Nickname, TextBox Pass)
        {
            MessageBox.Show(f.Modificar($"call p_modificar_usuarios({Id_usuario}, '{Nombre.Text}', '{Apellido.Text}', '{Nivel.Text}', '{Nickname.Text}', sha1('{Pass.Text}'))"),
                "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo para borrar los usuarios de la tabla
        public void Borrar(int id_usuario, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_eliminar_usuarios({id_usuario})");
                MessageBox.Show("Registro eliminado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
        //Metodo para generar botones dentro del dataGrid
        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }
        //Metodo para poder consultar los usuarios y poder modificar y eliminar registros
        public void MostrarUsuarios(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from v_usuarios where nombre like '%{filtro}%'", "usuarios").Tables[0];
            tabla.Columns.Insert(5, Boton("Eliminar", Color.Red));
            tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows(); 
        }
    }
}