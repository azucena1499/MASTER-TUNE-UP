﻿using System;
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
                    comando.Parameters.AddWithValue("@Cl_loc", this.txtlocalidad.Text);
                    comando.Parameters.AddWithValue("@Cl_tel", this.txtteleono.Text);
                    comando.Parameters.AddWithValue("@Cl_email", this.txtemail.Text);

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
                        txtlocalidad.Enabled = true;
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
                        txtlocalidad.Text = leer["Cl_loc"].ToString();

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
                            txtlocalidad.Enabled = false;
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
            txtlocalidad.Enabled = false;
            txtlocalidad.Clear();
            txtdomicilio.Enabled = false;
            txtdomicilio.Clear();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtxape.Clear();
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
                string query = "insert into Clientes values(@Cl_id,@Cl_nom,@Cl_ape,@Cl_dire,@Cl_loc,@Cl_email,@Cl_tel,@Cl_estatus)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Cl_id", txtclave.Text);  
                comando.Parameters.AddWithValue("@Cl_nom", txtnombre.Text);
                comando.Parameters.AddWithValue("@Cl_ape", txtxape.Text);
                comando.Parameters.AddWithValue("@Cl_dire", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@Cl_loc", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@Cl_email", txtemail.Text);
                comando.Parameters.AddWithValue("@Cl_tel", txtteleono.Text);
                comando.Parameters.AddWithValue("@Cl_estatus", cboxclientee.SelectedIndex);
                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("Cliente guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                Maximo();

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "update Clientes set Cl_nom=@Cl_nom,Cl_dire=@Cl_dire,Cl_ape=@Cl_ape, Cl_loc=@Cl_loc,Cl_tel=@Cl_tel,Cl_email=@Cl_email where Cl_id=@Cl_id";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_login
                comando.Parameters.AddWithValue("@Cl_id", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@Cl_dire", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@Cl_ape", txtxape.Text);
                comando.Parameters.AddWithValue("@Cl_loc", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@Cl_nom", txtnombre.Text);
                comando.Parameters.AddWithValue("@Cl_estatus", cboxclientee.SelectedIndex);
                comando.Parameters.AddWithValue("@Cl_tel", txtteleono.Text);
                comando.Parameters.AddWithValue("@Cl_email", txtemail.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar(); //dejar el forms como el inicio
                Maximo();

            }
        }
        private void Maximo()
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "Select max(Cl_id)+1 as ultimo from Clientes";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtclave.Text = leer["ultimo"].ToString();
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
                MessageBox.Show("Cliente dado de baja", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtdomicilio.Enabled = true;
                txtdomicilio.Focus();
            }
        }

        private void txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtlocalidad.Enabled = true;
                txtlocalidad.Focus();
            }
        }

        private void txtlocalidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtteleono.Enabled = true;
                txtteleono.Focus();
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
            Maximo();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
       
     
    
