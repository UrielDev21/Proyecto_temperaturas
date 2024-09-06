using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Evento para activar y desactivar el sensor 1
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
        //Evento para activar y desactivar el sensor 2
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

        //Evento para activar el timer y llamar el metodo para guardar la temperatura
        private void TimerSensor2_Tick(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas(); 
            bool estado = chkSendor2   .Checked;
            ms.GuardarTemperaturaDB(2, temperatura, estado); 
        }

        private void TimerSensor1_Tick(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas(); 
            bool estado = chkSensor1.Checked;
            ms.GuardarTemperaturaDB(1, temperatura, estado); 
        }

        private void TimerSensor3_Tick(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas();
            bool estado = chkSensor3.Checked;
            ms.GuardarTemperaturaDB(3, temperatura, estado);
        }

        private void chkSensor4_CheckedChanged(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas();
            bool estado = chkSensor4.Checked;
            ms.GuardarTemperaturaDB(4, temperatura, estado);
        }

        private void chkSensor5_CheckedChanged(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas();
            bool estado = chkSensor5.Checked;
            ms.GuardarTemperaturaDB(5, temperatura, estado);
        }

        private void chhkSensor6_CheckedChanged(object sender, EventArgs e)
        {
            float temperatura = ms.GenerarTemperaturas();
            bool estado = chhkSensor6.Checked;
            ms.GuardarTemperaturaDB(6, temperatura, estado);
        }
    }
}
