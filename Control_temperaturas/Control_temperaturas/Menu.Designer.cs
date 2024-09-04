namespace Control_temperaturas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.optAdministrar_usuarios = new System.Windows.Forms.ToolStripButton();
            this.optSensores = new System.Windows.Forms.ToolStripButton();
            this.optTemperatura = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1405, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optAdministrar_usuarios,
            this.optSensores,
            this.optTemperatura,
            this.optSalir});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(71, 630);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // optAdministrar_usuarios
            // 
            this.optAdministrar_usuarios.AutoSize = false;
            this.optAdministrar_usuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optAdministrar_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("optAdministrar_usuarios.Image")));
            this.optAdministrar_usuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optAdministrar_usuarios.Name = "optAdministrar_usuarios";
            this.optAdministrar_usuarios.Size = new System.Drawing.Size(70, 70);
            this.optAdministrar_usuarios.Text = "Administrar usuarios";
            this.optAdministrar_usuarios.Click += new System.EventHandler(this.optAdministrar_usuarios_Click);
            // 
            // optSensores
            // 
            this.optSensores.AutoSize = false;
            this.optSensores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSensores.Image = ((System.Drawing.Image)(resources.GetObject("optSensores.Image")));
            this.optSensores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSensores.Name = "optSensores";
            this.optSensores.Size = new System.Drawing.Size(70, 70);
            this.optSensores.Text = "Sensores";
            this.optSensores.Click += new System.EventHandler(this.optSensores_Click);
            // 
            // optTemperatura
            // 
            this.optTemperatura.AutoSize = false;
            this.optTemperatura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optTemperatura.Image = global::Control_temperaturas.Properties.Resources.humedad;
            this.optTemperatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optTemperatura.Name = "optTemperatura";
            this.optTemperatura.Size = new System.Drawing.Size(70, 70);
            this.optTemperatura.Text = "Temperaturas";
            this.optTemperatura.Click += new System.EventHandler(this.optTemperatura_Click);
            // 
            // optSalir
            // 
            this.optSalir.AutoSize = false;
            this.optSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSalir.Image = ((System.Drawing.Image)(resources.GetObject("optSalir.Image")));
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(70, 70);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 655);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton optAdministrar_usuarios;
        private System.Windows.Forms.ToolStripButton optSensores;
        private System.Windows.Forms.ToolStripButton optTemperatura;
        private System.Windows.Forms.ToolStripButton optSalir;
    }
}