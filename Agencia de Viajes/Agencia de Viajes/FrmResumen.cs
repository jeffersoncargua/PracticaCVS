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
    public partial class FrmResumen : Form
    {
        linq baseDatos = new linq();
        public FrmResumen()
        {
            InitializeComponent();
        }


        public void cargarVuelos()
        {
            var listaVuelos = from vuelo in this.baseDatos.tblVuelo
                              select vuelo;
            foreach (var iter in listaVuelos)
            {
                lbxVendidos.Items.Add(iter);
            }
        }
        private void FrmResumen_Load(object sender, EventArgs e)
        {
            cargarVuelos();
        }
    }
}
