﻿namespace MASTER_TUNE_UP.Forms
{
    partial class Frmservicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmservicios));
            this.dgServicios = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.txtxprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxservicio = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtteleono = new System.Windows.Forms.TextBox();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.txtapeMat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtxape = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btntotal = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpboxtipo = new System.Windows.Forms.GroupBox();
            this.rdbtncontado = new System.Windows.Forms.RadioButton();
            this.rdbtncreito = new System.Windows.Forms.RadioButton();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpboxtipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgServicios
            // 
            this.dgServicios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Trabajos,
            this.Precio1});
            this.dgServicios.Location = new System.Drawing.Point(48, 304);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.Size = new System.Drawing.Size(490, 163);
            this.dgServicios.TabIndex = 30;
            this.dgServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServicios_CellContentClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::MASTER_TUNE_UP.Properties.Resources.cruzar4;
            this.btneliminar.Location = new System.Drawing.Point(739, 378);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(54, 41);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Image = global::MASTER_TUNE_UP.Properties.Resources.disquete5;
            this.btngrabar.Location = new System.Drawing.Point(678, 378);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(55, 41);
            this.btngrabar.TabIndex = 37;
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            this.btngrabar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btngrabar_KeyPress);
            // 
            // txtxprecio
            // 
            this.txtxprecio.Enabled = false;
            this.txtxprecio.Location = new System.Drawing.Point(290, 54);
            this.txtxprecio.Name = "txtxprecio";
            this.txtxprecio.Size = new System.Drawing.Size(49, 20);
            this.txtxprecio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Precio";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(167, 11);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(158, 13);
            this.lblbuscar.TabIndex = 46;
            this.lblbuscar.Text = "Consulta de servicio por nombre";
            this.lblbuscar.Visible = false;
            // 
            // cboxservicio
            // 
            this.cboxservicio.FormattingEnabled = true;
            this.cboxservicio.Location = new System.Drawing.Point(162, 27);
            this.cboxservicio.Name = "cboxservicio";
            this.cboxservicio.Size = new System.Drawing.Size(166, 21);
            this.cboxservicio.TabIndex = 45;
            this.cboxservicio.Visible = false;
            this.cboxservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxservicio_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.btnbuscar.Location = new System.Drawing.Point(112, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(44, 34);
            this.btnbuscar.TabIndex = 44;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(49, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(195, 20);
            this.txtnombre.TabIndex = 43;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(48, 20);
            this.txtCodigo.TabIndex = 42;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtteleono);
            this.groupBox1.Controls.Add(this.cboxCliente);
            this.groupBox1.Controls.Add(this.txtapeMat);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtxape);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 175);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(46, 26);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(51, 20);
            this.txtclave.TabIndex = 67;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Clave:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cliente por nombre";
            this.label6.Visible = false;
            // 
            // txtteleono
            // 
            this.txtteleono.Location = new System.Drawing.Point(81, 137);
            this.txtteleono.Name = "txtteleono";
            this.txtteleono.Size = new System.Drawing.Size(176, 20);
            this.txtteleono.TabIndex = 58;
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(162, 26);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(166, 21);
            this.cboxCliente.TabIndex = 60;
            this.cboxCliente.Visible = false;
            this.cboxCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxCliente_KeyPress);
            // 
            // txtapeMat
            // 
            this.txtapeMat.Location = new System.Drawing.Point(80, 111);
            this.txtapeMat.Name = "txtapeMat";
            this.txtapeMat.Size = new System.Drawing.Size(177, 20);
            this.txtapeMat.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.button1.Location = new System.Drawing.Point(109, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 36);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Apellido materno:";
            // 
            // txtxape
            // 
            this.txtxape.Location = new System.Drawing.Point(80, 85);
            this.txtxape.Name = "txtxape";
            this.txtxape.Size = new System.Drawing.Size(177, 20);
            this.txtxape.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Apellido paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nombres:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(80, 59);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(177, 20);
            this.txtCliente.TabIndex = 52;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(469, 482);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(76, 20);
            this.txttotal.TabIndex = 51;
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(392, 482);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 23);
            this.btntotal.TabIndex = 52;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(624, 3);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(212, 20);
            this.dtpfecha.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtxprecio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.cboxservicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblbuscar);
            this.groupBox2.Location = new System.Drawing.Point(8, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 105);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de servicios";
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::MASTER_TUNE_UP.Properties.Resources.error_1526110;
            this.btnsalir.Location = new System.Drawing.Point(732, 439);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(61, 28);
            this.btnsalir.TabIndex = 55;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Trabajos
            // 
            this.Trabajos.HeaderText = "Trabajos";
            this.Trabajos.Name = "Trabajos";
            this.Trabajos.ReadOnly = true;
            this.Trabajos.Width = 250;
            // 
            // Precio1
            // 
            this.Precio1.HeaderText = "Precio";
            this.Precio1.Name = "Precio1";
            // 
            // gpboxtipo
            // 
            this.gpboxtipo.Controls.Add(this.rdbtncontado);
            this.gpboxtipo.Controls.Add(this.rdbtncreito);
            this.gpboxtipo.Location = new System.Drawing.Point(468, 46);
            this.gpboxtipo.Name = "gpboxtipo";
            this.gpboxtipo.Size = new System.Drawing.Size(105, 62);
            this.gpboxtipo.TabIndex = 58;
            this.gpboxtipo.TabStop = false;
            this.gpboxtipo.Text = "Tipo";
            // 
            // rdbtncontado
            // 
            this.rdbtncontado.AutoSize = true;
            this.rdbtncontado.Checked = true;
            this.rdbtncontado.Location = new System.Drawing.Point(11, 19);
            this.rdbtncontado.Name = "rdbtncontado";
            this.rdbtncontado.Size = new System.Drawing.Size(65, 17);
            this.rdbtncontado.TabIndex = 13;
            this.rdbtncontado.TabStop = true;
            this.rdbtncontado.Text = "Contado";
            this.rdbtncontado.UseVisualStyleBackColor = true;
            this.rdbtncontado.CheckedChanged += new System.EventHandler(this.rdbtncontado_CheckedChanged);
            this.rdbtncontado.Click += new System.EventHandler(this.rdbtncontado_Click);
            // 
            // rdbtncreito
            // 
            this.rdbtncreito.AutoSize = true;
            this.rdbtncreito.Location = new System.Drawing.Point(11, 41);
            this.rdbtncreito.Name = "rdbtncreito";
            this.rdbtncreito.Size = new System.Drawing.Size(58, 17);
            this.rdbtncreito.TabIndex = 14;
            this.rdbtncreito.Text = "Credito";
            this.rdbtncreito.UseVisualStyleBackColor = true;
            this.rdbtncreito.Click += new System.EventHandler(this.rdbtncreito_Click);
            // 
            // txtfolio
            // 
            this.txtfolio.Enabled = false;
            this.txtfolio.Location = new System.Drawing.Point(676, 67);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(57, 20);
            this.txtfolio.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Folio";
            // 
            // Frmservicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 533);
            this.Controls.Add(this.gpboxtipo);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.dgServicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmservicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmservicios_FormClosing);
            this.Load += new System.EventHandler(this.Frmservicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpboxtipo.ResumeLayout(false);
            this.gpboxtipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgServicios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.TextBox txtxprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxservicio;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtxape;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtteleono;
        private System.Windows.Forms.TextBox txtapeMat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.GroupBox gpboxtipo;
        private System.Windows.Forms.RadioButton rdbtncontado;
        private System.Windows.Forms.RadioButton rdbtncreito;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label8;
    }
}