using MASTER_TUNE_UP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTER_TUNE_UP.Forms
{
    public partial class Frmmenu : Form
    {
        private string usuario;
        public Frmmenu(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmAuditoria x = new Forms.FrmAuditoria();
            x.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Acceso acceso = new Acceso();
            string actividad = "El usuario  salio al sistema.";
            acceso.Registrar_auditoria(actividad);
            this.Close();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmclientes x = new Forms.Frmclientes();
            x.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmtrabajos x = new Forms.frmtrabajos();
            x.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario  ingresó al Menu.";
            acceso.Registrar_auditoria(actividad);
            //maximizar pantalla
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //float lblUsuario = (float.Parse(acceso.Usuario));
            //lbluser.Text = lblUsuario.ToString();


        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Frmmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Acceso acceso = new Acceso();
            string actividad = "El usuario salió del Menu.";
            acceso.Registrar_auditoria(actividad);
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmdatosg x = new Forms.frmdatosg();
            x.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmservicios x = new Forms.Frmservicios();
            x.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmlocalidades x = new Forms.Frmlocalidades();
            x.Show();
        }

        public void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
