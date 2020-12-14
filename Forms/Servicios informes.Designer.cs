namespace MASTER_TUNE_UP.Forms
{
    partial class Servicios_informes
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
            this.gpbcatalogos = new System.Windows.Forms.GroupBox();
            this.rdbservicios = new System.Windows.Forms.RadioButton();
            this.rdbarticulo = new System.Windows.Forms.RadioButton();
            this.cboxUSUARIOS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdbUsuarioInforme = new System.Windows.Forms.RadioButton();
            this.RdbTodoInforme = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RdbPntalla = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FechasHasta2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.FechasDesde2 = new System.Windows.Forms.DateTimePicker();
            this.cboxservicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbcatalogos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbcatalogos
            // 
            this.gpbcatalogos.Controls.Add(this.rdbservicios);
            this.gpbcatalogos.Location = new System.Drawing.Point(51, 122);
            this.gpbcatalogos.Name = "gpbcatalogos";
            this.gpbcatalogos.Size = new System.Drawing.Size(126, 48);
            this.gpbcatalogos.TabIndex = 10;
            this.gpbcatalogos.TabStop = false;
            this.gpbcatalogos.Text = "Selecciona";
            // 
            // rdbservicios
            // 
            this.rdbservicios.AutoSize = true;
            this.rdbservicios.Checked = true;
            this.rdbservicios.Location = new System.Drawing.Point(16, 20);
            this.rdbservicios.Name = "rdbservicios";
            this.rdbservicios.Size = new System.Drawing.Size(68, 17);
            this.rdbservicios.TabIndex = 0;
            this.rdbservicios.TabStop = true;
            this.rdbservicios.Text = "Servicios";
            this.rdbservicios.UseVisualStyleBackColor = true;
            // 
            // rdbarticulo
            // 
            this.rdbarticulo.AutoSize = true;
            this.rdbarticulo.Location = new System.Drawing.Point(6, 78);
            this.rdbarticulo.Name = "rdbarticulo";
            this.rdbarticulo.Size = new System.Drawing.Size(79, 17);
            this.rdbarticulo.TabIndex = 0;
            this.rdbarticulo.Text = "por servicio";
            this.rdbarticulo.UseVisualStyleBackColor = true;
            this.rdbarticulo.CheckedChanged += new System.EventHandler(this.rdbarticulo_CheckedChanged);
            // 
            // cboxUSUARIOS
            // 
            this.cboxUSUARIOS.FormattingEnabled = true;
            this.cboxUSUARIOS.Location = new System.Drawing.Point(317, 107);
            this.cboxUSUARIOS.Name = "cboxUSUARIOS";
            this.cboxUSUARIOS.Size = new System.Drawing.Size(143, 21);
            this.cboxUSUARIOS.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdbUsuarioInforme);
            this.groupBox3.Controls.Add(this.rdbarticulo);
            this.groupBox3.Controls.Add(this.RdbTodoInforme);
            this.groupBox3.Location = new System.Drawing.Point(183, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 98);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione";
            // 
            // RdbUsuarioInforme
            // 
            this.RdbUsuarioInforme.AutoSize = true;
            this.RdbUsuarioInforme.Location = new System.Drawing.Point(6, 55);
            this.RdbUsuarioInforme.Name = "RdbUsuarioInforme";
            this.RdbUsuarioInforme.Size = new System.Drawing.Size(78, 17);
            this.RdbUsuarioInforme.TabIndex = 1;
            this.RdbUsuarioInforme.Text = "Por usuario";
            this.RdbUsuarioInforme.UseVisualStyleBackColor = true;
            this.RdbUsuarioInforme.CheckedChanged += new System.EventHandler(this.RdbUsuarioInforme_CheckedChanged);
            // 
            // RdbTodoInforme
            // 
            this.RdbTodoInforme.AutoSize = true;
            this.RdbTodoInforme.Checked = true;
            this.RdbTodoInforme.Location = new System.Drawing.Point(6, 31);
            this.RdbTodoInforme.Name = "RdbTodoInforme";
            this.RdbTodoInforme.Size = new System.Drawing.Size(55, 17);
            this.RdbTodoInforme.TabIndex = 0;
            this.RdbTodoInforme.TabStop = true;
            this.RdbTodoInforme.Text = "Todos";
            this.RdbTodoInforme.UseVisualStyleBackColor = true;
            this.RdbTodoInforme.CheckedChanged += new System.EventHandler(this.RdbTodoInforme_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(504, 372);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 28);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 35;
            this.button2.Text = "salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.RdbPntalla);
            this.groupBox4.Location = new System.Drawing.Point(51, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 100);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Por impresora";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RdbPntalla
            // 
            this.RdbPntalla.AutoSize = true;
            this.RdbPntalla.Checked = true;
            this.RdbPntalla.Location = new System.Drawing.Point(6, 31);
            this.RdbPntalla.Name = "RdbPntalla";
            this.RdbPntalla.Size = new System.Drawing.Size(81, 17);
            this.RdbPntalla.TabIndex = 0;
            this.RdbPntalla.TabStop = true;
            this.RdbPntalla.Text = "Por pantalla";
            this.RdbPntalla.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.FechasHasta2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.FechasDesde2);
            this.groupBox5.Location = new System.Drawing.Point(392, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 92);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Periodo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Al:";
            // 
            // FechasHasta2
            // 
            this.FechasHasta2.Location = new System.Drawing.Point(201, 31);
            this.FechasHasta2.Name = "FechasHasta2";
            this.FechasHasta2.Size = new System.Drawing.Size(121, 20);
            this.FechasHasta2.TabIndex = 24;
            this.FechasHasta2.ValueChanged += new System.EventHandler(this.FechasHasta2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "De:";
            // 
            // FechasDesde2
            // 
            this.FechasDesde2.Location = new System.Drawing.Point(33, 31);
            this.FechasDesde2.Name = "FechasDesde2";
            this.FechasDesde2.Size = new System.Drawing.Size(122, 20);
            this.FechasDesde2.TabIndex = 22;
            this.FechasDesde2.ValueChanged += new System.EventHandler(this.FechasDesde2_ValueChanged);
            // 
            // cboxservicio
            // 
            this.cboxservicio.FormattingEnabled = true;
            this.cboxservicio.Location = new System.Drawing.Point(479, 107);
            this.cboxservicio.Name = "cboxservicio";
            this.cboxservicio.Size = new System.Drawing.Size(143, 21);
            this.cboxservicio.TabIndex = 40;
            this.cboxservicio.SelectedIndexChanged += new System.EventHandler(this.RdbTodoInforme_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Servicios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Servicios_informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxservicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cboxUSUARIOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbcatalogos);
            this.Name = "Servicios_informes";
            this.Text = "Servicios_informes";
            this.gpbcatalogos.ResumeLayout(false);
            this.gpbcatalogos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbcatalogos;
        private System.Windows.Forms.RadioButton rdbarticulo;
        private System.Windows.Forms.RadioButton rdbservicios;
        private System.Windows.Forms.ComboBox cboxUSUARIOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdbUsuarioInforme;
        private System.Windows.Forms.RadioButton RdbTodoInforme;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RdbPntalla;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechasHasta2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechasDesde2;
        private System.Windows.Forms.ComboBox cboxservicio;
        private System.Windows.Forms.Label label1;
    }
}