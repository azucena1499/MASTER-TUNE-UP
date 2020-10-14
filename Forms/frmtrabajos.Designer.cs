namespace MASTER_TUNE_UP.Forms
{
    partial class frmtrabajos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrabajos));
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxservicio = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(266, 17);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(97, 13);
            this.lblbuscar.TabIndex = 19;
            this.lblbuscar.Text = "consulta de grupos";
            this.lblbuscar.Visible = false;
            // 
            // cboxservicio
            // 
            this.cboxservicio.FormattingEnabled = true;
            this.cboxservicio.Location = new System.Drawing.Point(240, 42);
            this.cboxservicio.Name = "cboxservicio";
            this.cboxservicio.Size = new System.Drawing.Size(166, 21);
            this.cboxservicio.TabIndex = 18;
            this.cboxservicio.Visible = false;
            this.cboxservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxservicio_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(92, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 20);
            this.txtnombre.TabIndex = 16;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(92, 42);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(63, 20);
            this.txtclave.TabIndex = 15;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clave";
            // 
            // txtxprecio
            // 
            this.txtxprecio.Location = new System.Drawing.Point(450, 75);
            this.txtxprecio.Name = "txtxprecio";
            this.txtxprecio.Size = new System.Drawing.Size(68, 20);
            this.txtxprecio.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Precio";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::MASTER_TUNE_UP.Properties.Resources.cruzar3;
            this.btncerrar.Location = new System.Drawing.Point(438, 200);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 41);
            this.btncerrar.TabIndex = 39;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = global::MASTER_TUNE_UP.Properties.Resources.disquete4;
            this.btnguardar.Location = new System.Drawing.Point(365, 200);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(55, 41);
            this.btnguardar.TabIndex = 37;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.UseWaitCursor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.btnbuscar.Location = new System.Drawing.Point(161, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 36);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmservicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 265);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtxprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.cboxservicio);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmservicios";
            this.Text = "frmservicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmservicios_FormClosing);
            this.Load += new System.EventHandler(this.frmservicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxservicio;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnguardar;
    }
}