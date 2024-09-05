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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblComprobar = new System.Windows.Forms.Label();
            this.TimerSensor1 = new System.Windows.Forms.Timer(this.components);
            this.TimerSensor2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSensor1
            // 
            this.chkSensor1.AutoSize = true;
            this.chkSensor1.Location = new System.Drawing.Point(26, 77);
            this.chkSensor1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSensor1.Name = "chkSensor1";
            this.chkSensor1.Size = new System.Drawing.Size(107, 21);
            this.chkSensor1.TabIndex = 1;
            this.chkSensor1.Text = "Sensor 1";
            this.chkSensor1.UseVisualStyleBackColor = true;
            this.chkSensor1.CheckedChanged += new System.EventHandler(this.chkSensor1_CheckedChanged);
            // 
            // chkSendor2
            // 
            this.chkSendor2.AutoSize = true;
            this.chkSendor2.Location = new System.Drawing.Point(213, 77);
            this.chkSendor2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkSendor2.Name = "chkSendor2";
            this.chkSendor2.Size = new System.Drawing.Size(107, 21);
            this.chkSendor2.TabIndex = 2;
            this.chkSendor2.Text = "Sensor 2";
            this.chkSendor2.UseVisualStyleBackColor = true;
            this.chkSendor2.CheckedChanged += new System.EventHandler(this.chkSendor2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSensor1);
            this.groupBox1.Controls.Add(this.chkSendor2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(32, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 294);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar sensores";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(409, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblComprobar
            // 
            this.lblComprobar.AutoSize = true;
            this.lblComprobar.Location = new System.Drawing.Point(199, 370);
            this.lblComprobar.Name = "lblComprobar";
            this.lblComprobar.Size = new System.Drawing.Size(68, 17);
            this.lblComprobar.TabIndex = 9;
            this.lblComprobar.Text = "label1";
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
            // Sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.lblComprobar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Sensores";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkSensor1;
        private System.Windows.Forms.CheckBox chkSendor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblComprobar;
        private System.Windows.Forms.Timer TimerSensor1;
        private System.Windows.Forms.Timer TimerSensor2;
    }
}