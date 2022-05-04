using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class Modificar : Form
    {
        private static Modificar instancia = null;
        public static Modificar FormCrear()
        {
            if (instancia == null)
            {
                instancia = new Modificar();
                return instancia;
            }
            return instancia;
        }
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = ""; 
            txtNombre.Text = "";
            txtDesCorta.Text = ""; 
            txtDescriComple.Text = "";
            txtPrecioNormal.Text = ""; 
            txtPrecioOferta.Text = "";
            txtStock.Text = "";
            txtImage.Text = "";
            cmbCategoria.Text = ""; 
            txtTipoProducto.Text = "";
            this.Close();
        }

        private void Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnGuadar_Click(object sender, EventArgs e)
        {
            CrearExcel ce = Owner as CrearExcel;
            ce.DtProductos[0, ce.Posicion].Value = txtCodigo.Text;
            ce.DtProductos[1, ce.Posicion].Value = txtNombre.Text;
            ce.DtProductos[2, ce.Posicion].Value = txtDesCorta.Text;
            ce.DtProductos[3, ce.Posicion].Value = txtDescriComple.Text;
            ce.DtProductos[4, ce.Posicion].Value = txtPrecioNormal.Text;
            ce.DtProductos[5, ce.Posicion].Value = txtPrecioOferta.Text;
            ce.DtProductos[6, ce.Posicion].Value = txtStock.Text;
            ce.DtProductos[7, ce.Posicion].Value = txtImage.Text;
            ce.DtProductos[8, ce.Posicion].Value = cmbCategoria.Text;
            ce.DtProductos[9, ce.Posicion].Value = txtTipoProducto.Text;
            this.Close();
            //MessageBox.Show(ce.Posicion.ToString());
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioNormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
