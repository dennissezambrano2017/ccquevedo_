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
                DataTable tablaUno = this.productosTableAdapter.BuscarDatos(Convert.ToInt32(id));
                DataTable dataTable = this.categoriasTableAdapter.BuscarCategoria(Convert.ToInt32(tablaUno.Rows[0][9].ToString()));
                txtCodigo.Text = id.ToString();
                txtNombre.Text = tablaUno.Rows[0][1].ToString();
                txtDescripcion.Text = tablaUno.Rows[0][2].ToString();
                txtInventario.Text = tablaUno.Rows[0][3].ToString();
                txtImage.Text = tablaUno.Rows[0][4].ToString();
                txtminStock.Text = tablaUno.Rows[0][6].ToString();
                txtDescripcionL.Text = tablaUno.Rows[0][5].ToString();
                mcFechaFin.Text = tablaUno.Rows[0][12].ToString();
                mcFechaInicio.Text = tablaUno.Rows[0][11].ToString();
                cmbCategoria.Text= dataTable.Rows[0][1].ToString();
                idCat = Convert.ToInt32(tablaUno.Rows[0][9].ToString());
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
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }



        private void Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.bdCamaraComercioDataSet.Categorias);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

            //DataTable tablaDos = this.categoriasTableAdapter.GetData();
            //cmbCategoria.DisplayMember = "des";
            //cmbCategoria.ValueMember = "idcat";
            //List<Product> lista = new List<Product>();
            //for (int i = 0; i < tablaDos.Rows.Count; i++)
            //{
            //    lista.Add(new Product(Convert.ToInt32(tablaDos.Rows[i][0].ToString()), tablaDos.Rows[i][1].ToString()));
            //}
            //cmbCategoria.DataSource = lista;
            cmbCategoria.SelectedValue = idCat;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            idCat = int.Parse(cmbCategoria.SelectedValue.ToString());
            DateTime fechaIncio = Convert.ToDateTime(mcFechaInicio.Text);
            DateTime fechaFin =Convert.ToDateTime(mcFechaFin.Text);
            try{
                this.productosTableAdapter.Editar(txtNombre.Text, txtDescripcion.Text,
                                Convert.ToInt32(txtInventario.Text), "",
                                Convert.ToInt32(txtminStock.Text), txtDescripcionL.Text,
                                Convert.ToDateTime(fechaFin.ToString("yyyy-MM-dd HH:mm:ss")),
                                Convert.ToDateTime(fechaIncio.ToString("yyyy-MM-dd HH:mm:ss")), idCat,
                                Convert.ToDecimal(txtPrecio.Text),
                                Convert.ToDecimal(txtprecioRebajado.Text),
                                 "Simple", txtEtiqueta.Text, Convert.ToInt32(id));
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
    }
}
