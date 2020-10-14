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
using MASTER_TUNE_UP.Clases;

namespace MASTER_TUNE_UP.Forms
{
    public partial class frmtrabajos : Form

    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public frmtrabajos()
        {
            InitializeComponent();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtclave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //no fue nulo

                    objconexion = new Clases. Conexión();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from Servicios where se_clave=@se_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();
                    //cualquier variable,pero se recomienda usar el mismo nombre del campo
                    comando.Parameters.AddWithValue("@se_clave", this.txtclave.Text);
                    //asigno a leer el sqldatareader para leer el registro.
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtnombre.Focus();
                        txtclave.Enabled = false;
                        btnguardar.Enabled = true;
                        cboxservicio.Enabled = true;
                        btnbuscar.Enabled = true;
                        //igualo los campos o columnas al txtnombre
                        txtnombre.Text = leer["se_nombre"].ToString();
                        txtxprecio.Text = leer["se_precio"].ToString();
                        
                        
                    }
                    else
                    {
                        existe = 0;
                        if (MessageBox.Show("Servicio no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            txtnombre.Enabled = true;
                            cboxservicio.Enabled = false;
                            btnguardar.Enabled = true;
                            txtnombre.Focus();
                            txtclave.Enabled = true;


                        }

                    }

                }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxservicio.Visible = true;
            cboxservicio.Focus();
            llenarcbox();
        }
        private void llenarcbox()
        {
            //defino el data table
            DataTable dt = new DataTable();
            //establezco conex
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            //establezco mi query
            string query = "SELECT * from Servicios where se_clave >=1 order by se_nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxservicio.DataSource = dt;
            this.cboxservicio.ValueMember = "se_clave";
            this.cboxservicio.DisplayMember = "se_nombre";
            Conexion.Close();

        }

        private void cboxservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxservicio.SelectedValue.ToString();
                //valido
                lblbuscar.Visible = false;
                cboxservicio.Visible = false;
                cboxservicio.Enabled = true;
                txtclave.Focus();


            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                //string query = "select * from grupos where gr_clave=@gr_clave";
                string query = "insert into Servicios values(@se_clave,@se_nombre,@se_precio)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@se_clave", txtclave.Text); //este es para ya modificar 
                comando.Parameters.AddWithValue("@se_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@se_precio", txtxprecio.Text);
                comando.ExecuteNonQuery();//es para verificar os editados
                Acceso acceso = new Acceso();
                string actividad = "El usuario " + acceso.Usuario + " registró el servicio " + txtnombre.Text + "."; acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Servicio guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                cboxservicio.ResetText();
                txtnombre.Clear();
                cboxservicio.Text = "";
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
               

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "update Servicios set se_nombre=@se_nombre,se_precio=@se_precio where se_clave=@se_clave";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@se_clave",txtclave.Text); //este es para ya modificar 
                comando.Parameters.AddWithValue("@se_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@se_precio", txtxprecio.Text);
                //comando.Parameters.AddWithValue("@gr_estatus", cbox.SelectedIndex);
                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario " + acceso.Usuario + " modificó el servicio " + txtnombre.Text + "."; 
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Servicio modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                cboxservicio.ResetText();
                txtnombre.Clear();
                txtxprecio.Clear();
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
                
            }
        }

        private void frmservicios_Load(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario " + acceso.Usuario + " ingreso a servicios.";
            acceso.Registrar_auditoria(actividad);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmservicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario " + acceso.Usuario + " salió de servicios.";
            acceso.Registrar_auditoria(actividad);
        }
    }
}
