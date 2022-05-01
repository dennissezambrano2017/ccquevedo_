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
    public partial class CrearExcel : Form
    {

        public CrearExcel()
        {
            InitializeComponent();
        }
        private DataGridView dtProductos;

        public DataGridView DtProductos { get => dtProductos; set => dtProductos = value; }

        public void DT_Productos()
        {
            dtProductos = dgvProducto;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo frmCrear =  Nuevo.FormCrear();
            AddOwnedForm(frmCrear);
            frmCrear.ShowDialog();
            //frmCrear.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = Modificar.FormCrear();
            frmModificar.txtCodigo.Text = dtProductos.CurrentRow.Cells[0].Value.ToString();
            frmModificar.txtNombre.Text = dtProductos.CurrentRow.Cells[1].Value.ToString();
            frmModificar.txtDesCorta.Text = dtProductos.CurrentRow.Cells[2].Value.ToString();
            frmModificar.txtDescriComple.Text = dtProductos.CurrentRow.Cells[3].Value.ToString();
            frmModificar.txtPrecioNormal.Text = dtProductos.CurrentRow.Cells[4].Value.ToString();
            frmModificar.txtPrecioOferta.Text = dtProductos.CurrentRow.Cells[5].Value.ToString();
            frmModificar.txtStock.Text = dtProductos.CurrentRow.Cells[6].Value.ToString();
            frmModificar.txtImage.Text = dtProductos.CurrentRow.Cells[7].Value.ToString();
            frmModificar.cmbCategoria.Text = dtProductos.CurrentRow.Cells[8].Value.ToString();
            frmModificar.txtTipoProducto.Text = dtProductos.CurrentRow.Cells[9].Value.ToString();
            frmModificar.ShowDialog();
            //frmModificar.BringToFront();
        }

        private void CrearExcel_Load(object sender, EventArgs e)
        {
            DT_Productos();
            dgvProducto.Columns.Add("Codigo", "Codigo");
            dgvProducto.Columns.Add("Nombre", "Nombre");
            dgvProducto.Columns.Add("DescripcionCorta", "Descripcion Corta");
            dgvProducto.Columns.Add("DescripcionLarga", "Descripcion Larga");
            dgvProducto.Columns.Add("PrecioNormal", "Precio Normal");
            dgvProducto.Columns.Add("PrecioOferta", "Precio Oferta");
            dgvProducto.Columns.Add("Stock", "Stock");
            dgvProducto.Columns.Add("Imagen", "Imagen");
            dgvProducto.Columns.Add("Categoria", "Categoria");
            dgvProducto.Columns.Add("TipoProducto", "Tipo Producto");
        }
    }
}
