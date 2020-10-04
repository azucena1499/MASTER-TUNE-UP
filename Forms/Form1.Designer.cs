namespace MASTER_TUNE_UP
{
    partial class FrnLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnLogin));
            this.lblnivel = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaccesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(413, 189);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(29, 13);
            this.lblnivel.TabIndex = 17;
            this.lblnivel.Text = "nivel";
            // 
            // txtnivel
            // 
            this.txtnivel.Enabled = false;
            this.txtnivel.Location = new System.Drawing.Point(379, 205);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(100, 20);
            this.txtnivel.TabIndex = 16;
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(208, 281);
            this.txtpassword.MaxLength = 10;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 13;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "password";
            // 
            // Txtusuario
            // 
            this.Txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtusuario.Location = new System.Drawing.Point(208, 205);
            this.Txtusuario.MaxLength = 100;
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(100, 20);
            this.Txtusuario.TabIndex = 11;
            this.Txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtusuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "usuario";
            // 
            // btnaccesar
            // 
            this.btnaccesar.BackColor = System.Drawing.Color.Honeydew;
            this.btnaccesar.Image = global::MASTER_TUNE_UP.Properties.Resources.comprobar23;
            this.btnaccesar.Location = new System.Drawing.Point(190, 354);
            this.btnaccesar.Name = "btnaccesar";
            this.btnaccesar.Size = new System.Drawing.Size(76, 37);
            this.btnaccesar.TabIndex = 14;
            this.btnaccesar.UseVisualStyleBackColor = false;
            this.btnaccesar.Click += new System.EventHandler(this.btnaccesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MASTER_TUNE_UP.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(190, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 136);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(297, 354);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(62, 37);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnaccesar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrnLogin";
            this.Text = "Acceso al sistema version 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnaccesar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

