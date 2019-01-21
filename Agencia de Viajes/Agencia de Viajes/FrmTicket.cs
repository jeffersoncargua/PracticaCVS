using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Agencia_de_Viajes
{
    public partial class FrmTicket : Form
    {
        linq baseDatos = new linq();
        Pasajero nuevoPasajero = new Pasajero();
        Agencia nuevoAgencia = new Agencia();
        Pais nuevoPais = new Pais();

        public FrmTicket()
        {
            InitializeComponent();
        }

        public void CargarPasajeros()
        {
            var listaPasajeros = from pasa in this.baseDatos.tblPasajero
                                 select pasa;
            foreach (var iter in listaPasajeros)
            {
                lbxPasajeros.Items.Add(iter);
            }
        }

        public void cargarAgencia()
        {
            var listaAgencia = from agen in this.baseDatos.tblAgecia
                               select agen;
            foreach (var iter in listaAgencia)
            {
                cboAgencia.Items.Add(iter);
            }
        }

        public void cargarPais()
        {
            var listaPais = from pais in this.baseDatos.tblPais
                            select pais;
            foreach (var iter in listaPais)
            {
                cboPais.Items.Add(iter);
            }
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            CargarPasajeros();
            cargarAgencia();
            cargarPais();
        }

        private void cboAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevoAgencia = (Agencia)cboAgencia.SelectedItem;
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevoPais = (Pais)cboPais.SelectedItem;
            txtTotal.Text = "500.75";
        }

        private void lbxPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevoPasajero = (Pasajero)lbxPasajeros.SelectedItem;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vuelo nuevo = new Vuelo();
            if (Convert.ToInt32(txtMaletas.Text)<=2)
            {
                nuevo.IdAgencia = nuevoAgencia.IdAgencia;
                nuevo.IdPasajero = nuevoPasajero.IdPasajero;
                nuevo.IdPais = nuevoPais.IdPais;
                nuevo.NumMaletas = Convert.ToInt32(txtMaletas.Text);
                nuevo.Total = Convert.ToDouble(txtTotal.Text);
                baseDatos.tblVuelo.InsertOnSubmit(nuevo);
                baseDatos.SubmitChanges();
                MessageBox.Show("Ticket Vendido");
                this.Close();
            }
            else
            {
                MessageBox.Show("Exceso de Maletas");
            }
        }
    }
}
