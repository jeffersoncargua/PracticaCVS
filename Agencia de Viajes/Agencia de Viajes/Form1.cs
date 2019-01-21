using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void venderVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.MdiParent = this;
            frmTicket.Text = "venta de tickets" + this.MdiChildren.ToString();
            frmTicket.Show();
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResumen frmResumen = new FrmResumen();
            frmResumen.MdiParent = this;
            frmResumen.Text = " Resumen" + this.MdiChildren.ToString();
            frmResumen.Show();
        }
    }
}
