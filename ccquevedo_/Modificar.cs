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

        private List<string> listSubCate = new List<string>();

        public List<string> ListSubCate { get => listSubCate; set => listSubCate = value; }

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
            try
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                comprobarData();
                if (int.Parse(txtPrecioOferta.Text) < int.Parse(txtPrecioNormal.Text))
                {
                    if (int.Parse(txtStock.Text) < int.Parse(txtInventario.Text))
                    {
                        
                        string txtCategoria = "";
                        for (int i = 0; i < listSubCate.Count; i++)
                            txtCategoria += cmbCategoria.Text + ">" + listSubCate[i].ToString() + ",";
                        if (listSubCate.Count == 0)
                        {
                            txtCategoria = cmbCategoria.Text;
                        }
                        //MessageBox.Show(txtCategoria);
                        CrearExcel ce = Owner as CrearExcel;
                        ce.DtProductos[0, ce.Posicion].Value = txtCodigo.Text;
                        ce.DtProductos[1, ce.Posicion].Value = txtTipoProducto.Text;
                        ce.DtProductos[2, ce.Posicion].Value = txtNombre.Text;
                        ce.DtProductos[3, ce.Posicion].Value = txtDesCorta.Text;
                        ce.DtProductos[4, ce.Posicion].Value = txtDescriComple.Text;
                        ce.DtProductos[5, ce.Posicion].Value = mcFechaInicio.Text;
                        ce.DtProductos[6, ce.Posicion].Value = mcFechaFin.Text;
                        ce.DtProductos[7, ce.Posicion].Value = txtInventario.Text;
                        ce.DtProductos[8, ce.Posicion].Value = txtStock.Text;
                        ce.DtProductos[9, ce.Posicion].Value = txtPrecioOferta.Text;
                        ce.DtProductos[10, ce.Posicion].Value = txtPrecioNormal.Text;
                        ce.DtProductos[11, ce.Posicion].Value = txtCategoria;
                        ce.DtProductos[12, ce.Posicion].Value = txtEtiqueta.Text;
                        ce.DtProductos[13, ce.Posicion].Value = txtImage.Text;
                        this.Close();
                    }
                    else
                        MessageBox.Show("El valor del minimo stock no debe ser mayor que el inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("El precio de oferta no debe ser mayor que el precio normal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.SubCategoria' Puede moverla o quitarla según sea necesario.
            this.subCategoriaTableAdapter.Fill(this.bdCamaraComercioDataSet.SubCategoria);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
                this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);

                //Cadena de categoria y sub categoria
                string cadena = cmbCategoria.Text;
                //posición para obtener la posición de la categoria
                int num = cadena.IndexOf(">");
                if (num < 1)
                {
                    num = cadena.Length;
                }
                //obtener el id de la categoria
                var id = this.categoriasTableAdapter.ConsultarId(cadena.Substring(0, num));

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
                llenarCombo(id);
                llenarData(cadena);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }

        private void mcFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaIncio = Convert.ToDateTime(mcFechaInicios.Text);

            mcFechaInicio.Text = fechaIncio.ToString("yyyy-MM-dd");
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
            DataTable tabla = this.subCategoriaTableAdapter.BuscarSub(idcate);
            cmbSubCategorias.DisplayMember = "des";
            cmbSubCategorias.ValueMember = "idcat";

            List<Product> lista = new List<Product>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                lista.Add(new Product(Convert.ToInt32(tabla.Rows[i][0].ToString()), tabla.Rows[i][1].ToString()));
            }
            cmbSubCategorias.DataSource = lista;
            ListSubCate = new List<string>();
        }
        private void llenarData(string cadena)
        {
            //obtener las subcategorias
            string[] parte = cadena.Split(',');

            List<string> resu = new List<string>();
            List<string> resuCa = new List<string>();
            for (int j = 0; j < parte.Length - 1; j++)
            {
                resu.Add(parte[j]);
            }
            for (int j = 0; j < resu.Count; j++)
            {
                string n = resu[j].Split('>')[1];
                if (n != "1")
                {
                    string partedos = resu[j].Split('>')[1];
                    resuCa.Add(partedos.ToString());
                }
            }
            for (int j = 0; j < resuCa.Count; j++)
            {
                ListSubCate.Add(resuCa[j].ToString());
                dgvSubCatergoria.Rows.Add(resuCa[j].ToString());
            }
            
        }


        private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarCombo(cmbCategoria.SelectedValue.ToString());
            dgvSubCatergoria.Rows.Clear();
        }

        private void cmbSubCategorias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListSubCate.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
            dgvSubCatergoria.Rows.Add(cmbSubCategorias.GetItemText(cmbSubCategorias.SelectedItem));
        }

    }
}
