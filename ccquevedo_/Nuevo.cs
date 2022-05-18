using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class Nuevo : Form
    {
        private static Nuevo instancia = null;
        private string itemSelct;
        private CrearExcel ce = new CrearExcel();
        private List<Product> listSubCate = new List<Product>();
        private List<string> listSubCategoria = new List<string>();
        private List<Product> lista = new List<Product>();

        public string ItemSelct { get => itemSelct; set => itemSelct = value; }
        public List<Product> ListSubCate { get => listSubCate; set => listSubCate = value; }

        public List<Product> Lista { get => lista; set => lista = value; }
        public List<string> ListSubCategoria { get => listSubCategoria; set => listSubCategoria = value; }

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
                ce = Owner as CrearExcel;
                bool existe = false;
                int Posicion = 0;
                for(int i=0; i < ce.dgvProducto.Rows.Count; i++)
                {
                    if (ce.dgvProducto.Rows[i].Cells[0].Value.ToString() == txtCodigo.Text)
                    { 
                        existe = true; 
                        Posicion = ce.dgvProducto.CurrentRow.Index;
                    }
                }

                string txtCategoria = "";
                for (int i = 0; i < ListSubCategoria.Count; i++)
                    txtCategoria += ListSubCategoria[i] + ",";

                if (txtPrecioOferta.Text != "" && mcFechaInicio.Text == "" && mcFechaFin.Text == "")
                    MessageBox.Show("Falta ingresar las fechas de incio y fin de las ofertas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtPrecioOferta.Text == "" && mcFechaInicio.Text != "" && mcFechaFin.Text != "")
                    MessageBox.Show("Falta ingresar el precio de oferta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcionCorta.Text != "" && txtPrecioNormal.Text != "" && itemSelct != "" && txtInventario.Text != "")
                    {
                        comprobarData();
                        if (int.Parse(txtPrecioOferta.Text) < int.Parse(txtPrecioNormal.Text))
                        {
                            if (int.Parse(txtStock.Text) < int.Parse(txtInventario.Text))
                            {
                                if (existe != true)
                                {

                                    ce.DtProductos.Rows.Add(txtCodigo.Text, txtTipoProducto.Text, txtNombre.Text,
                                      txtDescripcionCorta.Text, txtDescripcionCompleta.Text, mcFechaInicio.Text,
                                      mcFechaFin.Text, txtInventario.Text, txtStock.Text, txtPrecioOferta.Text,
                                      txtPrecioNormal.Text, cmbCategoria.Text, txtCategoria, txtEtiqueta.Text, txtImagen.Text);
                                }
                                else
                                {
                                    ce.DtProductos[0, Posicion].Value = txtCodigo.Text;
                                    ce.DtProductos[1, Posicion].Value = txtTipoProducto.Text;
                                    ce.DtProductos[2, Posicion].Value = txtNombre.Text;
                                    ce.DtProductos[3, Posicion].Value = txtDescripcionCorta.Text;
                                    ce.DtProductos[4, Posicion].Value = txtDescripcionCompleta.Text;
                                    ce.DtProductos[5, Posicion].Value = mcFechaInicio.Text;
                                    ce.DtProductos[6, Posicion].Value = mcFechaFin.Text;
                                    ce.DtProductos[7, Posicion].Value = txtInventario.Text;
                                    ce.DtProductos[8, Posicion].Value = txtStock.Text;
                                    ce.DtProductos[9, Posicion].Value = txtPrecioOferta.Text;
                                    ce.DtProductos[10, Posicion].Value = txtPrecioNormal.Text;
                                    ce.DtProductos[11, Posicion].Value = cmbCategoria.Text;
                                    ce.DtProductos[12, Posicion].Value = txtCategoria;
                                    ce.DtProductos[13, Posicion].Value = txtEtiqueta.Text;
                                    ce.DtProductos[14, Posicion].Value = txtImagen.Text;
                                }

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
            if (txtPrecioOferta.Text == "")
                txtPrecioOferta.Text = "0";
            else if (txtPrecioNormal.Text == "")
                txtPrecioNormal.Text = "0";
            else if (txtStock.Text == "")
                txtStock.Text = "0";
            else if (txtInventario.Text == "")
                txtInventario.Text = "0";
        }
        private void cambiarData()
        {
            if (txtPrecioOferta.Text == "0")
                txtPrecioOferta.Text = "";
            else if (txtPrecioNormal.Text == "0")
                txtPrecioNormal.Text = "";
            else if (txtStock.Text == "0")
                txtStock.Text = "";
            else if (txtInventario.Text == "0")
                txtInventario.Text = "";
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
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Cat_Sub' Puede moverla o quitarla según sea necesario.
            this.cat_SubTableAdapter.Fill(this.bdCamaraComercioDataSet.Cat_Sub);

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
                cmbCategoria.SelectedIndex = 24;

                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
                DataTable datos = this.productosTableAdapter.GetData();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    mycollection.Add(datos.Rows[i][1].ToString());
                }
                txtNombre.AutoCompleteCustomSource = mycollection;
                //DataGridViewButtonColumn btnClear = new DataGridViewButtonColumn();
                //btnClear.Name = "Eliminar";
                //dgvSubCatergoria.Columns.Add(btnClear);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void EditaText(string texto)
        {
            txtImagen.Text = texto;
            //MessageBox.Show(texto+"--");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    DataTable datos = this.productosTableAdapter.BuscaNombre(txtNombre.Text);
                    if (datos.Rows.Count > 0)
                    {
                        dgvSubCatergoria.Rows.Clear();
                        txtCodigo.Text = datos.Rows[0][0].ToString();
                        txtDescripcionCorta.Text = datos.Rows[0][2].ToString();
                        txtDescripcionCompleta.Text = datos.Rows[0][3].ToString();
                        txtInventario.Text = datos.Rows[0][4].ToString();
                        txtStock.Text = datos.Rows[0][5].ToString();
                        txtPrecioNormal.Text = datos.Rows[0][6].ToString();
                        txtPrecioOferta.Text = datos.Rows[0][7].ToString();
                        txtImagen.Text = datos.Rows[0][12].ToString();
                        txtTipoProducto.Text = datos.Rows[0][8].ToString();
                        mcFechaInicio.Text = datos.Rows[0][10].ToString();
                        mcFechaFin.Text = datos.Rows[0][9].ToString();
                        txtEtiqueta.Text = datos.Rows[0][11].ToString();
                        cambiarData();
                        DataTable subcat = this.cat_SubTableAdapter.BuscarSubCat(datos.Rows[0][0].ToString());
                        for (int i = 0; i < subcat.Rows.Count; i++)
                        {
                            ListSubCategoria.Add(subcat.Rows[i]["Descripcion"].ToString());
                            dgvSubCatergoria.Rows.Add(subcat.Rows[i]["Descripcion"].ToString());
                        }

                        DataTable tabla = this.categoriasTableAdapter.GetData();
                        cmbCategoria.DisplayMember = "des";
                        cmbCategoria.ValueMember = "idcat";

                        DataTable datosTwo = this.productosTableAdapter.BuscarIdProducto(datos.Rows[0][0].ToString());
                        string id = datosTwo.Rows[0][13].ToString();

                        List<Product> lista = new List<Product>();
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
                        }
                        cmbCategoria.DataSource = lista;
                        cmbCategoria.SelectedValue = Convert.ToInt32(id);
                        if (id == "29") { dgvSubCatergoria.Rows.Clear(); }
                        else
                        {
                            cmbSubCategorias.Enabled = true;
                            InsertComboboxData(id);
                        }
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
        private void llenarCombo(string idcate)
        {
            try
            {
                InsertComboboxData(idcate);
                dgvSubCatergoria.Rows.Clear();
                listSubCate = new List<Product>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void InsertComboboxData(string idcate)
        {
            try
            {
                //Elimina los datos que se encuentar en el combobox
                cmbSubCategorias.DataSource = null;

                //Realiza una busqueda en la bade de datos Tabla SubCategorias
                DataTable tabla = this.subCategoriaTableAdapter.BuscarSub(idcate);
                cmbSubCategorias.DisplayMember = "des";
                cmbSubCategorias.ValueMember = "idcat";

                listSubCate = new List<Product>();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    listSubCate.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
                }
                //Ingresa los datos encontrados en el combobox
                cmbSubCategorias.DataSource = listSubCate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                ItemSelct = cmbCategoria.SelectedValue.ToString();
                if (cmbCategoria.SelectedValue.ToString() != null)
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
                for(int i=0;i< dgvSubCatergoria.Rows.Count;i++)
                {
                    if (dgvSubCatergoria.Rows[i].Cells[0].Value.ToString() == cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem))
                        existeDuplicado = true;
                }
                if (existeDuplicado != true)
                {
                    ListSubCategoria.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
                    dgvSubCatergoria.Rows.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecioOferta_Leave(object sender, EventArgs e)
        {
            mcFechaFin.Enabled = true;
            mcFechaInicio.Enabled = true;
            mcFechaFins.Enabled = true;
            mcFechaInicios.Enabled = true;
        }

        private void dgvSubCatergoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSubCatergoria.Rows.Remove(dgvSubCatergoria.CurrentRow);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CloudingImag frmImag = new CloudingImag(txtImagen.Text,"");
            frmImag.ShowDialog();
        }

        private void txtImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
