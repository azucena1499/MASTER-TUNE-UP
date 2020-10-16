using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace MASTER_TUNE_UP.Clases
{
    class Acceso
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        private static String USUARIO = null;

        public bool Login(string usuario, string password)
        {

            string contraseña_bd = null;
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "Select * from Usuario where Us_login = @Us_login ";

            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.AddWithValue("@Us_login", usuario);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                //MessageBox.Show(leer["us_password"].ToString());
                contraseña_bd = leer["us_password"].ToString();
            Conexion.Close();
            string contraseña_encriptada = this.Encriptar(password);//comparando las
            bool correcto = contraseña_bd.Equals(contraseña_encriptada);
            USUARIO = correcto ? usuario : null;
            return correcto;
            

        }
        public string Encriptar(string contraseña)
        {
            int longitud = contraseña.Length;//se saca la longitud
            string cadena_Final = "";
            for (int n = 0; n < longitud; n++)//convertir uno por uno a codigo
            {
                int ascii = (int)contraseña[n];
                int resultado = (ascii + 7) * 7 - 7;
                string encriptado = resultado + "$7";
                cadena_Final += encriptado;

            }
            return cadena_Final;
        }
        public void Registrar_auditoria(string actividad)
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());//se va a recibir la actividad que se va a guardar
            Conexion.Open();
            string query = "Insert into Auditoriaa values( @Au_Clave, @Au_Fecha, @Au_Actividad )";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Au_Clave", (USUARIO));
            comando.Parameters.AddWithValue("@Au_Fecha", DateTime.Now);//guarda fecha
            comando.Parameters.AddWithValue("@Au_Actividad", actividad);//guarda actividad
            comando.ExecuteNonQuery();
            Conexion.Close();

        }
        public void Logout() => USUARIO = null;
        public string Usuario { get => USUARIO; }

    }
} 
