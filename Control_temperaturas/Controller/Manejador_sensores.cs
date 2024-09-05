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
                MessageBox.Show(f.Guardar($"call p_guardar_temperatura({num_sensor}, {temperatura}, {estado})"),
                "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio algun error", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
