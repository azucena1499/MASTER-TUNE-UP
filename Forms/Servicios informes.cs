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
           

            DataTable dt = new DataTable();
            //establezco conex
            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            //establezco mi query
            //string query = "SELECT * from Clientes where Cl_id >=1 order by Cl_nom";
            string query = "SELECT * from Clientes ";

            //defino comando
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            this.cboxUSUARIOS.DataSource = dt;
            this.cboxUSUARIOS.ValueMember = "Cl_id";
            this.cboxUSUARIOS.DisplayMember = "Cl_nom";
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
                cboxUSUARIOS.Enabled = true;
                
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
            //objconexion = new Clases.Conexión();
            //Conexion = new SqlConnection(objconexion.Conn());
            //Conexion.Open();
            //SqlCommand cm = new SqlCommand("select * from azucena where Cl_id=@usuario", Conexion);
            //cm.Parameters.Clear();
            //cm.Parameters.AddWithValue("@usuario", cboxUSUARIOS.SelectedValue.ToString());
            //SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            //DataSet ds = new DataSet();//este es para decir al reporte que datos va a buscar
            //dscmd.Fill(ds, "azucena");
            //Informes.rptServicioUS grupos = new Informes.rptServicioUS();
            //grupos.SetDataSource(ds.Tables[0]);
            //if (RdbPntalla.Checked)
            //{
            //    Forms.FrmReportes reporte = new FrmReportes();
            //    reporte.crystalReportViewer1.ReportSource = grupos;
            //    reporte.ShowDialog();
            //}
            //else
            //{
            //    imprimir(grupos);
            //}

            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from azucena where Cl_id=@usuario and Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@usuario", cboxUSUARIOS.SelectedValue.ToString());
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde2.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechasHasta2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "azucena");
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
            SqlCommand cm = new SqlCommand("select * from azucena where Fecha BETWEEN @FechaDesde AND @FechaHasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@FechaDesde", FechasDesde2.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@FechaHasta", FechasHasta2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "azucena");
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
        public void reporteporServicio()
        {
           // objconexion = new Clases.Conexión();
           // Conexion = new SqlConnection(objconexion.Conn());
           // Conexion.Open();
           //SqlCommand cm = new SqlCommand("select * from azucena where Id_servicio=@servicios", Conexion);
           //// SqlCommand cm = new SqlCommand("select * from servicioCompletos ", Conexion);

           // cm.Parameters.Clear();
           // cm.Parameters.AddWithValue("@servicios", cboxservicio.SelectedValue.ToString());
           // SqlDataAdapter dscmd = new SqlDataAdapter(cm);
           // DataSet ds = new DataSet();//este es para decir al reporte que datos va a buscar
           // dscmd.Fill(ds, "azucena");
           // Informes.rptServicioUS grupos = new Informes.rptServicioUS();
           // grupos.SetDataSource(ds.Tables[0]);
           // if (RdbPntalla.Checked)
           // {
           //     Forms.FrmReportes reporte = new FrmReportes();
           //     reporte.crystalReportViewer1.ReportSource = grupos;
           //     reporte.ShowDialog();
           // }
           // else
           // {
           //     imprimir(grupos);
           // }

            objconexion = new Clases.Conexión();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            SqlCommand cm = new SqlCommand("select * from azucena where Id_servicio=@servicios and Fecha BETWEEN @datedesde AND @datehasta", Conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@servicios", cboxservicio.SelectedValue.ToString());
            cm.Parameters.AddWithValue("@datedesde", datedesde.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@datehasta", datehasta.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter dscmd = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "azucena");
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
        

       private void FechasDesde2_ValueChanged(object sender, EventArgs e)
       {
          FechasHasta2.MinDate = FechasDesde2.Value;
       }

        private void FechasHasta2_ValueChanged(object sender, EventArgs e)
        {
            FechasDesde2.MaxDate = FechasHasta2.Value;

        } 

        private void datedesde_ValueChanged(object sender, EventArgs e)
        {
            datehasta.MinDate = datedesde.Value;

        }

        private void datehasta_ValueChanged(object sender, EventArgs e)
        {
            datedesde.MaxDate = datehasta.Value;

        }

        private void btnimprimir2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(cboxservicio.SelectedValue.ToString());

            if (rdbarticulo.Checked)
            {
                reporteporServicio();

            }

        }

        private void rdbarticulo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbservicios.Checked)
            {
                cboxservicio.Enabled = true;
                llenarcboxservicios();
            }
            else
            {
                cboxservicio.Enabled = true;

            }
        }

        private void RdbUsuarioInforme_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RdbUsuarioInforme.Checked)
            {

                cboxUSUARIOS.Enabled = true;
                llenarcbox3();

            }
            else
            {
                cboxUSUARIOS.Enabled = true;

            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            if(rdbarticulo.Checked)
            {
                if (rdbarticulo.Checked)
                {
                    reporteporServicio();

                }
            }
            else if (RdbTodoInforme.Checked)
            {
                reportetodo();

            }
           
            else
            {
                reporteporUsuario();
            }
            


        }

        private void rdbTodos2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
