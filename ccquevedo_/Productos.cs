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
    public partial class Productos : Form
    {
        private static Productos instancia = null;
        public static Productos FormCrear()
        {
            if (instancia == null)
            {
                instancia = new Productos();
                return instancia;
            }
            return instancia;
        }
        public Productos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'bdCamaraComercioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);

           
            //DataTable datos = this.productosTableAdapter.GetData();
            //foreach (DataGridViewRow row in dgvProductos.Rows)
            //{
            //    row.Cells[2].Value = Convert.ToString("NP");
            //}
            

            //dgvProductos.DataSource = this.bdCamaraComercioDataSet.Productos ;
            //for (int fila = 0; fila < dtaPagos.Rows.Count - 1; fila++)
            //{
            //    for (int col = 0; col < dtaPagos.Rows[fila].Cells.Count; col++)
            //    {
            //        string valor = dtaPagos.Rows[fila].Cells[col].Value.ToString();
            //        MessageBox.Show(valor);
            //    }
            //}
        }

        private int? getId(int num)
        {
            try
            {
                return Convert.ToInt32(dgvProductos.Rows[num].Cells["Id"].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int num;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                num = dgvProductos.CurrentRow.Index;
                int? id = getId(num);
                Form form = new Editar(id);
                form.ShowDialog();
                this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                dgvProductos.Rows[0].Selected = false;
            }
            else
                MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCamaraComercioDataSet);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int num;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Esta seguro de eliminar la fila", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    num = dgvProductos.CurrentRow.Index;
                    int? id = getId(num);
                    //Form form = new Editar(id);
                    //form.Show();
                    this.productosTableAdapter.Eliminar(Convert.ToInt32(id));
                    this.productosTableAdapter.Fill(this.bdCamaraComercioDataSet.Productos);
                    dgvProductos.Rows[0].Selected = false;
                }
            }
            else
                MessageBox.Show("Seleccione una fila con datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows != null && dgvProductos.Rows.Count != 0)
            {
                DataGridView dgvAxu = new DataGridView();
                dgvAxu.Columns.Add("ID", "Codigo");
                dgvAxu.Columns.Add("Tipo", "Tipo Producto");
                dgvAxu.Columns.Add("Nombre", "Nombre");
                dgvAxu.Columns.Add("Descripción corta", "Descripción Corta");
                dgvAxu.Columns.Add("Descripción", "Descripción Larga");
                dgvAxu.Columns.Add("Día en que empieza el precio rebajado", "Fecha Inicio");
                dgvAxu.Columns.Add("Día en que termina el precio rebajado", "Fecha Fin");
                dgvAxu.Columns.Add("Inventario", "Stock");
                dgvAxu.Columns.Add("Cantidad de bajo inventario", "Min Stock");
                dgvAxu.Columns.Add("Precio rebajado", "Precio Oferta");
                dgvAxu.Columns.Add("Precio normal", "Precio Normal");
                dgvAxu.Columns.Add("Categorías", "Categoria");
                dgvAxu.Columns.Add("Etiquetas", "Etiquetas");
                dgvAxu.Columns.Add("Imágenes", "Imagen");
                dgvAxu.DataSource = dgvProductos;
                Exportar(dgvAxu);
            }
            else
                MessageBox.Show("No existen datos para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Exportar(DataGridView dtlist)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Archivos CSV (*.CSV)|*.CSV";
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
    }
}