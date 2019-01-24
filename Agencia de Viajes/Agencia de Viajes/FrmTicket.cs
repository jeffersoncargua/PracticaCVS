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
        //linq baseDatos = new linq();
        Pasajero nuevoPasajero = new Pasajero();
        Agencia nuevoAgencia = new Agencia();
        Pais nuevoPais = new Pais();

        public FrmTicket()
        {
            InitializeComponent();
        }

        public void CargarPasajeros()
        {
            nuevoPasajero.IdPasajero = 1; nuevoPasajero.NombrePasajero = "Jefferson";nuevoPasajero.ApellidoPasajero = "Cargua";
            lbxPasajeros.Items.Add(nuevoPasajero);
            nuevoPasajero.IdPasajero = 2; nuevoPasajero.NombrePasajero = "Marlon"; nuevoPasajero.ApellidoPasajero = "Apolo";
            lbxPasajeros.Items.Add(nuevoPasajero);
            nuevoPasajero.IdPasajero = 3; nuevoPasajero.NombrePasajero = "Kevin"; nuevoPasajero.ApellidoPasajero = "Jaramillo";
            lbxPasajeros.Items.Add(nuevoPasajero);

            /*var listaPasajeros = from pasa in this.baseDatos.tblPasajero
                                 select pasa;
            foreach (var iter in listaPasajeros)
            {
                lbxPasajeros.Items.Add(iter);
            }*/
        }

        public void cargarAgencia()
        {
            nuevoAgencia.IdAgencia = 1;nuevoAgencia.NombreAgencia = "TAME";
            cboAgencia.Items.Add(nuevoAgencia);
            nuevoAgencia.IdAgencia = 2; nuevoAgencia.NombreAgencia = "IBERIA";
            cboAgencia.Items.Add(nuevoAgencia);
            nuevoAgencia.IdAgencia = 3; nuevoAgencia.NombreAgencia = "TAME";
            cboAgencia.Items.Add(nuevoAgencia);
            /*var listaAgencia = from agen in this.baseDatos.tblAgecia
                               select agen;
            foreach (var iter in listaAgencia)
            {
                cboAgencia.Items.Add(iter);
            }*/
        }

        public void cargarPais()
        {
            nuevoPais.IdPais = 1;nuevoPais.NombrePais = "Ecuador";
            cboPais.Items.Add(nuevoPais);
            nuevoPais.IdPais = 2; nuevoPais.NombrePais = "Chile";
            cboPais.Items.Add(nuevoPais);
            nuevoPais.IdPais = 3; nuevoPais.NombrePais = "Argentina";
            cboPais.Items.Add(nuevoPais);
            /*var listaPais = from pais in this.baseDatos.tblPais
                            select pais;
            foreach (var iter in listaPais)
            {
                cboPais.Items.Add(iter);
            }*/
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            lbxPasajeros.Items.Clear();
            cboAgencia.Items.Clear();
            cboAgencia.Items.Clear();
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
                //baseDatos.tblVuelo.InsertOnSubmit(nuevo);
                //baseDatos.SubmitChanges();
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
