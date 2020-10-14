using MASTER_TUNE_UP.Clases;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
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

        public FrmAuditoria()
        {
            InitializeComponent();
            acceso = new Acceso();
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
                string query = "update Usuario set us_password=@Us_password, Us_nivel=@Us_nivel";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_login
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
                    this.usuario = new Usuario(leer["Us_nivel"].ToString(), leer["us_password"].ToString(), Convert.ToInt32(leer["Us_nivel"].ToString()));
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
            string actividad = "El usuario " + acceso.Usuario + " entro a auditorias.";
            acceso.Registrar_auditoria(actividad);
        }

        private void TxtRegistroUsuario_TextChanged(object sender, EventArgs e)
        {
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
                string actividad = "El usuario " + acceso.Usuario + " modifico al usuario " + TxtRegistroUsuario.Text + ".";
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
            string actividad = "El usuario " + acceso.Usuario + " salió de auditoria.";
            acceso.Registrar_auditoria(actividad);
        }
    }
}

