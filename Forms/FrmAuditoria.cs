﻿using MASTER_TUNE_UP.Clases;
using MASTER_TUNE_UP.Informes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
//using MASTER_TUNE_UP.Forms;



namespace MASTER_TUNE_UP.Forms

{
    public partial class FrmAuditoria : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        private Acceso acceso;
        private int intentos = 0;
        bool existe = false;
        bool cambiarContra = false;
        private const int REGISTRANDO_USUARIO = 0;
        private const int MOSTRANDO_USUARIO = 1;
        private const int BUSCANDO = 3;
        private int estadoActual = BUSCANDO;
        private Usuario usuario = null;

      

        //greet cmda = new greet();

        public FrmAuditoria()
        {
            InitializeComponent();
            acceso = new Acceso();
            dgServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            

        }
        private bool verificarCambioContra()
        {
            return txtNuevaContra.Text.Trim().Length >= 8 && txtNuevaConfirmar.Text.Trim().Length >= 8 && txtNuevaContra.Text.Trim() == txtNuevaConfirmar.Text;
        }
        private void limpiar()
        {
            txtRegistroConfirmar.Clear();
            TxtRegistroUsuario.Clear();
            txtRegistroContra.Clear();
            TxtRegistroUsuario.Focus();
            cboxnivel.ResetText();
        }
        private void habilitarBusqueda()
        {
            if (TxtRegistroUsuario.Text.Trim() != "")//SE VERIFICA QUE NO Haya ESPACIOS Y QUE NO ESTE VACIO
            {
                btnbuscar.Enabled = true;
            }
            else
            {
                btnbuscar.Enabled = false;
            }

        }
        private void establecerNivel()
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
            int nivel = usuario.Us_nivel;
            switch (cboxnivel.SelectedIndex)
            {
                case 0:
                    nivel = 1;
                    break;
                case 1:
                    nivel = 2;
                    break;
            }
            usuario.Us_nivel = nivel;
        }
        private void habilitarGuardar()
        {
            if (TxtRegistroUsuario.Text.Trim() != "" && txtRegistroContra.Text.Trim() != "" && txtRegistroContra.Text.Length >= 8 && txtRegistroConfirmar.Text == txtRegistroContra.Text)//no vacio Long 8
            {
                btnguardar.Enabled = true;
            }
            else
            {
                btnguardar.Enabled = false;
            }

        }
        private void habilitarBorrar()
        {
            if (TxtRegistroUsuario.Text.Trim() != "")
            {
                btnBorrar.Enabled = true;
            }
            else
            {
                btnBorrar.Enabled = false;
            }
        }

        private void resetearCampos()
        {
            pictureBoxUsuario.Image = global::MASTER_TUNE_UP.Properties.Resources.user2;
            cambiarContra = false;
            txtRegistroContra.Enabled = false;
            txtRegistroContra.Text = "";
            cboxnivel.Enabled = false;
            cboxnivel.Items.Clear();
            cboxnivel.Text = "Seleccione";
            cboxnivel.Items.Add("Administrador");
            cboxnivel.Items.Add("Operador");
            labelRegistroConfirmar.Visible = false;
            txtRegistroConfirmar.Visible = false;
            txtRegistroConfirmar.Text = "";
            btnguardar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCambio.Enabled = false;
            labelCambioNueva.Visible = false;
            labelCambioConfirmar.Visible = false;
            txtNuevaContra.Text = "";
            txtNuevaContra.Visible = false;
            txtNuevaConfirmar.Text = "";
            txtNuevaConfirmar.Visible = false;
            btnGuardarCambio.Visible = false;
            btnGuardarCambio.Enabled = false;
        }
        private bool actualizarUsuario()
        {
            try
            {
                // Si son válidas, se guardan los cambios en la bd
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "update Usuario set us_password=@Us_password,Us_nivel=@Us_nivel  where Us_login=@Us_login";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_login
                comando.Parameters.AddWithValue("@Us_login", usuario.Us_login);

                comando.Parameters.AddWithValue("@Us_password", usuario.Us_password);
                comando.Parameters.AddWithValue("@Us_nivel", usuario.Us_nivel);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (TxtRegistroUsuario.Text.Trim() != "")
            {
                usuario.Us_login = TxtRegistroUsuario.Text;
                // Checar si existe
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "Select * from Usuario where Us_login = @Us_login";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Us_login", this.TxtRegistroUsuario.Text);
                SqlDataReader leer = comando.ExecuteReader();
                existe = leer.Read();
                // Si no existe
                if (!existe)
                {

                    // Validar contraseñas
                    if (txtRegistroContra.Text.Trim() != "" && txtRegistroContra.Text.Length >= 8 && txtRegistroConfirmar.Text == txtRegistroContra.Text)
                    {
                        usuario.Us_password = acceso.Encriptar(txtRegistroContra.Text);
                        objconexion = new Clases.Conexión();
                        Conexion = new SqlConnection(objconexion.Conn());
                        Conexion.Open();
                        string queryInsert = "Insert into Usuario values(@Us_login,@us_password,@Us_nivel)";
                        SqlCommand comandoInsert = new SqlCommand(queryInsert, Conexion);
                        comandoInsert.Parameters.Clear();
                        comandoInsert.Parameters.AddWithValue("@Us_login", usuario.Us_login);
                        comandoInsert.Parameters.AddWithValue("@Us_password", usuario.Us_password);
                        comandoInsert.Parameters.AddWithValue("@Us_nivel", usuario.Us_nivel);
                        comandoInsert.ExecuteNonQuery();
                        string actividad = "El usuario " + acceso.Usuario + " registró al usuario " + usuario.Us_login + ".";
                        acceso.Registrar_auditoria(actividad);
                        MessageBox.Show("Usuario guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetearCampos();
                        TxtRegistroUsuario.Text = "";
                        estadoActual = BUSCANDO;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error");
                        txtRegistroContra.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado ya existe.", "Error");
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("El usuario se ELIMINARA,esta seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre el contenido
                Conexion.Open();
                string query = "DELETE FROM  Usuario  where Us_login=@Us_login";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Us_login", TxtRegistroUsuario.Text);
                comando.ExecuteNonQuery();
                Acceso acceso = new Acceso();
                string actividad = "El usuario " + acceso.Usuario + " elimino al usuario " + TxtRegistroUsuario.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Usuario eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetearCampos();
                TxtRegistroUsuario.Text = "";
                TxtRegistroUsuario.Focus();
                estadoActual = BUSCANDO;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtRegistroUsuario.Text))
            {
                MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRegistroUsuario.Clear();
                TxtRegistroUsuario.Focus();
            }
            else
            {
                Acceso acceso = new Acceso();
                string actividad = "El usuario " + acceso.Usuario + " busco un usuario.";
                acceso.Registrar_auditoria(actividad);
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "Select * from Usuario where Us_login = @Us_login";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Us_login", this.TxtRegistroUsuario.Text);
                comando.Parameters.AddWithValue("@Us_nivel", this.cboxnivel.SelectedIndex);

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    this.usuario = new Usuario(leer["Us_login"].ToString(), leer["us_password"].ToString(), Convert.ToInt32(leer["Us_nivel"].ToString()));
                    existe = true;
                    this.estadoActual = MOSTRANDO_USUARIO;
                    this.resetearCampos();
                    try
                    {
                        pictureBoxUsuario.Image = Image.FromFile(@"C:\Foto\" + TxtRegistroUsuario.Text + ".jpg");
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        // No tiene foto
                    }
                    txtRegistroContra.Enabled = true;
                    cboxnivel.Text = leer["Us_nivel"].ToString();
                    this.ActiveControl = txtRegistroContra;
                    switch (this.usuario.Us_nivel)
                    {
                        case 1:
                            cboxnivel.SelectedIndex = 0;
                            break;
                        case 2:
                            cboxnivel.SelectedIndex = 1;
                            break;
                    }

                }
                else
                {
                    pictureBoxUsuario.Image = Image.FromFile(@"C:\Foto\user.png");
                    existe = false;
                    if (MessageBox.Show("Usuario no registrado.¿desea agregar un nuevo usuario?", "No existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        estadoActual = REGISTRANDO_USUARIO;
                        txtRegistroContra.Enabled = true;
                        labelRegistroConfirmar.Visible = true;
                        txtRegistroConfirmar.Enabled = true;
                        txtRegistroConfirmar.Visible = true;
                        cboxnivel.SelectedIndex = 0;
                        cboxnivel.Enabled = true;
                        txtRegistroContra.Focus();
                        btnguardar.Enabled = true;



                    }
                    else
                    {
                        resetearCampos();
                        TxtRegistroUsuario.Focus();
                    }
                }
                Conexion.Close();
            }
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            cboxnivel.Text = "Seleccione";
            cboxnivel.Items.Add("Administrador");
            cboxnivel.Items.Add("Operador");
            Acceso acceso = new Acceso();
            string actividad = "El usuario entro a auditorias.";
            acceso.Registrar_auditoria(actividad);
            RdbTodos.Focus();


        }

        private void TxtRegistroUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtRegistroUsuario.Focus();

            habilitarBusqueda();
            habilitarGuardar();
        }

        private void txtRegistroContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistroConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupCambio_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            labelCambioNueva.Visible = true;
            txtNuevaContra.Focus();

            txtNuevaContra.Visible = true;
            labelCambioConfirmar.Visible = true;
            txtNuevaConfirmar.Visible = true;
            cambiarContra = true;
        }

        private void txtRegistroContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (estadoActual == MOSTRANDO_USUARIO)
            {
                if (e.KeyChar == 13 && txtRegistroContra.Text != "")
                {
                    if (acceso.Encriptar(txtRegistroContra.Text) == usuario.Us_password)
                    {
                        // Contraseña correcta, se habilita cbox y btncambiar
                        cboxnivel.Enabled = true;
                        btnCambio.Enabled = true;
                        txtRegistroContra.Enabled = false;
                        btnGuardarCambio.Visible = true;
                        btnGuardarCambio.Enabled = true;
                        btnBorrar.Enabled = true;
                        this.AcceptButton = null;
                    }
                    else
                    {
                        // Contraseña incorrecta
                        MessageBox.Show("Contraseña incorrecta", "Error");
                        intentos++;
                        if (intentos >= 3)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void TxtRegistroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtRegistroUsuario_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnbuscar;
        }

        private void txtRegistroContra_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtNuevaContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            // Si se va a cambiar la contraseña
            if (cambiarContra)
            {
                // Si las contraseñas no coinciden , mostrar error
                if (!verificarCambioContra())
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error");
                    this.resetearCampos();
                    TxtRegistroUsuario.Text = "";
                    TxtRegistroUsuario.Focus();
                    return;
                }
                usuario.Us_password = acceso.Encriptar(txtNuevaContra.Text);
            }
            if (actualizarUsuario())
            {
                Acceso acceso = new Acceso();
                string actividad = "El usuario modifico al usuario " + TxtRegistroUsuario.Text + ".";
                acceso.Registrar_auditoria(actividad);
                MessageBox.Show("Usuario modificado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.resetearCampos();
                TxtRegistroUsuario.Text = "";
                TxtRegistroUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al modificar el usuario, inténte de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoActual = BUSCANDO;
        }

        private void cboxnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            establecerNivel();
        }

        private void FrmAuditoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario salió de auditoria.";
            acceso.Registrar_auditoria(actividad);
        }

        private void TxtRegistroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtRegistroContra.Enabled = true;
                txtRegistroContra.Focus();
            }
        }

        private void txtRegistroContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtRegistroConfirmar.Enabled = true;
                txtRegistroConfirmar.Focus();
            }
        }

        private void txtRegistroConfirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtRegistroConfirmar.Text == txtRegistroContra.Text)
                {
                    cboxnivel.Enabled = true;
                    cboxnivel.Focus();

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error");
                    txtRegistroContra.Focus();
                }


            }

        }

        private void cboxnivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtRegistroConfirmar.Text == txtRegistroContra.Text)
                {
                    btnguardar.Enabled = true;
                    btnguardar.Focus();

                }
            }
        }

        private void txtNuevaContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                txtNuevaConfirmar.Enabled = true;
                txtNuevaConfirmar.Focus();


            }
        }
        private void txtNuevaConfirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                btnGuardarCambio.Enabled = true;
                btnGuardarCambio.Focus();


            }
        }
       //aqui empieza todo lo de deapuracion
        private void llenarcbox()//este me llena el CboxUsuario
        {
            CboxUsuario.Items.Clear();
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
           // SqlCommand comando = new SqlCommand("select Au_Clave from Auditoriaa", Conexion);
            SqlCommand comando = new SqlCommand("select Us_login from Usuario", Conexion);
            
            //defino mi adapter
            SqlDataReader leer = comando.ExecuteReader();
            while(leer.Read())
            {
                CboxUsuario.Items.Add(leer["Us_login"].ToString());

            }
            CboxUsuario.SelectedIndex = 0;
            Conexion.Close();

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            RdbTodos.Focus();
        }

        private void RdbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUsuario.Checked)
            {
               
                CboxUsuario.Enabled = true;
                llenarcbox();

            }
            else
            {
                CboxUsuario.Enabled = false;

            }
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTodos.Checked)
            {
               btnAgregar.Enabled = true;
            }
           

        }
        public void consulartodo(DataGridView dgServicios)//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from Auditoriaa where Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechaHasta.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgServicios.DataSource = dt;
            if (!(dt.Rows.Count > 0))
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEliminar.Enabled = false;

            }
            else
            {
                btnEliminar.Enabled = true;

            }

        }
        public void consularporUsuario(DataGridView dgServicios)//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from Auditoriaa where Au_Clave=@usuario and Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@usuario", CboxUsuario.SelectedItem.ToString());
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechaHasta.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgServicios.DataSource = dt;
            if (!(dt.Rows.Count > 0))
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;

            }
            else
            {
                btnEliminar.Enabled = true;

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(RdbTodos.Checked)
            {
                consulartodo(dgServicios);

            }
            else
            {
                consularporUsuario(dgServicios);
            }
        }



        private void FechasDesde_ValueChanged(object sender, EventArgs e)
        {
            FechaHasta.MinDate = FechasDesde.Value;
        }

        private void FechaHasta_ValueChanged(object sender, EventArgs e)
        {
            FechasDesde.MaxDate = FechaHasta.Value;
        }
        private bool eliminartodos()
        {
            try
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                SqlCommand cm = new SqlCommand("delete from Auditoriaa where Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@FechaDesde", FechasDesde.Value.Date.Add(new TimeSpan(0, 0, 0)));
                cm.Parameters.AddWithValue("@FechaHasta", FechaHasta.Value.Date.Add(new TimeSpan(23, 59, 59)));
                cm.ExecuteNonQuery();
                return true;
                
               
            }
            catch (SqlException excep)
            {
                return false;
            }
        }
        private bool eliminarPorUsuario()
        {
            try
            {
                objconexion = new Clases.Conexión();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                SqlCommand cm = new SqlCommand("delete from Auditoriaa where Au_Clave=@usuario and Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@usuario", CboxUsuario.SelectedItem.ToString());
                cm.Parameters.AddWithValue("@FechaDesde", FechasDesde.Value.Date.Add(new TimeSpan(0, 0, 0)));
                cm.Parameters.AddWithValue("@FechaHasta", FechaHasta.Value.Date.Add(new TimeSpan(23, 59, 59)));
                cm.ExecuteNonQuery();
                return true;
            }
            catch (SqlException excep)
            {
                return false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (RdbTodos.Checked)
            {
                if (MessageBox.Show("El Registro sera eliminado,está seguro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)

                {
                    if (eliminartodos())
                    {
                        dgServicios.DataSource = null;
                        btnEliminar.Enabled = false;
                        MessageBox.Show("Registros eliminados correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("Error", "No se pudieron eliminar los registros.");
                    }
                }
                 
            }
            else
            {
                if (MessageBox.Show("El Registro sera eliminado,está seguro?", "Eliminar", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    if (eliminarPorUsuario())
                    {
                        dgServicios.DataSource = null;
                        btnEliminar.Enabled = false;
                        MessageBox.Show("Registros eliminados correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("Error", "No se pudieron eliminar los registros.");
                    }
                }
                   
            }
        }
       //el de informes
        private void llenarcbox2()//este me llena el CboxUsuario
        {
            cboxUSUARIOS.Items.Clear();
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            // SqlCommand comando = new SqlCommand("select Au_Clave from Auditoriaa", Conexion);
            SqlCommand comando = new SqlCommand("select Us_login from Usuario", Conexion);

            //defino mi adapter
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cboxUSUARIOS.Items.Add(leer["Us_login"].ToString());

            }
            cboxUSUARIOS.SelectedIndex = 0;
            Conexion.Close();

        }
        private void RdbTodoInforme_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTodoInforme.Checked)
            {
                btnImprimir.Enabled = true;
            }

        }

        private void RdbUsuarioInforme_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUsuarioInforme.Checked)
            {

                cboxUSUARIOS.Enabled = true;
                llenarcbox2();

            }
            else
            {
                cboxUSUARIOS.Enabled = true;

            }
        }

        private void FechasDesde2_ValueChanged(object sender, EventArgs e)
        {
            FechasHasta2.MinDate = FechasDesde2.Value;

        }

        private void FechasHasta2_ValueChanged(object sender, EventArgs e)
        {
            FechasDesde2.MaxDate = FechasHasta2.Value;

        }
        public void reportetodo()//aqui es lo del reporte,no tengo idea de como hacerlo, AddWithValue es para remplazar un valor enviado
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from Auditoriaa where Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde2.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechasHasta2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "Auditoriaa");
            Informes.FrtTodos grupos = new Informes.FrtTodos();
            grupos.SetDataSource(ds.Tables[0]);
            if(RdbPntalla.Checked)
            {
                Forms.FrmReportes reporte = new FrmReportes();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
            }
            else
            {
                imprimir(grupos);
            }
            
        }
        public void reporteporUsuario()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from Auditoriaa where Au_Clave=@usuario and Au_Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@usuario", cboxUSUARIOS.SelectedItem.ToString());
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde2.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechasHasta2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();//este es para decir al reporte que datos va a buscar
            dscmd.Fill(ds, "Auditoriaa");
            Informes.FrtTodos grupos = new Informes.FrtTodos();
            grupos.SetDataSource(ds.Tables[0]);
            if (RdbPntalla.Checked)
            {
                Forms.FrmReportes reporte = new FrmReportes();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
            }
            else
            {
                imprimir(grupos);
            }
            
        }
        public void imprimir(ReportClass reporte )//recibe un objeto repor,abre el dilogo impresora y si da si va a sacar las opciones,llama al metodo impri repor de donde a donde
        {
            PrintDialog dialog1 = new PrintDialog();
            if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int copies = dialog1.PrinterSettings.Copies;
                int fromPage = dialog1.PrinterSettings.FromPage;
                int toPage = dialog1.PrinterSettings.ToPage;
                bool collate = dialog1.PrinterSettings.Collate;

                reporte.PrintOptions.PrinterName = dialog1.PrinterSettings.PrinterName;
                reporte.PrintToPrinter(copies, collate, fromPage, toPage);
            }
            reporte.Dispose();
            dialog1.Dispose();
        }
       

         private void btnImprimir_Click(object sender, EventArgs e)
         {
            if (RdbTodoInforme.Checked)
            {
                reportetodo();

            }
            else
            {
                reporteporUsuario();

            }
         }

        private void dgServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxUSUARIOS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    


