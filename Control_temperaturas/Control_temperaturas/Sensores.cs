using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Control_temperaturas
{
    public partial class Sensores : Form
    {
        Manejador_sensores ms = new Manejador_sensores();

        public Sensores()
        {
            InitializeComponent();
            ms = new Manejador_sensores();
            TimerSensor1.Tick += new EventHandler(TimerSensor1_Tick);
            TimerSensor2.Tick += new EventHandler(TimerSensor2_Tick);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkSensor1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensor1.Checked)
            {
                TimerSensor1.Start();
            }
            else
            {
                TimerSensor1.Stop();
            }
        }

        private void chkSendor2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSendor2.Checked)
            {
                TimerSensor2.Start();
            }
            else
            {
                TimerSensor2.Stop();
            }
        }

        private void TimerSensor2_Tick(object sender, EventArgs e)
        {
            //ms.GenerarTemperaturas(lblComprobar); 
            float temperatura = ms.GenerarTemperaturas(); 
            bool estado = chkSendor2    .Checked;
            ms.GuardarTemperaturaDB(1, temperatura, estado); 
        }

        private void TimerSensor1_Tick(object sender, EventArgs e)
        {
             
        }
    }
}
