using ExamenFinalPolizas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalPolizas.Vista
{
    public partial class frmPoliza : Form
    {
        PolizaDetalleDTO modelo = new PolizaDetalleDTO();
        PolizaDAO query = new PolizaDAO();
        public frmPoliza()
        {
            InitializeComponent();
            CuentaTipoDAO campeonato = new CuentaTipoDAO();
            cboCuenta.DataSource = campeonato.obtenerTiposDeCuenta();
            cboCuenta.DisplayMember = "nombre";
            cboCuenta.ValueMember = "cuentaTipoId";
            cboCuenta.SelectedItem = cboCuenta.Items[0];

            OperacionTipoDAO operaciones = new OperacionTipoDAO();
            cboCuenta.DataSource = operaciones.obtenerTiposDeOperaciones();
            cboCuenta.DisplayMember = "nombre";
            cboCuenta.ValueMember = "operationTipoId";
            cboCuenta.SelectedItem = cboCuenta.Items[0];
        }

        private void frmPoliza_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            var lista = query.obtenerTiposDeCuenta();
            var list = new BindingList<PolizaDetalleDTO>(lista);
            dgvPolizaDetalles.DataSource = list;
        }

        private void btnAgregarDetalleDePoliza_Click(object sender, EventArgs e)
        {
            query.agregarDetalleDePoliza(modelo);
            actualizar();
        }
    }
}
