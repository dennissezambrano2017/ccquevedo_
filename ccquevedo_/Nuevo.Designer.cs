
namespace ccquevedo_
{
    partial class Nuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(23, 36);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(96, 78);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Id, \r\nnonbre, \r\nDescripción corta, \r\nprecio rebajado,\r\nprecio normal,\r\nImagen";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lblDatos);
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
    }
}