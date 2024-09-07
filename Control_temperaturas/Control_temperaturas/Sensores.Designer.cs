namespace Control_temperaturas
{
    partial class Sensores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkSensor1 = new System.Windows.Forms.CheckBox();
            this.chkSendor2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSensor5 = new System.Windows.Forms.CheckBox();
            this.chhkSensor6 = new System.Windows.Forms.CheckBox();
            this.chkSensor3 = new System.Windows.Forms.CheckBox();
            this.chkSensor4 = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.TimerSensor1 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor2 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor3 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor4 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor5 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor6 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSensor1
            // 
            this.chkSensor1.AutoSize = true;
            this.chkSensor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSensor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSensor1.Location = new System.Drawing.Point(26, 62);
            this.chkSensor1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSensor1.Name = "chkSensor1";
            this.chkSensor1.Size = new System.Drawing.Size(104, 21);
            this.chkSensor1.TabIndex = 1;
            this.chkSensor1.Text = "Sensor 1";
            this.chkSensor1.UseVisualStyleBackColor = true;
            this.chkSensor1.CheckedChanged += new System.EventHandler(this.chkSensor1_CheckedChanged);
            // 
            // chkSendor2
            // 
            this.chkSendor2.AutoSize = true;
            this.chkSendor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSendor2.Location = new System.Drawing.Point(26, 157);
            this.chkSendor2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSendor2.Name = "chkSendor2";
            this.chkSendor2.Size = new System.Drawing.Size(104, 21);
            this.chkSendor2.TabIndex = 2;
            this.chkSendor2.Text = "Sensor 2";
            this.chkSendor2.UseVisualStyleBackColor = true;
            this.chkSendor2.CheckedChanged += new System.EventHandler(this.chkSendor2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSensor5);
            this.groupBox1.Controls.Add(this.chhkSensor6);
            this.groupBox1.Controls.Add(this.chkSensor3);
            this.groupBox1.Controls.Add(this.chkSensor4);
            this.groupBox1.Controls.Add(this.chkSensor1);
            this.groupBox1.Controls.Add(this.chkSendor2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(32, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 356);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activar/Descativar";
            // 
            // chkSensor5
            // 
            this.chkSensor5.AutoSize = true;
            this.chkSensor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSensor5.Location = new System.Drawing.Point(26, 255);
            this.chkSensor5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSensor5.Name = "chkSensor5";
            this.chkSensor5.Size = new System.Drawing.Size(104, 21);
            this.chkSensor5.TabIndex = 6;
            this.chkSensor5.Text = "Sensor 5";
            this.chkSensor5.UseVisualStyleBackColor = true;
            this.chkSensor5.CheckedChanged += new System.EventHandler(this.chkSensor5_CheckedChanged);
            // 
            // chhkSensor6
            // 
            this.chhkSensor6.AutoSize = true;
            this.chhkSensor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chhkSensor6.Location = new System.Drawing.Point(26, 300);
            this.chhkSensor6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chhkSensor6.Name = "chhkSensor6";
            this.chhkSensor6.Size = new System.Drawing.Size(104, 21);
            this.chhkSensor6.TabIndex = 5;
            this.chhkSensor6.Text = "Sensor 6";
            this.chhkSensor6.UseVisualStyleBackColor = true;
            this.chhkSensor6.CheckedChanged += new System.EventHandler(this.chhkSensor6_CheckedChanged);
            // 
            // chkSensor3
            // 
            this.chkSensor3.AutoSize = true;
            this.chkSensor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSensor3.Location = new System.Drawing.Point(26, 109);
            this.chkSensor3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSensor3.Name = "chkSensor3";
            this.chkSensor3.Size = new System.Drawing.Size(104, 21);
            this.chkSensor3.TabIndex = 4;
            this.chkSensor3.Text = "Sensor 3";
            this.chkSensor3.UseVisualStyleBackColor = true;
            // 
            // chkSensor4
            // 
            this.chkSensor4.AutoSize = true;
            this.chkSensor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSensor4.Location = new System.Drawing.Point(26, 206);
            this.chkSensor4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSensor4.Name = "chkSensor4";
            this.chkSensor4.Size = new System.Drawing.Size(104, 21);
            this.chkSensor4.TabIndex = 3;
            this.chkSensor4.Text = "Sensor 4";
            this.chkSensor4.UseVisualStyleBackColor = true;
            this.chkSensor4.CheckedChanged += new System.EventHandler(this.chkSensor4_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(268, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TimerSensor1
            // 
            this.TimerSensor1.Interval = 15000;
            this.TimerSensor1.Tick += new System.EventHandler(this.TimerSensor1_Tick);
            // 
            // TimerSensor2
            // 
            this.TimerSensor2.Interval = 15000;
            this.TimerSensor2.Tick += new System.EventHandler(this.TimerSensor2_Tick);
            // 
            // TimerSensor3
            // 
            this.TimerSensor3.Interval = 15000;
            this.TimerSensor3.Tick += new System.EventHandler(this.TimerSensor3_Tick);
            // 
            // TimerSensor4
            // 
            this.TimerSensor4.Interval = 15000;
            // 
            // TimerSensor5
            // 
            this.TimerSensor5.Interval = 15000;
            // 
            // TimerSensor6
            // 
            this.TimerSensor6.Interval = 15000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 45);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Administrar sensores";
            // 
            // Sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(302, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Sensores";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkSensor1;
        private System.Windows.Forms.CheckBox chkSendor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer TimerSensor1;
        private System.Windows.Forms.Timer TimerSensor2;
        private System.Windows.Forms.CheckBox chkSensor5;
        private System.Windows.Forms.CheckBox chhkSensor6;
        private System.Windows.Forms.CheckBox chkSensor3;
        private System.Windows.Forms.CheckBox chkSensor4;
        private System.Windows.Forms.Timer TimerSensor3;
        private System.Windows.Forms.Timer TimerSensor4;
        private System.Windows.Forms.Timer TimerSensor5;
        private System.Windows.Forms.Timer TimerSensor6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}