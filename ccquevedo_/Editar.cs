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
        private static Editar instancia = null;
        public string id;
        public int idCat;

        public static Editar FormCrear(string id)
        {
            if (instancia == null)
            {
                instancia = new Editar(id);
                return instancia;
            }
            return instancia;
        }
        public Editar(string id=null)
        {
            
            InitializeComponent();
            this.id = id;

            try
            {
                DataTable tablaUno = this.productosTableAdapter.BuscarIdProducto(id.ToString());
                //var idcate = tablaUno.Rows[0][13].ToString(); ;
                //var desc = this.categoriasTableAdapter.descripcion(idcate.ToString());
                 //MessageBox.Show(id+" - "+tablaUno.Rows.Count.ToString());

                txtCodigo.Text = id.ToString();
                txtNombre.Text = tablaUno.Rows[0][1].ToString();
                txtDescripcion.Text = tablaUno.Rows[0][2].ToString();
                txtDescripcionL.Text = tablaUno.Rows[0][3].ToString();
                txtInventario.Text = tablaUno.Rows[0][4].ToString();
                txtminStock.Text = tablaUno.Rows[0][5].ToString();
                txtPrecio.Text = tablaUno.Rows[0][6].ToString();
                txtprecioRebajado.Text = tablaUno.Rows[0][7].ToString();
                txtImage.Text = tablaUno.Rows[0][12].ToString();
                txtTipoProducto.Text = tablaUno.Rows[0][8].ToString();
                mcFechaInicio.Text = tablaUno.Rows[0][9].ToString();
                mcFechaFin.Text = tablaUno.Rows[0][10].ToString();
                txtEtiqueta.Text = tablaUno.Rows[0][11].ToString();
                idCat = int.Parse(tablaUno.Rows[0][13].ToString());
                cmbCategoria.Text = tablaUno.Rows[0][14].ToString();
                cambiarData();

                DataTable subcat = this.cat_SubTableAdapter.BuscarSubCat(id.ToString());
                for (int i = 0; i < subcat.Rows.Count; i++)
                {
                    dgvSubCatergoria.Rows.Add(subcat.Rows[i]["Descripcion"].ToString());
                }

                DataTable tabla = this.categoriasTableAdapter.GetData();
                cmbCategoria.DisplayMember = "des";
                cmbCategoria.ValueMember = "idcat";

                List<Product> lista = new List<Product>();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
                }
                cmbCategoria.DataSource = lista;
                cmbCategoria.SelectedValue = Convert.ToInt32(id);
                if (idCat == 29){ dgvSubCatergoria.Rows.Clear();}
                else
                {
                    cmbSubCategorias.Enabled = true;
                    llenarCombo();
                }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void llenarCombo()
        {
            try
            {
                DataTable tabla = this.subCategoriaTableAdapter.BuscarSub(idCat.ToString());
                cmbSubCategorias.DisplayMember = "des";
                cmbSubCategorias.ValueMember = "idcat";

                List<Product> lista = new List<Product>();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
                }
                cmbSubCategorias.DataSource = lista;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
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
            try
            {
                if (txtprecioRebajado.Text != "" && mcFechaInicio.Text == "" && mcFechaFin.Text == "")
                    MessageBox.Show("Falta ingresar las fechas de incio y fin de las ofertas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtprecioRebajado.Text == "" && mcFechaInicio.Text != "" && mcFechaFin.Text != "")
                    MessageBox.Show("Falta ingresar el precio de oferta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcionL.Text != "" && txtPrecio.Text != "" && idCat != 0 && txtInventario.Text != "")
                    {
                        comprobarData();
                        if (int.Parse(txtprecioRebajado.Text) < int.Parse(txtPrecio.Text))
                        {
                            if (int.Parse(txtminStock.Text) < int.Parse(txtInventario.Text))
                            {
                                this.productosTableAdapter.Editar(txtNombre.Text, txtDescripcion.Text,
                                txtDescripcionL.Text, txtInventario.Text, txtminStock.Text,
                                txtPrecio.Text,
                                txtprecioRebajado.Text, txtImage.Text,
                                txtTipoProducto.Text,
                                mcFechaInicio.Text,
                                mcFechaFin.Text, txtEtiqueta.Text, id.ToString());
                                this.cat_SubTableAdapter.Eliminar(id.ToString());
                                if (dgvSubCatergoria.Rows.Count < 1)
                                {
                                    this.cat_SubTableAdapter.Insertar(idCat.ToString(), "341", id.ToString());
                                }
                                for (int j = 0; j < dgvSubCatergoria.Rows.Count; j++)
                                {
                                    string idsubcat = this.subCategoriaTableAdapter.BuscarSubId(dgvSubCatergoria.Rows[j].Cells[0].Value.ToString(), idCat.ToString());
                                    this.cat_SubTableAdapter.Insertar(idCat.ToString(), idsubcat, id.ToString());
                                }
                                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                                this.Close();
                            }
                            else
                                MessageBox.Show("El valor del minimo stock no debe ser mayor que el inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("El precio de oferta no debe ser mayor que el precio normal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Falta datos a ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comprobarData()
        {
            if (txtprecioRebajado.Text == "")
                txtprecioRebajado.Text = "0";
            else if (txtPrecio.Text == "")
                txtPrecio.Text = "0";
            else if (txtminStock.Text == "")
                txtminStock.Text = "0";
            else if (txtInventario.Text == "")
                txtInventario.Text = "0";
        }

        private void cambiarData()
        {
            if (txtprecioRebajado.Text == "0")
                txtprecioRebajado.Text = "";
            else if (txtPrecio.Text == "0")
                txtPrecio.Text = "";
            else if (txtminStock.Text == "0")
                txtminStock.Text = "";
            else if (txtInventario.Text == "0")
                txtInventario.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcFechaInicios_ValueChanged(object sender, EventArgs e)
        {
            
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

        private void llenarCombo(string idcate)
        {
            try
            {
                cmbSubCategorias.DataSource = null;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedValue.ToString() == "29")
                    cmbSubCategorias.Enabled = false;
                else
                {
                    cmbSubCategorias.Enabled = true;
                }
                idCat = int.Parse(cmbCategoria.SelectedValue.ToString());
                llenarCombo(cmbCategoria.SelectedValue.ToString());
                dgvSubCatergoria.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbSubCategorias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool existeDuplicado = false;
            try
            {
                for (int i = 0; i < dgvSubCatergoria.Rows.Count; i++)
                {
                    if (dgvSubCatergoria.Rows[i].Cells[0].Value.ToString() == cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem))
                        existeDuplicado = true;
                }
                if (existeDuplicado != true)
                {
                    dgvSubCatergoria.Rows.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mcFechaInicios_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime fechaIncio = Convert.ToDateTime(mcFechaInicios.Text);

            mcFechaInicio.Text = fechaIncio.ToString("yyyy-MM-dd");
        }

        private void dgvSubCatergoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSubCatergoria.Rows.Remove(dgvSubCatergoria.CurrentRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloudingImag cloudingImag = CloudingImag.FormCrear("3",txtImage.Text);
            AddOwnedForm(cloudingImag);
            cloudingImag.ShowDialog();
            
        }
    }
}
