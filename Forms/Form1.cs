using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MASTER_TUNE_UP.Forms;
using MASTER_TUNE_UP.Clases;

namespace MASTER_TUNE_UP
{
    public partial class FrnLogin : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        string pass;
        string nivel;
        int intento = 0;//aqui se definen las variables
        public FrnLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valores.Letras(e);
            if (e.KeyChar == 13)

            {
                //se controlan errores
                try
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Foto" + Txtusuario.Text + ".jpg");
                    pictureBox1.Visible = true;

                }
                catch (System.IO.FileNotFoundException ex)
                {
                    pictureBox1.Image = global::MASTER_TUNE_UP.Properties.Resources.user2;

                }

                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "select * from Usuario where Us_login=@Us_login";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Us_login", Txtusuario.Text);
                //asigno a leer el sqldatareader para leer el registro.
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtpassword.Enabled = true;
                    txtpassword.Focus();
                    pass = leer["us_password"].ToString();
                    nivel = leer["Us_nivel"].ToString();
                    if (nivel == "1")
                        txtnivel.Text = "administrador";
                    if (nivel == "2")
                        txtnivel.Text = "operador";
                    if (nivel == "3")
                        txtnivel.Text = "invitado";

                    txtpassword.Enabled = true;
                    txtpassword.Focus();
                    btnaccesar.Enabled = true;

                }
                else
                {
                    //lo encontro
                    MessageBox.Show("Error,usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    Txtusuario.Clear();
                    Txtusuario.Focus();



                }
            }
        }

        private void btnaccesar_Click(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            
            //regresa bool true 
            if (acceso.Login(Txtusuario.Text, txtpassword.Text))
            {
                string actividad = "El usuario " + acceso.Usuario + " ingresó al sistema.";
                acceso.Registrar_auditoria(actividad);
                this.Hide();
                Frmmenu x = new Frmmenu(Txtusuario.Text);
                x.Show();
            }
            else
            {
                MessageBox.Show("Error,contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }                                              


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valores.Numeros(e);
            if (e.KeyChar == 13)
            {
                Acceso acceso = new Acceso();
                if (acceso.Login(Txtusuario.Text, txtpassword.Text))
                {
                    btnaccesar.Enabled = true;
                    btnaccesar.Focus();
                   
                        string actividad = "El usuario ingresó al sistema.";
                        acceso.Registrar_auditoria(actividad);
                        this.Hide();
                        Frmmenu x = new Frmmenu(Txtusuario.Text);
                        x.Show();
                    

                }
                else
                {

                    if (intento <= 2)
                    {
                        MessageBox.Show("Error verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.Clear();
                        txtpassword.Focus();
                        intento++;

                    }
                    else
                    {
                        MessageBox.Show("oportunidades agotadas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();//el sistema se cierra
                    }
                }
            }
        }

        private void txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pictureBox1.Image = Image.FromFile(@"\foto\user.png");
                txtpassword.Clear();
                lblnivel.Visible = false;
                btnaccesar.Enabled = true;
                txtnivel.Visible = true;
                Txtusuario.Focus();
                Txtusuario.Clear();
                txtnivel.Clear();
            }
        }
    }
}

