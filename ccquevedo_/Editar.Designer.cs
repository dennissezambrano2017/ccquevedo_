﻿namespace ccquevedo_
{
    partial class Editar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtprecioRebajado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtminStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDesCorta = new System.Windows.Forms.Label();
            this.bdCamaraComercioDataSet = new ccquevedo_.bdCamaraComercioDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDesComple = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblNombre.Location = new System.Drawing.Point(31, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:*";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(236, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtprecioRebajado
            // 
            this.txtprecioRebajado.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtprecioRebajado.Location = new System.Drawing.Point(782, 77);
            this.txtprecioRebajado.Name = "txtprecioRebajado";
            this.txtprecioRebajado.Size = new System.Drawing.Size(272, 31);
            this.txtprecioRebajado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(564, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio rebajado:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtPrecio.Location = new System.Drawing.Point(782, 119);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(272, 31);
            this.txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(564, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio normal:*";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCategoria.Location = new System.Drawing.Point(782, 165);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(272, 31);
            this.txtCategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(564, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:*";
            // 
            // txtminStock
            // 
            this.txtminStock.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtminStock.Location = new System.Drawing.Point(236, 381);
            this.txtminStock.Name = "txtminStock";
            this.txtminStock.Size = new System.Drawing.Size(272, 31);
            this.txtminStock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.Location = new System.Drawing.Point(31, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimo Stock:*";
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtInventario.Location = new System.Drawing.Point(236, 341);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(272, 31);
            this.txtInventario.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.Location = new System.Drawing.Point(31, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inventario:*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(236, 159);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 31);
            this.txtDescripcion.TabIndex = 15;
            // 
            // lblDesCorta
            // 
            this.lblDesCorta.AutoSize = true;
            this.lblDesCorta.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDesCorta.Location = new System.Drawing.Point(31, 162);
            this.lblDesCorta.Name = "lblDesCorta";
            this.lblDesCorta.Size = new System.Drawing.Size(188, 22);
            this.lblDesCorta.TabIndex = 14;
            this.lblDesCorta.Text = "Descripción Corta:*";
            // 
            // bdCamaraComercioDataSet
            // 
            this.bdCamaraComercioDataSet.DataSetName = "bdCamaraComercioDataSet";
            this.bdCamaraComercioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(236, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 127);
            this.textBox1.TabIndex = 18;
            // 
            // lblDesComple
            // 
            this.lblDesComple.AutoSize = true;
            this.lblDesComple.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDesComple.Location = new System.Drawing.Point(31, 201);
            this.lblDesComple.Name = "lblDesComple";
            this.lblDesComple.Size = new System.Drawing.Size(126, 22);
            this.lblDesComple.TabIndex = 17;
            this.lblDesComple.Text = "Descripción :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 50);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(503, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Modificar Productos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrar.Location = new System.Drawing.Point(1076, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Enabled = false;
            this.txtTipoProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProducto.Location = new System.Drawing.Point(782, 365);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(272, 31);
            this.txtTipoProducto.TabIndex = 49;
            this.txtTipoProducto.Text = "Simple";
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(782, 215);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(272, 31);
            this.txtImage.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tipo de producto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(564, 216);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 46;
            this.label12.Text = "Imagen:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(895, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 47);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(236, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 31);
            this.textBox2.TabIndex = 52;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblCodigo.Location = new System.Drawing.Point(31, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 22);
            this.lblCodigo.TabIndex = 51;
            this.lblCodigo.Text = "Codigo:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(782, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 31);
            this.textBox3.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(123, 44);
            this.label5.TabIndex = 53;
            this.label5.Text = "Fecha inicio \r\nde oferta:\r\n";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(782, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 31);
            this.textBox4.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(101, 44);
            this.label8.TabIndex = 55;
            this.label8.Text = "Fecha fin \r\nde oferta:\r\n";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 635);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDesComple);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDesCorta);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtminStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecioRebajado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtprecioRebajado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtminStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDesCorta;
        private bdCamaraComercioDataSet bdCamaraComercioDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bdCamaraComercioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDesComple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.TextBox txtTipoProducto;
        public System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}