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
        private CrearExcel formCrear = new CrearExcel();
        public List<Product> listPro = new List<Product>();
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
            Product listProduct = new Product();
            listProduct.id =Convert.ToInt32(txtCodigo.Text);
            listProduct.nombre = txtNombre.Text;
            listProduct.descripcionCorta = txtDescripcionCorta.Text;
            listProduct.descripcionLarga = txtDescripcionCompleta.Text;
            listProduct.precioNormal = Convert.ToDouble(txtPrecioNormal.Text);
            listProduct.precioOferta = Convert.ToDouble(txtPrecioOferta.Text);
            listProduct.stock = Convert.ToInt32(txtStock.Text);
            listProduct.categorias = cmbCategoria.Text;
            listProduct.tipoProducto = txtTipoProducto.Text;

            
            listPro.Add(listProduct);
            this.Close();
        }
    }
}
