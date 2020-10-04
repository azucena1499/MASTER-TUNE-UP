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
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "Select * from Datosg";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dg_Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@dg_gerente", txtdomicilio.Text);
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
    }
}











//    if (e.KeyChar == 13)
//    if (string.IsNullOrEmpty(txtclave.Text))
//    {
//        MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        txtclave.Enabled = true;
//        txtclave.Clear();
//        txtclave.Focus();
//    }
//    else
//    {
//        //no fue nulo

//        objconexion = new Clases.Conexión();
//        Conexion = new SqlConnection(objconexion.Conn());
//        //se abre la conexion
//        Conexion.Open();
//        string query = "select * from Datosg where dg_codigo=@dg_codigo";
//            SqlCommand comando = new SqlCommand(query, Conexion);
//            //inicializo cualquier parametrodefinido anteriormente
//            comando.Parameters.Clear();
//            //cualquier variable,pero se recomienda usar el mismo nombre del campo
//            comando.Parameters.AddWithValue("@dg_codigo", this.txtclave.Text);
//            //asigno a leer el sqldatareader para leer el registro.
//            SqlDataReader leer = comando.ExecuteReader();

//        if (leer.Read())
//        {
//            //inicializo la variable 1 para que el programa sepa que existe
//            existe = 1;
//            txtnombre.Enabled = true;
//            txtclave.Enabled = true;
//            txtdomicilio.Enabled = true;
//            txtemail.Enabled = true;
//            txtlocalidad.Enabled = true;
//            txttel.Enabled = true;
//            txtnombre.Focus();
//            txtclave.Enabled = false;

//            //igualo los campos o columnas al txtnombre
//            txtnombre.Text = leer["dg_Nombre"].ToString();
//            txtgerente.Text = leer["@dg_gerente"].ToString();
//            txtdomicilio.Text = leer["@dg_domi"].ToString();
//            txtlocalidad.Text = leer["@dg_loca"].ToString();
//            txttel.Text = leer["@dg_tel"].ToString();
//            txtemail.Text = leer["@dg_emal"].ToString();
//            txtclave.Text = leer["dg_codigo"].ToString();


//        }
//        else
//        {
//            //si lavariable existe vale 0 y se usara insert
//            existe = 0;
//            if (MessageBox.Show("Cliente no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
//            {
//                //poner un habilitar aqui
//                txtnombre.Enabled = true;
//                txtnombre.Focus();
//            }
//        }
//    }






//comando.Parameters.AddWithValue("@dg_Nombre", this.txtnombre.Text);
//comando.Parameters.AddWithValue("@dg_gerente", this.txtgerente.Text);
//comando.Parameters.AddWithValue("@dg_domi", this.txtdomicilio.Text);
//comando.Parameters.AddWithValue("@dg_loca", this.txtlocalidad.Text);
//comando.Parameters.AddWithValue("@dg_tel", this.txttel.Text);
//comando.Parameters.AddWithValue("@dg_emal", this.txtemail.Text);
//comando.Parameters.AddWithValue("dg_codigo", this.txtclave);
