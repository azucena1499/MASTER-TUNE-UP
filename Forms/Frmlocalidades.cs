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
    public partial class Frmlocalidades : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public Frmlocalidades()
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

                    objconexion = new Clases.Conexión();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from Localidad where lo_Id=@lo_Id";
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@lo_Id", this.txtclave.Text);
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
                        txtnombre.Text = leer["lo_Nombre"].ToString();


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
            this.cboxservicio.DataSource = dt;
            this.cboxservicio.ValueMember = "lo_Id";
            this.cboxservicio.DisplayMember = "lo_Nombre";
            Conexion.Close();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                Conexion.Open();
                string query = "insert into Localidad values(@lo_Id,@lo_Nombre)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@lo_Id", txtclave.Text);
                comando.Parameters.AddWithValue("@lo_Nombre", txtnombre.Text);
                comando.ExecuteNonQuery();//es para verificar los editados
                Acceso acceso = new Acceso();
                string actividad = "El usuario registró la localidad " + txtnombre.Text + "."; acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Localidad guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "update Localidad set lo_Nombre=@lo_Nombre where lo_Id=@lo_Id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@lo_Id", txtclave.Text);
                comando.Parameters.AddWithValue("@lo_Nombre", txtnombre.Text);
                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario modificó la localidad " + txtnombre.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Servicio modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                cboxservicio.ResetText();
                txtnombre.Clear();
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();

            }
        }
        private void limpiar()
        {
            txtclave.Clear();
            txtclave.Focus();
            txtnombre.Clear();
            cboxservicio.ResetText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre el contenido
            Conexion.Open();
            string query = "DELETE from Localidad where lo_Id=" + txtclave.Text;
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            if (MessageBox.Show("La Localidad sera eliminada,está seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Localidad Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtnombre.Enabled = true;
                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnguardar.Enabled = true;
                btnguardar.Focus();
            }
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

        private void cboxservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmlocalidades_Load(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario  Ingreso a Localidades.";
            acceso.Registrar_auditoria(actividad);
        }

        private void Frmlocalidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario  salio de Localidades.";
            acceso.Registrar_auditoria(actividad);
        }
    }

}
