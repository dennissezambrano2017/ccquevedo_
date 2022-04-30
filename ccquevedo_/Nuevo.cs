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
       private CrearExcel crearExcel = new CrearExcel();
        private List<Product> listPro = new List<Product>();
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
            Product listProduct = new Product(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtDescripcionCorta.Text,
                txtDescripcionCompleta.Text,Convert.ToInt32(txtStock.Text), Convert.ToDouble(txtPrecioNormal.Text), Convert.ToDouble(txtPrecioOferta.Text),
                 cmbCategoria.Text, txtTipoProducto.Text);

            listPro.Add(listProduct);
            this.Close();
        }
    }
}
