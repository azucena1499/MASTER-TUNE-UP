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
using MASTER_TUNE_UP.Informes;
using MASTER_TUNE_UP.Clases;
using CrystalDecisions.CrystalReports.Engine;

namespace MASTER_TUNE_UP.Forms
{
    public partial class Servicios_informes : Form
    {
        Clases.Conexión objconexion;
        SqlConnection Conexion;
        private Acceso acceso;
        private int intentos = 0;
        bool existe = false;

        public Servicios_informes()
        {
            InitializeComponent();
        }

        private void llenarcbox3()//este me llena el CboxUsuario
        {
            cboxUSUARIOS.Items.Clear();
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            // SqlCommand comando = new SqlCommand("select Au_Clave from Auditoriaa", Conexion);
            SqlCommand comando = new SqlCommand("select Cl_nom from Clientes", Conexion);

            //defino mi adapter
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cboxUSUARIOS.Items.Add(leer["Cl_nom"].ToString());

            }
            cboxUSUARIOS.SelectedIndex = 0;
            Conexion.Close();

        }


        private void llenarcboxservicios()//este me llena el CboxUsuario
        {

            DataTable dt = new DataTable();
            //establezco conex
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            //establezco mi query
            string query = "SELECT * from Servicios where se_clave >=1 order by se_nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxservicio.DataSource = dt;
            this.cboxservicio.ValueMember = "se_clave";
            this.cboxservicio.DisplayMember = "se_nombre";
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
                llenarcbox3();

            }
            
            else
            {
                cboxUSUARIOS.Enabled = false;
                
            }
        }
        public void imprimir(ReportClass reporte)//recibe un objeto repor,abre el dilogo impresora y si da si va a sacar las opciones,llama al metodo impri repor de donde a donde
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
        public void reporteporUsuario()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from servicioCompletos where Cliente=@usuario", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@usuario", cboxUSUARIOS.SelectedItem.ToString());
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();//este es para decir al reporte que datos va a buscar
            dscmd.Fill(ds, "servicioCompletos");
            Informes.rptServicioUS grupos = new Informes.rptServicioUS();
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
        public void reportetodo()//AddWithValue es para remplazar un valor enviado
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from servicioCompletos where trabajoF BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde2.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechasHasta2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "servicioCompletos");
            Informes.rptServicioUS grupos = new Informes.rptServicioUS();
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
        public void reporteporServicio()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from servicioCompletos where Servicio=@Servicios", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@Servicios", cboxservicio.SelectedItem.ToString());
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();//este es para decir al reporte que datos va a buscar
            dscmd.Fill(ds, "servicioCompletos");
            Informes.rptServicioUS grupos = new Informes.rptServicioUS();
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
            //if (rdbservicios.Checked)
            //{
            //    reporteporServicio();
            //}

        }

        private void FechasDesde2_ValueChanged(object sender, EventArgs e)
        {
            FechasHasta2.MinDate = FechasDesde2.Value;
        }

        private void FechasHasta2_ValueChanged(object sender, EventArgs e)
        {
            FechasDesde2.MaxDate = FechasHasta2.Value;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboxservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbarticulo_CheckedChanged(object sender, EventArgs e)
        {
            cboxservicio.Enabled = true;
            llenarcboxservicios();
        }
    }
}
