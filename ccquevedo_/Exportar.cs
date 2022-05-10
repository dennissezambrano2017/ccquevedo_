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
                string ruta;
                string strExport="";
                int columnas= dtlist.ColumnCount;
                int fila= dtlist.RowCount;
                int total=columnas*fila;
                foreach (DataGridViewColumn columna in dtlist.Columns)
                {
                    strExport+= '"' + columna.Name+ '"' + ",";
                }
                strExport= strExport.Substring(0,strExport.Length-1);
                strExport += Environment.NewLine;
                foreach (DataGridViewRow filas in dtlist.Rows)
                {
                    foreach (DataGridViewCell celda in filas.Cells)
                    {
                        if(celda.Value!=null)
                            strExport += '"' + celda.Value.ToString() + '"' + ",";
                        else
                            strExport += ",";
                    }
                    strExport = strExport.Substring(0, strExport.Length - 1);
                    strExport += Environment.NewLine;
                }
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                fichero.Filter = "Archivos CSV  (*.CSV)|*.CSV";
                fichero.FilterIndex = 2;
                fichero.FileName = "Product_export";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    ruta = fichero.FileName;
                    MessageBox.Show("Exportado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.IO.TextWriter tw = new System.IO.StreamWriter(ruta);
                    tw.Write(strExport);
                    tw.Close();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }
        }
    }
}
