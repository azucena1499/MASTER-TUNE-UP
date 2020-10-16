namespace MASTER_TUNE_UP.Forms
{
    partial class Frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclientes));
            this.cboxclientee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtteleono = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxape = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtapeMat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxlocalidad = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxclientee
            // 
            this.cboxclientee.Enabled = false;
            this.cboxclientee.FormattingEnabled = true;
            this.cboxclientee.Location = new System.Drawing.Point(75, 91);
            this.cboxclientee.Name = "cboxclientee";
            this.cboxclientee.Size = new System.Drawing.Size(120, 21);
            this.cboxclientee.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "tipo cliente:";
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(68, 58);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(202, 20);
            this.txtemail.TabIndex = 33;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // txtteleono
            // 
            this.txtteleono.Enabled = false;
            this.txtteleono.Location = new System.Drawing.Point(68, 25);
            this.txtteleono.Name = "txtteleono";
            this.txtteleono.Size = new System.Drawing.Size(109, 20);
            this.txtteleono.TabIndex = 32;
            this.txtteleono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtteleono_KeyDown);
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(432, 321);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(207, 20);
            this.txtlocalidad.TabIndex = 31;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Enabled = false;
            this.txtdomicilio.Location = new System.Drawing.Point(59, 22);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(177, 20);
            this.txtdomicilio.TabIndex = 30;
            this.txtdomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdomicilio_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(68, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 20);
            this.txtnombre.TabIndex = 29;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(43, 22);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(51, 20);
            this.txtclave.TabIndex = 28;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clave:";
            // 
            // txtxape
            // 
            this.txtxape.Enabled = false;
            this.txtxape.Location = new System.Drawing.Point(92, 86);
            this.txtxape.Name = "txtxape";
            this.txtxape.Size = new System.Drawing.Size(177, 20);
            this.txtxape.TabIndex = 43;
            this.txtxape.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtxape_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Apellido paterno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblbuscar);
            this.groupBox1.Controls.Add(this.txtapeMat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboxCliente);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtxape);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 145);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(230, 7);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(95, 13);
            this.lblbuscar.TabIndex = 51;
            this.lblbuscar.Text = "Cliente por nombre";
            this.lblbuscar.Visible = false;
            // 
            // txtapeMat
            // 
            this.txtapeMat.Location = new System.Drawing.Point(93, 112);
            this.txtapeMat.Name = "txtapeMat";
            this.txtapeMat.Size = new System.Drawing.Size(177, 20);
            this.txtapeMat.TabIndex = 50;
            this.txtapeMat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtapeMat_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Apellido materno:";
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(210, 23);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(166, 21);
            this.cboxCliente.TabIndex = 48;
            this.cboxCliente.Visible = false;
            this.cboxCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxCliente_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.btnbuscar.Location = new System.Drawing.Point(140, 10);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 36);
            this.btnbuscar.TabIndex = 47;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxlocalidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdomicilio);
            this.groupBox2.Location = new System.Drawing.Point(356, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 99);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del domicilio";
            // 
            // cboxlocalidad
            // 
            this.cboxlocalidad.FormattingEnabled = true;
            this.cboxlocalidad.Location = new System.Drawing.Point(61, 56);
            this.cboxlocalidad.Name = "cboxlocalidad";
            this.cboxlocalidad.Size = new System.Drawing.Size(166, 21);
            this.cboxlocalidad.TabIndex = 46;
            this.cboxlocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxlocalidad_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxclientee);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtteleono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 128);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::MASTER_TUNE_UP.Properties.Resources.error_152618;
            this.btncerrar.Location = new System.Drawing.Point(509, 381);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 41);
            this.btncerrar.TabIndex = 36;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = global::MASTER_TUNE_UP.Properties.Resources.cruzar4;
            this.btneliminar.Location = new System.Drawing.Point(432, 381);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(54, 41);
            this.btneliminar.TabIndex = 35;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Image = global::MASTER_TUNE_UP.Properties.Resources.disquete5;
            this.btngrabar.Location = new System.Drawing.Point(356, 381);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(55, 41);
            this.btngrabar.TabIndex = 34;
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btngrabar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmclientes";
            this.Text = "Registro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmclientes_FormClosing);
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxclientee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtteleono;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxape;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtapeMat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxlocalidad;
    }
}