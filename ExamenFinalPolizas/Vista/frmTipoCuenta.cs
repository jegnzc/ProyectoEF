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

namespace ExamenFinalPolizas
{
    public partial class frmTipoCuenta : Form
    {
        CuentaTipoDAO query = new CuentaTipoDAO();
        CuentaTipoDTO modelo = new CuentaTipoDTO();

        public frmTipoCuenta()
        {
            InitializeComponent();
        }

        private void frmTipoCuenta_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAgregarTipoDeCuenta_Click(object sender, EventArgs e)
        {
            modelo.nombre = txtTipoDeCuenta.Text;
            query.agregarTipoDeCuenta(modelo);
            actualizar();
        }

        private void actualizar()
        {
            var lista = query.obtenerTiposDeCuenta();
            var list = new BindingList<CuentaTipoDTO>(lista);
            dgvTipoDeCuentas.DataSource = list;
        }
    }
}
