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
    public partial class Sensores : Form
    {

        public Sensores()
        {
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkSensor1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensor1.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
        }

        private void chkSendor2_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSendor2.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
        }

        private void chkSensor3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensor3.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
            
        }

        private void chkSensor4_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSensor4.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
        }

        private void chkSensor5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensor5.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
        }

        private void chkSensor6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensor6.Checked)
            {
                TimerTemperatura.Start();
            }
            else
            {
                TimerTemperatura.Stop();
            }
        }
    }
}
