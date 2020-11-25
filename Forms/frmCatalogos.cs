using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace MASTER_TUNE_UP.Forms
{
    public partial class frmCatalogos : Form
    {
        public frmCatalogos()
        {
            InitializeComponent();
        }

        public void imprimir(ReportClass reporte)
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

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (rdbclientes.Checked)
            {

                if (rdbnombre.Checked)
                {
                    Informes.FrtClienteNom cliente = new Informes.FrtClienteNom();

                    if (rdbpantalla.Checked)
                    {
                        Forms.FrmReportes reporte = new FrmReportes();
                        reporte.crystalReportViewer1.ReportSource = cliente;
                        reporte.ShowDialog();
                    }
                    else
                    {
                        imprimir(cliente);

                    }
                }
                if (rdbclave.Checked)
                {
                    Informes.rptClienteId cliente1 = new Informes.rptClienteId();

                    if (rdbpantalla.Checked)
                    {
                        Forms.FrmReportes reporte = new FrmReportes();
                        reporte.crystalReportViewer1.ReportSource = cliente1;
                        reporte.ShowDialog();
                    }
                    else
                    {
                        imprimir(cliente1);

                    }
                }
                    if (rdbActivos.Checked)
                    {
                        Informes.rptActivos activos = new Informes.rptActivos();

                        if (rdbpantalla.Checked)
                        {
                            Forms.FrmReportes reporte = new FrmReportes();
                            reporte.crystalReportViewer1.ReportSource = activos;
                            reporte.ShowDialog();
                        }
                        else
                        {
                            imprimir(activos);

                        }
                    }
                }
            }
            

        private void rdbclientes_CheckedChanged(object sender, EventArgs e)
        {
            gpbordenada.Visible = true;

        }
    }
}
               
   

        