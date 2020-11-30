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
    public partial class Frmservicios : Form
    {
        //int i = 1;
        int existe = 0;
        int posicion;
        Clases.Conexión objconexion;
        SqlConnection Conexion;

        public Frmservicios()
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

        private void btngrabar_Click(object sender, EventArgs e)
        {
            //i = i + 1;
            dgServicios.Rows.Add(txtCodigo.Text, txtnombre.Text, txtxprecio.Text);
            txtCodigo.Clear();
            txtnombre.Clear();
            txtxprecio.Clear();
            txtCodigo.Focus();
            btneliminar.Enabled = true;
            btnsalir.Enabled = true;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //dgServicios.Rows.RemoveAt(posicion);


            if (dgServicios.RowCount > 1)
            {
                dgServicios.Rows.RemoveAt(dgServicios.CurrentRow.Index);
                txtnombre.Focus();
            }
        
            if(dgServicios.RowCount ==1)
            {
                btneliminar.Enabled = false;
                btnguardarTodo.Enabled = false;
                txtCodigo.Focus();

            }


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtCodigo.Text))
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
                    string query = "select * from Servicios where se_clave=@se_clave";
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@se_clave", this.txtCodigo.Text);
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {

                        txtnombre.Text = leer["se_nombre"].ToString();
                        txtxprecio.Text = leer["se_precio"].ToString();
                        btngrabar.Enabled = true;
                        btngrabar.Focus();

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
            Conexion.Open();
            string query = "SELECT * from Servicios where se_clave >=1 order by se_nombre";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            this.cboxservicio.DataSource = dt;
            this.cboxservicio.ValueMember = "se_clave";
            this.cboxservicio.DisplayMember = "se_nombre";
            Conexion.Close();

        }
        private void llenarcboxcliente()
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

        private void cboxservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtCodigo.Text = this.cboxservicio.SelectedValue.ToString();
                //valido
                lblbuscar.Visible = false;
                cboxservicio.Visible = false;
                cboxservicio.Enabled = true;
                txtCodigo.Focus();



            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dgServicios.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio1"].Value);
            }
            txttotal.Text = Convert.ToString(total);
        }


        private void Frmservicios_Load(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario ingreso a servicios.";
            acceso.Registrar_auditoria(actividad);
            maximo();
            
        }


        private void btngrabar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgServicios.Rows.Add(txtCodigo.Text, txtnombre.Text, txtxprecio.Text);
                txtCodigo.Clear();
                txtnombre.Clear();
                txtxprecio.Clear();
                //suma();
                txtCodigo.Focus();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxCliente.Visible = true;
            cboxCliente.Focus();
            llenarcboxcliente();
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


                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtCliente.Enabled = false;
                        txtxape.Enabled = false;
                        txtapeMat.Enabled = false;
                        txtteleono.Enabled = false;
                        txtclave.Focus();
                        txtclave.Enabled = false;

                        //igualo los campos o columnas al txtnombre
                        txtCliente.Text = leer["Cl_nom"].ToString();
                        txtxape.Text = leer["Cl_ape"].ToString();
                        txtclave.Text = leer["Cl_id"].ToString();
                        txtteleono.Text = leer["Cl_tel"].ToString();
                        txtapeMat.Text = leer["Cl_apemat"].ToString();

                        grpServicio.Enabled = true;
                        btnbuscar.Enabled = false;


                    }
                    else
                    {
                        //si lavariable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("Usuario no registrado.¿desea agregar un nuevo Servicio?", "No existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //poner un habilitar aqui
                            txtCliente.Enabled = true;
                            txtCliente.Focus();
                            maximo();
                        }
                    }
                }
        }

        private void Frmservicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario salió de Servicios.";
            acceso.Registrar_auditoria(actividad);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void rdbtncontado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtncontado_Click(object sender, EventArgs e)
        {
            if (rdbtncontado.Checked)
            {
                groupBox1.Visible = true;
                txtfolio.Enabled = false;
                txtclave.Focus();
            }
        }

        private void rdbtncreito_Click(object sender, EventArgs e)
        {
            if (rdbtncreito.Checked)
            {
                txtfolio.Enabled = true;
                dtpfecha.Enabled = true;
                groupBox1.Visible = false;
                txtfolio.Focus();


            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            if (txtclave.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btnguardarTodo_Click(object sender, EventArgs e)
        {
            dgServicios.Rows.Clear();
            MessageBox.Show("Trabajo guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }
        }
    }
}
 