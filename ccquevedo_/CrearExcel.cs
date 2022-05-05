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
        private int posicion;
        private bool datos;
        public CrearExcel()
        {
            InitializeComponent();

        }
        private DataGridView dtProductos;

        public DataGridView DtProductos { get => dtProductos; set => dtProductos = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public bool Datos { get => datos; set => datos = value; }

        public void DT_Productos()
        {
            dtProductos = dgvProducto;
        }
        public void Posicion_()
        {
            posicion = dgvProducto.CurrentRow.Index;
        }

        public void Datos_()
        {
            datos = true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo frmCrear =  Nuevo.FormCrear();
            AddOwnedForm(frmCrear);
            frmCrear.ShowDialog();

        }


        private void CrearExcel_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                DT_Productos();

                dgvProducto.Columns.Add("Codigo", "Codigo");
                dgvProducto.Columns.Add("Nombre", "Nombre");
                dgvProducto.Columns.Add("DescripcionCorta", "Descripción Corta");
                dgvProducto.Columns.Add("DescripcionLarga", "Descripción Larga");
                dgvProducto.Columns.Add("PrecioNormal", "Precio Normal");
                dgvProducto.Columns.Add("PrecioOferta", "Precio Oferta");
                dgvProducto.Columns.Add("Stock", "Stock");
                dgvProducto.Columns.Add("Imagen", "Imagen");
                dgvProducto.Columns.Add("Categoria", "Categoria");
                dgvProducto.Columns.Add("TipoProducto", "Tipo Producto");

                if (dgvProducto.SelectedRows.Count > 0)
                    Datos_();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = Modificar.FormCrear();
            try
            {
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    Posicion_();
                    AddOwnedForm(frmModificar);
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
                    dgvProducto.Rows[0].Selected = false;
                }
                else
                    MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void btnElimnar_Click(object sender, EventArgs e)
        {
           
            if (dgvProducto.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Esta seguro de eliminar la fila", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvProducto.Rows.Remove(dgvProducto.CurrentRow);
                    dgvProducto.Rows[0].Selected = false;
                }
               
            }
            else
                MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnActu_Desca_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows != null && dgvProducto.Rows.Count != 0)
            {
                Insertar();
                Exportar(dgvProducto);
            }
            else
                MessageBox.Show("No existen datos para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Exportar(DataGridView dtlist)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Product-export-" + DateTime.Now.ToString("MM-dd-yy-H-mm-ss");
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application exportarExcel;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    exportarExcel = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = exportarExcel.Workbooks.Add();
                    hoja_trabajo = 
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    int indiecolumna = 0;
                    foreach (DataGridViewColumn columna in dtlist.Columns)
                    {
                        indiecolumna++;
                        exportarExcel.Cells[1, indiecolumna] = columna.Name;
                    }

                    int indicefila = 0;
                    foreach (DataGridViewRow fila in dtlist.Rows)
                    {
                        indicefila++;
                        indiecolumna = 0;
                        foreach (DataGridViewColumn columna in dtlist.Columns)
                        {
                            indiecolumna++;
                            exportarExcel.Cells[indicefila + 1, indiecolumna] = fila.Cells[columna.Name].Value;
                        }
                    }

                    libros_trabajo.SaveAs(fichero.FileName, 
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    exportarExcel.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }
}

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if(dgvProducto.Rows.Count > 0)
            {
                Insertar();
            }
            else
                MessageBox.Show("No existen datos en la tabla para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Insertar()
        {
            try
            {
                for (int i = 0; i < dgvProducto.Rows.Count; i++)
                {
                    var v = this.productosTableAdapter.Existe(
                           Convert.ToInt32(dtProductos.Rows[i].Cells[0].Value.ToString()));
                    if (v.ToString() != "1")

                    {
                        this.productosTableAdapter.Insertar(
                        Convert.ToInt32(dtProductos.Rows[i].Cells[0].Value.ToString()),
                        dtProductos.Rows[i].Cells[1].Value.ToString(),
                        dtProductos.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToInt32(dtProductos.Rows[i].Cells[6].Value.ToString()),
                        dtProductos.Rows[i].Cells[6].Value.ToString(),
                        Convert.ToInt32(dtProductos.Rows[i].Cells[6].Value.ToString()),
                        dtProductos.Rows[i].Cells[3].Value.ToString(),
                        DateTime.Now, DateTime.Now, 1,
                        Convert.ToDecimal(dtProductos.Rows[i].Cells[4].Value.ToString()),
                        Convert.ToDecimal(dtProductos.Rows[i].Cells[5].Value.ToString()), "Simple");
                        //this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                    }
                }
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
    }
}
