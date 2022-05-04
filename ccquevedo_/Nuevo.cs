 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class Nuevo : Form
    {
        private static Nuevo instancia = null;
        public static Nuevo FormCrear()
        {
            if (instancia == null)
            {
                instancia = new Nuevo();
                return instancia;
            }
            return instancia;
        }

        public Nuevo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnGuadar_Click(object sender, EventArgs e)
        {
            CrearExcel ce = Owner as CrearExcel;
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcionCorta.Text != "" &&
                txtDescripcionCompleta.Text != "" && txtPrecioNormal.Text != "" && txtPrecioOferta.Text != "" &&
                txtStock.Text != "" && cmbCategoria.Text != "" && txtTipoProducto.Text != "")
            {
                ce.DtProductos.Rows.Add(txtCodigo.Text, txtNombre.Text, txtDescripcionCorta.Text, txtDescripcionCompleta.Text, Convert.ToDouble(txtPrecioNormal.Text), Convert.ToDouble(txtPrecioOferta.Text),
                   Convert.ToInt32(txtStock.Text), txtImagen.Text, cmbCategoria.Text, txtTipoProducto.Text);
                this.Close();
            }
            else
                MessageBox.Show("Falta datos a ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
