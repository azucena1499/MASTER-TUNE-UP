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
    public partial class frmdatosg : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        int existe = 0;
        public frmdatosg()
        {
            InitializeComponent();
        }

        private void frmdatosg_Load(object sender, EventArgs e)
        {

            Acceso acceso = new Acceso();
            string actividad = "El usuario  ingreso a Datos Generales.";
            acceso.Registrar_auditoria(actividad);

            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "Select * from Datosg";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dg_Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@dg_gerente", txtgerente.Text);
            comando.Parameters.AddWithValue("@dg_domi", txtdomicilio.Text);
            comando.Parameters.AddWithValue("@dg_loca", txtlocalidad.Text);
            comando.Parameters.AddWithValue("@dg_tlefono", txttel.Text);
            comando.Parameters.AddWithValue("@dg_emal", txtemail.Text);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                existe = 1;
                //lo encuentro
                txtnombre.Text = leer["dg_Nombre"].ToString();
                txtgerente.Text = leer["dg_gerente"].ToString();
                txtdomicilio.Text = leer["dg_domi"].ToString();
                txtlocalidad.Text = leer["dg_loca"].ToString();
                txttel.Text = leer["dg_tlefono"].ToString();
                txtemail.Text = leer["dg_emal"].ToString();

    

            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            if (existe == 1)
            {
                //fue un 0
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion   set
                Conexion.Open();
                string query = "update  Datosg  set dg_Nombre=@dg_Nombre,dg_gerente=@dg_gerente,dg_domi=@dg_domi,dg_loca=@dg_loca,dg_tlefono=@dg_tlefono,dg_emal=@dg_emal";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@dg_Nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@dg_gerente", txtgerente.Text);
                comando.Parameters.AddWithValue("@dg_domi", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@dg_loca", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@dg_tlefono", txttel.Text);
                comando.Parameters.AddWithValue("@dg_emal", txtemail.Text);
                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario Modifico Datos Generales " ;
                acceso.Registrar_auditoria(actividad);

                MessageBox.Show("Datos Generales se modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                //txtnombre.Clear();
                //txtdomicilio.Clear();
                //txtlocalidad.Clear();
                //txtgerente.Clear();
                //txtlocalidad.Clear();
                //txttel.Clear();
                //txtemail.Clear();
            }
        }

        private void frmdatosg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario  salio de registro de Datos Generales.";
            acceso.Registrar_auditoria(actividad);
        }
    }
}










