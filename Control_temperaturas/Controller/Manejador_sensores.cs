using Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Controller
{
    public class Manejador_sensores
    {
        //Mandar a llamar a la clase funciones
        Funciones f = new Funciones();
        
        /*Metodo para generar temperatura de manera aleatoria
        usando numeros flotantes y especificando un rango*/
        public float GenerarTemperaturas()
        {
            Random rad = new Random();

            float temperatura = rad.Next(-10, 100); 
            return temperatura;
        }
        /*Metodo para guardar la temperatura generada con los numeros aleatorios y
         con un procedimiento almacenado para guardarla en la base de datos*/
        public void GuardarTemperaturaDB(int num_sensor,float temperatura, bool estado)
        {
            try
            {
                f.Guardar($"call p_guardar_temperatura({num_sensor}, {temperatura}, {estado})"); 
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio algun error", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        //Metodo para poder mostrar los datos de la tabla de los sensores y poder filtrar la informacion
        public void MostrarSensores(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from v_sensores where num_sensor like '%{filtro}%'", "sensores").Tables[0]; 
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows(); 
        }
    }
}
