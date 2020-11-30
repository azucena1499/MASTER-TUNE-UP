namespace MASTER_TUNE_UP.Forms
{
    partial class Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos));
            this.gpbordenada = new System.Windows.Forms.GroupBox();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.rdbclave = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbimpresora = new System.Windows.Forms.RadioButton();
            this.rdbpantalla = new System.Windows.Forms.RadioButton();
            this.gpbcatalogos = new System.Windows.Forms.GroupBox();
            this.rdbclientes = new System.Windows.Forms.RadioButton();
            this.rdbarticulo = new System.Windows.Forms.RadioButton();
            this.rdbgrupos = new System.Windows.Forms.RadioButton();
            this.gpbordenada.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbcatalogos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbordenada
            // 
            this.gpbordenada.Controls.Add(this.rdbActivos);
            this.gpbordenada.Controls.Add(this.rdbclave);
            this.gpbordenada.Controls.Add(this.rdbnombre);
            this.gpbordenada.Location = new System.Drawing.Point(441, 77);
            this.gpbordenada.Name = "gpbordenada";
            this.gpbordenada.Size = new System.Drawing.Size(126, 98);
            this.gpbordenada.TabIndex = 9;
            this.gpbordenada.TabStop = false;
            this.gpbordenada.Text = "ordenada por:";
            this.gpbordenada.Visible = false;
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.Location = new System.Drawing.Point(16, 66);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(60, 17);
            this.rdbActivos.TabIndex = 4;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            // 
            // rdbclave
            // 
            this.rdbclave.AutoSize = true;
            this.rdbclave.Location = new System.Drawing.Point(16, 43);
            this.rdbclave.Name = "rdbclave";
            this.rdbclave.Size = new System.Drawing.Size(52, 17);
            this.rdbclave.TabIndex = 3;
            this.rdbclave.Text = "Clave";
            this.rdbclave.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Checked = true;
            this.rdbnombre.Location = new System.Drawing.Point(16, 20);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 2;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(613, 350);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 8;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(516, 350);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 7;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbimpresora);
            this.groupBox2.Controls.Add(this.rdbpantalla);
            this.groupBox2.Location = new System.Drawing.Point(288, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "consultada por:";
            // 
            // rdbimpresora
            // 
            this.rdbimpresora.AutoSize = true;
            this.rdbimpresora.Location = new System.Drawing.Point(16, 54);
            this.rdbimpresora.Name = "rdbimpresora";
            this.rdbimpresora.Size = new System.Drawing.Size(71, 17);
            this.rdbimpresora.TabIndex = 1;
            this.rdbimpresora.Text = "Impresora";
            this.rdbimpresora.UseVisualStyleBackColor = true;
            // 
            // rdbpantalla
            // 
            this.rdbpantalla.AutoSize = true;
            this.rdbpantalla.Checked = true;
            this.rdbpantalla.Location = new System.Drawing.Point(16, 20);
            this.rdbpantalla.Name = "rdbpantalla";
            this.rdbpantalla.Size = new System.Drawing.Size(63, 17);
            this.rdbpantalla.TabIndex = 0;
            this.rdbpantalla.TabStop = true;
            this.rdbpantalla.Text = "Pantalla";
            this.rdbpantalla.UseVisualStyleBackColor = true;
            // 
            // gpbcatalogos
            // 
            this.gpbcatalogos.Controls.Add(this.rdbclientes);
            this.gpbcatalogos.Controls.Add(this.rdbarticulo);
            this.gpbcatalogos.Controls.Add(this.rdbgrupos);
            this.gpbcatalogos.Location = new System.Drawing.Point(113, 77);
            this.gpbcatalogos.Name = "gpbcatalogos";
            this.gpbcatalogos.Size = new System.Drawing.Size(126, 98);
            this.gpbcatalogos.TabIndex = 5;
            this.gpbcatalogos.TabStop = false;
            this.gpbcatalogos.Text = "Selecciona";
            // 
            // rdbclientes
            // 
            this.rdbclientes.AutoSize = true;
            this.rdbclientes.Location = new System.Drawing.Point(16, 43);
            this.rdbclientes.Name = "rdbclientes";
            this.rdbclientes.Size = new System.Drawing.Size(62, 17);
            this.rdbclientes.TabIndex = 1;
            this.rdbclientes.Text = "Clientes";
            this.rdbclientes.UseVisualStyleBackColor = true;
            this.rdbclientes.CheckedChanged += new System.EventHandler(this.rdbclientes_CheckedChanged);
            // 
            // rdbarticulo
            // 
            this.rdbarticulo.AutoSize = true;
            this.rdbarticulo.Location = new System.Drawing.Point(16, 66);
            this.rdbarticulo.Name = "rdbarticulo";
            this.rdbarticulo.Size = new System.Drawing.Size(60, 17);
            this.rdbarticulo.TabIndex = 0;
            this.rdbarticulo.Text = "Articulo";
            this.rdbarticulo.UseVisualStyleBackColor = true;
            // 
            // rdbgrupos
            // 
            this.rdbgrupos.AutoSize = true;
            this.rdbgrupos.Checked = true;
            this.rdbgrupos.Location = new System.Drawing.Point(16, 20);
            this.rdbgrupos.Name = "rdbgrupos";
            this.rdbgrupos.Size = new System.Drawing.Size(59, 17);
            this.rdbgrupos.TabIndex = 0;
            this.rdbgrupos.TabStop = true;
            this.rdbgrupos.Text = "Grupos";
            this.rdbgrupos.UseVisualStyleBackColor = true;
            // 
            // Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbordenada);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbcatalogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalogos";
            this.Text = "frmCatalogos";
            this.gpbordenada.ResumeLayout(false);
            this.gpbordenada.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbcatalogos.ResumeLayout(false);
            this.gpbcatalogos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbordenada;
        private System.Windows.Forms.RadioButton rdbclave;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbimpresora;
        private System.Windows.Forms.RadioButton rdbpantalla;
        private System.Windows.Forms.GroupBox gpbcatalogos;
        private System.Windows.Forms.RadioButton rdbclientes;
        private System.Windows.Forms.RadioButton rdbarticulo;
        private System.Windows.Forms.RadioButton rdbgrupos;
        private System.Windows.Forms.RadioButton rdbActivos;
    }
}