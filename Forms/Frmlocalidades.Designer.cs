namespace MASTER_TUNE_UP.Forms
{
    partial class Frmlocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlocalidades));
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxservicio = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(243, 22);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(122, 13);
            this.lblbuscar.TabIndex = 46;
            this.lblbuscar.Text = "consulta de Localidades";
            this.lblbuscar.Visible = false;
            // 
            // cboxservicio
            // 
            this.cboxservicio.FormattingEnabled = true;
            this.cboxservicio.Location = new System.Drawing.Point(217, 47);
            this.cboxservicio.Name = "cboxservicio";
            this.cboxservicio.Size = new System.Drawing.Size(166, 21);
            this.cboxservicio.TabIndex = 45;
            this.cboxservicio.Visible = false;
            this.cboxservicio.SelectedIndexChanged += new System.EventHandler(this.cboxservicio_SelectedIndexChanged);
            this.cboxservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxservicio_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(67, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 20);
            this.txtnombre.TabIndex = 43;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyUp);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(67, 48);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(63, 20);
            this.txtclave.TabIndex = 42;
            this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclave_KeyDown);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Clave";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::MASTER_TUNE_UP.Properties.Resources.cruzar3;
            this.btnEliminar.Location = new System.Drawing.Point(430, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 41);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = global::MASTER_TUNE_UP.Properties.Resources.disquete4;
            this.btnguardar.Location = new System.Drawing.Point(357, 205);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(55, 41);
            this.btnguardar.TabIndex = 49;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.UseWaitCursor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::MASTER_TUNE_UP.Properties.Resources.lupa3;
            this.btnbuscar.Location = new System.Drawing.Point(138, 38);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(64, 36);
            this.btnbuscar.TabIndex = 44;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::MASTER_TUNE_UP.Properties.Resources.error_1526110;
            this.btnsalir.Location = new System.Drawing.Point(682, 274);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(61, 28);
            this.btnsalir.TabIndex = 51;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Frmlocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 314);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.cboxservicio);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlocalidades";
            this.Text = "Localidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmlocalidades_FormClosing);
            this.Load += new System.EventHandler(this.Frmlocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxservicio;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
    }
}