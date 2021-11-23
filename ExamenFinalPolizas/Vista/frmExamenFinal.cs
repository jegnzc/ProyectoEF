using CapaVistaSeguridadHSC;
using ExamenFinalPolizas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static datosUsuario;
namespace ExamenFinalPolizas
{
    public partial class frmExamenFinal : Form
    {
        public frmExamenFinal()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora form3 = new frmBitacora();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void ExamenFinal_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                string user = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void tipoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitacoraUsuario.Bitacora bit = new BitacoraUsuario.Bitacora();
            bit.guardarEnBitacora(IdUsuario, "2", "1000", "Entrar a Tipo de Cuentas");
            frmTipoCuenta form3 = new frmTipoCuenta();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }

        private void pólizasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitacoraUsuario.Bitacora bit = new BitacoraUsuario.Bitacora();
            bit.guardarEnBitacora(IdUsuario, "2", "1000", "Entrar a Pólizas");
            frmPoliza form3 = new frmPoliza();
            form3.MdiParent = this.MdiParent;
            form3.Show();
        }
    }
}
