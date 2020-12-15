namespace MASTER_TUNE_UP.Forms
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
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpServicio = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardarTodo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbluser2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpServicio.SuspendLayout();
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
            this.dgServicios.Enabled = false;
            this.dgServicios.Location = new System.Drawing.Point(8, 280);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.Size = new System.Drawing.Size(493, 181);
            this.dgServicios.TabIndex = 30;
            this.dgServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgServicios_CellContentClick);
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
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = global::MASTER_TUNE_UP.Properties.Resources.cruzar4;
            this.btneliminar.Location = new System.Drawing.Point(711, 444);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(54, 43);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Image = global::MASTER_TUNE_UP.Properties.Resources.comprobar1;
            this.btngrabar.Location = new System.Drawing.Point(368, 40);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(34, 34);
            this.btngrabar.TabIndex = 37;
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            this.btngrabar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btngrabar_KeyPress);
            // 
            // txtxprecio
            // 
            this.txtxprecio.Enabled = false;
            this.txtxprecio.Location = new System.Drawing.Point(249, 100);
            this.txtxprecio.Name = "txtxprecio";
            this.txtxprecio.Size = new System.Drawing.Size(45, 20);
            this.txtxprecio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Precio";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(136, 28);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(158, 13);
            this.lblbuscar.TabIndex = 46;
            this.lblbuscar.Text = "Consulta de servicio por nombre";
            this.lblbuscar.Visible = false;
            // 
            // cboxservicio
            // 
            this.cboxservicio.FormattingEnabled = true;
            this.cboxservicio.Location = new System.Drawing.Point(128, 53);
            this.cboxservicio.Name = "cboxservicio";
            this.cboxservicio.Size = new System.Drawing.Size(166, 21);
            this.cboxservicio.TabIndex = 45;
            this.cboxservicio.Visible = false;
            this.cboxservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxservicio_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.btnbuscar.Location = new System.Drawing.Point(70, 40);
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
            this.txtnombre.Location = new System.Drawing.Point(6, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(195, 20);
            this.txtnombre.TabIndex = 43;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(48, 20);
            this.txtCodigo.TabIndex = 42;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 222);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(6, 35);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(61, 20);
            this.txtclave.TabIndex = 67;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Clave:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cliente por nombre";
            this.label6.Visible = false;
            // 
            // txtteleono
            // 
            this.txtteleono.Enabled = false;
            this.txtteleono.Location = new System.Drawing.Point(6, 194);
            this.txtteleono.Name = "txtteleono";
            this.txtteleono.Size = new System.Drawing.Size(182, 20);
            this.txtteleono.TabIndex = 58;
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(169, 34);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(173, 21);
            this.cboxCliente.TabIndex = 60;
            this.cboxCliente.Visible = false;
            this.cboxCliente.SelectedIndexChanged += new System.EventHandler(this.cboxCliente_SelectedIndexChanged);
            this.cboxCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxCliente_KeyPress);
            // 
            // txtapeMat
            // 
            this.txtapeMat.Enabled = false;
            this.txtapeMat.Location = new System.Drawing.Point(6, 155);
            this.txtapeMat.Name = "txtapeMat";
            this.txtapeMat.Size = new System.Drawing.Size(182, 20);
            this.txtapeMat.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.button1.Location = new System.Drawing.Point(101, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 31);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(9, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Apellido materno:";
            // 
            // txtxape
            // 
            this.txtxape.Enabled = false;
            this.txtxape.Location = new System.Drawing.Point(6, 116);
            this.txtxape.Name = "txtxape";
            this.txtxape.Size = new System.Drawing.Size(182, 20);
            this.txtxape.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(10, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Apellido paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nombres:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(6, 77);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 20);
            this.txtCliente.TabIndex = 52;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(427, 467);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(76, 20);
            this.txttotal.TabIndex = 51;
            // 
            // btntotal
            // 
            this.btntotal.Enabled = false;
            this.btntotal.Location = new System.Drawing.Point(377, 467);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(48, 23);
            this.btntotal.TabIndex = 52;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Location = new System.Drawing.Point(624, 3);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(212, 20);
            this.dtpfecha.TabIndex = 53;
            // 
            // grpServicio
            // 
            this.grpServicio.Controls.Add(this.txtxprecio);
            this.grpServicio.Controls.Add(this.label1);
            this.grpServicio.Controls.Add(this.label2);
            this.grpServicio.Controls.Add(this.txtCodigo);
            this.grpServicio.Controls.Add(this.txtnombre);
            this.grpServicio.Controls.Add(this.btnbuscar);
            this.grpServicio.Controls.Add(this.cboxservicio);
            this.grpServicio.Controls.Add(this.label3);
            this.grpServicio.Controls.Add(this.lblbuscar);
            this.grpServicio.Controls.Add(this.btngrabar);
            this.grpServicio.Enabled = false;
            this.grpServicio.Location = new System.Drawing.Point(418, 41);
            this.grpServicio.Name = "grpServicio";
            this.grpServicio.Size = new System.Drawing.Size(418, 152);
            this.grpServicio.TabIndex = 54;
            this.grpServicio.TabStop = false;
            this.grpServicio.Text = "Busqueda de servicios";
            // 
            // btnsalir
            // 
            this.btnsalir.Enabled = false;
            this.btnsalir.Image = global::MASTER_TUNE_UP.Properties.Resources.error_1526110;
            this.btnsalir.Location = new System.Drawing.Point(775, 444);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(61, 43);
            this.btnsalir.TabIndex = 55;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardarTodo
            // 
            this.btnguardarTodo.Enabled = false;
            this.btnguardarTodo.Image = global::MASTER_TUNE_UP.Properties.Resources.disquete4;
            this.btnguardarTodo.Location = new System.Drawing.Point(643, 444);
            this.btnguardarTodo.Name = "btnguardarTodo";
            this.btnguardarTodo.Size = new System.Drawing.Size(54, 43);
            this.btnguardarTodo.TabIndex = 59;
            this.btnguardarTodo.UseVisualStyleBackColor = true;
            this.btnguardarTodo.Click += new System.EventHandler(this.btnguardarTodo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(546, 307);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(61, 32);
            this.btnImprimir.TabIndex = 49;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(53, 3);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(61, 20);
            this.txtFolio.TabIndex = 69;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Folio:";
            // 
            // lbluser2
            // 
            this.lbluser2.AutoSize = true;
            this.lbluser2.Location = new System.Drawing.Point(5, 10);
            this.lbluser2.Name = "lbluser2";
            this.lbluser2.Size = new System.Drawing.Size(0, 13);
            this.lbluser2.TabIndex = 70;
            this.lbluser2.Visible = false;
            // 
            // Frmservicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 533);
            this.Controls.Add(this.lbluser2);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnguardarTodo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.grpServicio);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneliminar);
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
            this.grpServicio.ResumeLayout(false);
            this.grpServicio.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpServicio;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.Button btnguardarTodo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbluser2;
    }
}