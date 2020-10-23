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
    public partial class Frmclientes : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public Frmclientes()
        {
            InitializeComponent();
        }
        private void maximo()
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(Cl_id)+1 as ultimo from clientes";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtclave.Text = leer["ultimo"].ToString();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtclave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtclave.Enabled = true;
                    txtclave.Clear();
                    txtclave.Focus();
                }
                else
                {
                    //no fue nulo

                    objconexion = new Clases.Conexión();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from clientes where cl_id=@cl_id";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@Cl_id", this.txtclave.Text);
                    comando.Parameters.AddWithValue("@Cl_nom", this.txtnombre.Text);
                    comando.Parameters.AddWithValue("@Cl_ape", this.txtxape.Text);
                    comando.Parameters.AddWithValue("@Cl_dire", this.txtdomicilio.Text);
                    comando.Parameters.AddWithValue("@Cl_loc", this.cboxlocalidad.Text);
                    comando.Parameters.AddWithValue("@Cl_tel", this.txtteleono.Text);
                    comando.Parameters.AddWithValue("@Cl_email", this.txtemail.Text); 
                    comando.Parameters.AddWithValue("@Cl_apemat", this.txtapeMat.Text);
                    comando.Parameters.AddWithValue("@Cl_estatus", this.cboxclientee.SelectedIndex);


                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtxape.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtemail.Enabled = true;
                        txtapeMat.Enabled = true;
                        cboxlocalidad.Enabled = true;
                        txtteleono.Enabled = true;
                        txtnombre.Focus();
                        txtclave.Enabled = false;
                        btngrabar.Enabled = true;
                        btneliminar.Enabled = true;
                        cboxclientee.Enabled = true;

                        //igualo los campos o columnas al txtnombre
                        txtnombre.Text = leer["Cl_nom"].ToString();
                        txtxape.Text = leer["Cl_ape"].ToString();
                        txtdomicilio.Text = leer["Cl_dire"].ToString();
                        estatus = int.Parse(leer["Cl_estatus"].ToString());
                        txtemail.Text = leer["Cl_email"].ToString();
                        txtclave.Text = leer["Cl_id"].ToString();
                        txtteleono.Text = leer["Cl_tel"].ToString();
                        cboxlocalidad.Text =leer["Cl_loc"].ToString();
                        txtapeMat.Text = leer["Cl_apemat"].ToString();

                        if (estatus == 1)
                        {
                            cboxclientee.SelectedIndex = estatus - 1;
                        }
                        else
                        {
                            cboxclientee.SelectedIndex = estatus + 1;
                        }
                        if (estatus == 0)
                        {
                            MessageBox.Show("Grupo dado de baja", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btneliminar.Enabled = false;
                            btngrabar.Enabled = false;
                            cboxclientee.Enabled = false;
                            txtnombre.Enabled = true;
                            txtdomicilio.Enabled = false;
                            txtemail.Enabled = false;
                            cboxlocalidad.Enabled = false;
                            txtapeMat.Enabled = false;
                            limpiar();



                        }
                    }
                    else
                    {
                        //si lavariable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("Cliente no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //poner un habilitar aqui
                            txtnombre.Enabled = true;
                            txtnombre.Focus();
                        }
                    }
                }
        }
        private void limpiar()
        {
            btngrabar.Enabled = false;
            btneliminar.Enabled = false;
            cboxclientee.Enabled = false;
            cboxclientee.ResetText();
            txtemail.Enabled = false;
            txtemail.Clear();
            txtteleono.Enabled = false;
            txtteleono.Clear();
            cboxlocalidad.Enabled = false;
            txtdomicilio.Enabled = false;
            txtdomicilio.Clear();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtxape.Clear();
            txtapeMat.Clear();
            txtapeMat.Enabled = false;
            txtxape.Enabled = false;
            txtclave.Enabled = true;
            txtclave.Clear();
            txtclave.Focus();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "insert into Clientes values(@Cl_id,@Cl_nom,@Cl_ape,@Cl_dire,@Cl_loc,@Cl_email,@Cl_tel,@Cl_estatus,@Cl_apemat)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Cl_id", txtclave.Text);  
                comando.Parameters.AddWithValue("@Cl_nom", txtnombre.Text);
                comando.Parameters.AddWithValue("@Cl_ape", txtxape.Text);
                comando.Parameters.AddWithValue("@Cl_dire", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@Cl_loc", cboxlocalidad.Text);
                comando.Parameters.AddWithValue("@Cl_email", txtemail.Text);
                comando.Parameters.AddWithValue("@Cl_tel", txtteleono.Text);
                comando.Parameters.AddWithValue("@Cl_estatus", cboxclientee.SelectedIndex);
                comando.Parameters.AddWithValue("@Cl_apemat", txtapeMat.Text);
                comando.ExecuteNonQuery();//es para verificar los editados
                Acceso acceso = new Acceso();
                string actividad = "El usuario registró al cliente " + txtnombre.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Cliente guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                maximo();
                

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "update Clientes set Cl_nom=@Cl_nom,Cl_ape=@Cl_ape,Cl_dire=@Cl_dire,Cl_loc=@Cl_loc,Cl_email=@Cl_email,Cl_tel=@Cl_tel,Cl_apemat=@Cl_apemat where Cl_id=@Cl_id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_login
                comando.Parameters.AddWithValue("@Cl_id", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@Cl_nom", txtnombre.Text);
                comando.Parameters.AddWithValue("@Cl_ape", txtxape.Text);
                comando.Parameters.AddWithValue("@Cl_dire", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@Cl_loc", cboxlocalidad.Text);
                comando.Parameters.AddWithValue("@Cl_email", txtemail.Text);
                comando.Parameters.AddWithValue("@Cl_tel", txtteleono.Text);
                comando.Parameters.AddWithValue("@Cl_estatus", cboxclientee.SelectedIndex);
                comando.Parameters.AddWithValue("@Cl_apemat", txtapeMat.Text);

                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario modifico al cliente " + txtnombre.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Cliente modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar(); //dejar el forms como el inicio
                maximo();
                

            }
        }
        
        private void llenarcboxlocalidad()
        {
            DataTable dt = new DataTable();
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT * from Localidad where lo_Id >=1 order by lo_Nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxlocalidad.DataSource = dt;
            this.cboxlocalidad.ValueMember = "lo_Id";
            this.cboxlocalidad.DisplayMember = "lo_Nombre";
            Conexion.Close();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre el contenido
            Conexion.Open();
            string query = "update Clientes set Cl_estatus=0 where Cl_id=@Cl_id";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Cl_id", txtclave.Text);
            if (MessageBox.Show("El cliente se dara de baja,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario  Elimino al cliente " + txtnombre.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Cliente eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtxape.Enabled = true;
                txtxape.Focus();
            }
        }

        private void txtxape_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtapeMat.Enabled = true;
                txtapeMat.Focus();
            }
        }

        private void txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                cboxlocalidad.Enabled = true;
                cboxlocalidad.Focus();
            }
        }

        private void txtteleono_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtemail.Enabled = true;
                txtemail.Focus();
            }
        }
        private void txtapeMat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                txtdomicilio.Enabled = true;
                txtdomicilio.Focus();
            }
        }
        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxclientee.Enabled = true;
                cboxclientee.Focus();
                btngrabar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            cboxclientee.Text = "seleccione";
            cboxclientee.Items.Add("mayoreo");
            cboxclientee.Items.Add("menudeo");
            maximo();
            txtclave.Focus();
            Acceso acceso = new Acceso();
            string actividad = "El usuario ingreso a Registro de clientes.";
            acceso.Registrar_auditoria(actividad);
            llenarcboxlocalidad();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmclientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario  salio de registro de clientes.";
            acceso.Registrar_auditoria(actividad);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxCliente.Visible = true;
            cboxCliente.Focus();
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
            string query = "SELECT * from Clientes where Cl_id >=1 order by Cl_nom";

            //defino comando  Cl_id=@Cl_id
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxCliente.DataSource = dt;
            this.cboxCliente.ValueMember = "Cl_id";
            this.cboxCliente.DisplayMember = "Cl_nom";
            Conexion.Close();

        }

        private void cboxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxCliente.SelectedValue.ToString();
                //valido
                lblbuscar.Visible = false;
                cboxCliente.Visible = false;
                cboxCliente.Enabled = true;
                txtclave.Focus();


            }
        }

        private void cboxlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtteleono.Enabled = true;
                txtteleono.Focus();
            }
        }
    }
}
       
     
    

