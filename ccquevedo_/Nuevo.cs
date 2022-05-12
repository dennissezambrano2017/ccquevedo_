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
        private string itemSelct;
        private List<Product> listSubCate = new List<Product>();

        public string ItemSelct { get => itemSelct; set => itemSelct = value; }
        public List<Product> ListSubCate { get => listSubCate; set => listSubCate = value; }

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
            try
            {
                string txtCategoria="";
                for (int i = 0; i < listSubCate.Count; i++)
                    txtCategoria += cmbCategoria.Text + " > " + listSubCate[i].des + ", ";
                if(listSubCate.Count == 0)
                {
                    txtCategoria = cmbCategoria.Text;
                }

                CrearExcel ce = Owner as CrearExcel;
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcionCorta.Text != ""
                    && txtPrecioNormal.Text != "" && itemSelct != "" && txtInventario.Text != "")
                {
                    ce.DtProductos.Rows.Add(txtCodigo.Text, txtTipoProducto.Text, txtNombre.Text,
                        txtDescripcionCorta.Text, txtDescripcionCompleta.Text, mcFechaInicio.Text,
                        mcFechaFin.Text, txtInventario.Text, txtStock.Text, txtPrecioOferta.Text,
                        txtPrecioNormal.Text, txtCategoria, txtEtiqueta.Text, txtImagen.Text);
                    this.Close();
                }
                else
                    MessageBox.Show("Falta datos a ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
            try
            {
                this.Validate();
                this.categoriasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            

        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.SubCategoria' Puede moverla o quitarla según sea necesario.
                this.subCategoriaTableAdapter.Fill(this.bdCamaraComercioDataSet.SubCategoria);
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
                this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);

                DataTable tabla = this.categoriasTableAdapter.GetData();
                cmbCategoria.DisplayMember = "des";
                cmbCategoria.ValueMember = "idcat";

                List<Product> lista = new List<Product>();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
                }
                cmbCategoria.DataSource = lista;


                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
                DataTable datos = this.productosTableAdapter.GetData();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    mycollection.Add(datos.Rows[i][1].ToString());
                }
                txtNombre.AutoCompleteCustomSource = mycollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    if (txtNombre.Text != "")
                    {
                        DataTable datos = this.productosTableAdapter.BuscaNombre(txtNombre.Text);
                        //DataTable dataTable = this.categoriasTableAdapter.BuscarCategoria(Convert.ToInt32(datos.Rows[0][9].ToString()));
                        if (datos.Rows.Count > 0)
                        {
                            txtCodigo.Text = datos.Rows[0][0].ToString();
                            txtDescripcionCorta.Text = datos.Rows[0][2].ToString();
                            txtDescripcionCompleta.Text = datos.Rows[0][3].ToString();
                            txtInventario.Text = datos.Rows[0][4].ToString();
                            txtStock.Text = datos.Rows[0][5].ToString();
                            txtPrecioNormal.Text = datos.Rows[0][6].ToString();
                            txtPrecioOferta.Text = datos.Rows[0][7].ToString();
                            txtImagen.Text = datos.Rows[0][8].ToString();
                            txtTipoProducto.Text = datos.Rows[0][9].ToString();
                            mcFechaInicio.Text = datos.Rows[0][10].ToString();
                            mcFechaFin.Text = datos.Rows[0][11].ToString();
                            txtEtiqueta.Text = datos.Rows[0][12].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encuentra");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

       

        private void mcFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaIncio = Convert.ToDateTime(mcFechaInicios.Text);

                mcFechaInicio.Text = fechaIncio.ToString("yyyy-MM-dd");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            
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

        private void mcFechaFins_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechafin = Convert.ToDateTime(mcFechaFins.Text);

                mcFechaFin.Text = fechafin.ToString("yyyy-MM-dd");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            ItemSelct = cmbCategoria.SelectedValue.ToString();
            if (cmbCategoria.SelectedValue.ToString()!=null)
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
            listSubCate = new List<Product>();
        }
        private void cmbSubCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listSubCate.Add(new Product(Convert.ToInt32(cmbSubCategorias.SelectedValue.ToString()), cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem)));
                dgvSubCatergoria.Rows.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
