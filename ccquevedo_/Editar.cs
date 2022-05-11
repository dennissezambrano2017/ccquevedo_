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
    public partial class Editar : Form
    {
        public int? id;
        public int idCat;

        public Editar(int? id=null)
        {
            
            InitializeComponent();
            this.id = id;

            try
            {
                DataTable tablaUno = this.productosTableAdapter.BuscarDatos(id.ToString());
                //DataTable dataTable = this.categoriasTableAdapter.BuscarCategoria(Convert.ToInt32(tablaUno.Rows[0][9].ToString()));
                txtCodigo.Text = id.ToString();
                txtNombre.Text = tablaUno.Rows[0][1].ToString();
                txtDescripcion.Text = tablaUno.Rows[0][2].ToString();
                txtInventario.Text = tablaUno.Rows[0][3].ToString();
                txtImage.Text = tablaUno.Rows[0][4].ToString();
                txtminStock.Text = tablaUno.Rows[0][6].ToString();
                txtDescripcionL.Text = tablaUno.Rows[0][5].ToString();
                mcFechaFins.Text = tablaUno.Rows[0][12].ToString();
                mcFechaInicios.Text = tablaUno.Rows[0][11].ToString();
                //cmbCategoria.Text= dataTable.Rows[0][1].ToString();
                //idCat = Convert.ToInt32(tablaUno.Rows[0][9].ToString());
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
                dgvSubCatergoria.Rows.Add(cmbSubCategorias.SelectedItem.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }
    }
}
