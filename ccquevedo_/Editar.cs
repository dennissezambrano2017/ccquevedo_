﻿using System;
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
    public partial class Editar : Form
    {
        public string id;
        public int idCat;

        public Editar(string id=null)
        {
            
            InitializeComponent();
            this.id = id;

            try
            {
                DataTable tablaUno = this.productosTableAdapter.BuscarDatos(id.ToString());
                var idcate = this.cat_SubTableAdapter.IdCat(id.ToString());
                var desc = this.categoriasTableAdapter.descripcion(idcate.ToString());
                txtCodigo.Text = id.ToString();
                txtNombre.Text = tablaUno.Rows[0][1].ToString();
                txtDescripcion.Text = tablaUno.Rows[0][2].ToString();
                txtInventario.Text = tablaUno.Rows[0][3].ToString();
                txtImage.Text = tablaUno.Rows[0][4].ToString();
                txtminStock.Text = tablaUno.Rows[0][6].ToString();
                txtDescripcionL.Text = tablaUno.Rows[0][5].ToString();
                mcFechaFins.Text = tablaUno.Rows[0][12].ToString();
                mcFechaInicios.Text = tablaUno.Rows[0][11].ToString();
                cmbCategoria.Text= desc.ToString();
                idCat = Convert.ToInt32(idcate);
                txtPrecio.Text = tablaUno.Rows[0][7].ToString();
                txtprecioRebajado.Text = tablaUno.Rows[0][8].ToString();
                txtTipoProducto.Text = tablaUno.Rows[0][10].ToString();
                txtEtiqueta.Text= tablaUno.Rows[0][13].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            

        }



        private void Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Cat_Sub' Puede moverla o quitarla según sea necesario.
            this.cat_SubTableAdapter.Fill(this.bdCamaraComercioDataSet.Cat_Sub);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.SubCategoria' Puede moverla o quitarla según sea necesario.
            this.subCategoriaTableAdapter.Fill(this.bdCamaraComercioDataSet.SubCategoria);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
                this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

                cmbCategoria.SelectedValue = idCat;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //idCat = int.Parse(cmbCategoria.SelectedValue.ToString());
            try{
                this.productosTableAdapter.Editar(txtNombre.Text, txtDescripcion.Text,
                                txtDescripcionL.Text,txtInventario.Text, txtminStock.Text,
                                txtPrecio.Text,
                                txtprecioRebajado.Text,"",
                                txtTipoProducto.Text,
                                mcFechaInicio.Text,
                                mcFechaFin.Text,txtEtiqueta.Text, id.ToString());
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcFechaInicios_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaIncio = Convert.ToDateTime(mcFechaInicios.Text);

            mcFechaInicios.Text = fechaIncio.ToString("yyyy-MM-dd");
        }

        private void mcFechaFins_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechafin = Convert.ToDateTime(mcFechaFins.Text);

            mcFechaFin.Text = fechafin.ToString("yyyy-MM-dd");
        }

        private void mcFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mcFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbSubCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSubCatergoria.Rows.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue.ToString() != null)
                llenarCombo(cmbCategoria.SelectedValue.ToString());
        }
        private void llenarCombo(string idcate)
        {
            DataTable tabla = this.subCategoriaTableAdapter.BuscarSub(idcate);
            cmbSubCategorias.DisplayMember = "des";
            cmbSubCategorias.ValueMember = "idcat";

            List<Product> lista = new List<Product>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
            }
            cmbSubCategorias.DataSource = lista;
            dgvSubCatergoria.Rows.Clear();
        }
    }
}
