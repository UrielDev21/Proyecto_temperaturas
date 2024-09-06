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
        Funciones f = new Funciones();
        
        public float GenerarTemperaturas()
        {
            Random rad = new Random();

            float temperatura = rad.Next(-10, 100); 
            return temperatura;
        }
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
        public void MostrarSensores(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from v_sensores where num_sensor like '%{filtro}%'", "sensores").Tables[0]; 
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows(); 
        }
    }
}
