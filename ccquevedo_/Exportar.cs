using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccquevedo_
{
    public class Exportar
    {
        public void ExportarDatos(DataGridView dtlist)
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
