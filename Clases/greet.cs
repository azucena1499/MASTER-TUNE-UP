using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MASTER_TUNE_UP.Clases;


namespace MASTER_TUNE_UP.Clases
{
    class greet
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        public void CargarUnDatagrid(DataGridView dgServicios)
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre la conexion
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select*from Auditoriaa", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgServicios.DataSource = dt;
        }
        
    }
}
