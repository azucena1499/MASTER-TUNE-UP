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
            acceso.Registrar_auditoria(2, this.usuario);
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
            Forms.frmservicios x = new Forms.frmservicios();
            x.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmdatosg x = new Forms.frmdatosg();
            x.Show();
        }
    }
}
