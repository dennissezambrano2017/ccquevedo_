 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class Nuevo : Form
    {
        private static Nuevo instancia = null;
        private int itemSelct;

        public int ItemSelct { get => itemSelct; set => itemSelct = value; }

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
            ItemSelct = int.Parse(cmbCategoria.SelectedValue.ToString());
            CrearExcel ce = Owner as CrearExcel;
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcionCorta.Text != "" &&
                txtDescripcionCompleta.Text != "" && txtPrecioNormal.Text != "" && txtPrecioOferta.Text != "" &&
                txtStock.Text != "" && itemSelct != 0 && txtTipoProducto.Text != "")
            {
                ce.DtProductos.Rows.Add(txtCodigo.Text, txtNombre.Text, txtDescripcionCorta.Text, txtDescripcionCompleta.Text, Convert.ToDouble(txtPrecioNormal.Text), Convert.ToDouble(txtPrecioOferta.Text),
                   Convert.ToInt32(txtStock.Text), txtImagen.Text, cmbCategoria.GetItemText(cmbCategoria.SelectedItem), txtTipoProducto.Text);
                this.Close();
            }
            else
                MessageBox.Show("Falta datos a ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
            DataTable tablaDos = this.categoriasTableAdapter.GetData();
            cmbCategoria.DisplayMember = "des";
            cmbCategoria.ValueMember = "idcat";

            List<Product> lista = new List<Product>();
            for (int i = 0; i < tablaDos.Rows.Count; i++)
            {
                lista.Add(new Product(Convert.ToInt32(tablaDos.Rows[i][0].ToString()), tablaDos.Rows[i][1].ToString()));
            }
            cmbCategoria.DataSource = lista;
            cmbCategoria.SelectedIndex = 0;
        }
    }
}
