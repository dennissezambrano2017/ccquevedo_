﻿namespace ccquevedo_
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPrecionormal = new System.Windows.Forms.Label();
            this.lblDescripcionCorta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesCorta = new System.Windows.Forms.TextBox();
            this.txtPrecioNormal = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtDescriComple = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnGuadar = new System.Windows.Forms.Button();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bdCamaraComercioDataSet = new ccquevedo_.bdCamaraComercioDataSet();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mcFechaFin = new System.Windows.Forms.DateTimePicker();
            this.mcFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Modificar Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 50);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tipo de producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Imagen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Minimo Stock:*";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(564, 125);
            this.lblImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(137, 22);
            this.lblImage.TabIndex = 30;
            this.lblImage.Text = "Precio Oferta:";
            // 
            // lblPrecionormal
            // 
            this.lblPrecionormal.AutoSize = true;
            this.lblPrecionormal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecionormal.Location = new System.Drawing.Point(564, 84);
            this.lblPrecionormal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecionormal.Name = "lblPrecionormal";
            this.lblPrecionormal.Size = new System.Drawing.Size(139, 22);
            this.lblPrecionormal.TabIndex = 29;
            this.lblPrecionormal.Text = "Precio normal:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCorta.Location = new System.Drawing.Point(31, 162);
            this.lblDescripcionCorta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(179, 22);
            this.lblDescripcionCorta.TabIndex = 28;
            this.lblDescripcionCorta.Text = "Descripcion Corta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 122);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 22);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(31, 81);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 22);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(236, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 31);
            this.txtCodigo.TabIndex = 36;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(236, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 31);
            this.txtNombre.TabIndex = 37;
            // 
            // txtDesCorta
            // 
            this.txtDesCorta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesCorta.Location = new System.Drawing.Point(236, 159);
            this.txtDesCorta.Name = "txtDesCorta";
            this.txtDesCorta.Size = new System.Drawing.Size(272, 31);
            this.txtDesCorta.TabIndex = 38;
            // 
            // txtPrecioNormal
            // 
            this.txtPrecioNormal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioNormal.Location = new System.Drawing.Point(782, 77);
            this.txtPrecioNormal.Name = "txtPrecioNormal";
            this.txtPrecioNormal.Size = new System.Drawing.Size(272, 31);
            this.txtPrecioNormal.TabIndex = 39;
            this.txtPrecioNormal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioNormal_KeyPress);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioOferta.Location = new System.Drawing.Point(782, 119);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(272, 31);
            this.txtPrecioOferta.TabIndex = 40;
            this.txtPrecioOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioOferta_KeyPress);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProducto.Location = new System.Drawing.Point(782, 365);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(272, 31);
            this.txtTipoProducto.TabIndex = 45;
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(782, 215);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(272, 31);
            this.txtImage.TabIndex = 43;
            // 
            // txtDescriComple
            // 
            this.txtDescriComple.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriComple.Location = new System.Drawing.Point(236, 200);
            this.txtDescriComple.Multiline = true;
            this.txtDescriComple.Name = "txtDescriComple";
            this.txtDescriComple.Size = new System.Drawing.Size(272, 127);
            this.txtDescriComple.TabIndex = 42;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(236, 381);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(272, 31);
            this.txtStock.TabIndex = 41;
            // 
            // btnGuadar
            // 
            this.btnGuadar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuadar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuadar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuadar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuadar.Image")));
            this.btnGuadar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuadar.Location = new System.Drawing.Point(798, 471);
            this.btnGuadar.Name = "btnGuadar";
            this.btnGuadar.Size = new System.Drawing.Size(159, 47);
            this.btnGuadar.TabIndex = 46;
            this.btnGuadar.Text = "Guardar";
            this.btnGuadar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuadar.UseVisualStyleBackColor = false;
            this.btnGuadar.Click += new System.EventHandler(this.btnGuadar_Click);
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventario.Location = new System.Drawing.Point(236, 341);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(272, 31);
            this.txtInventario.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Inventario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(101, 44);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha fin \r\nde oferta:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(123, 44);
            this.label9.TabIndex = 57;
            this.label9.Text = "Fecha inicio \r\nde oferta:\r\n";
            // 
            // bdCamaraComercioDataSet
            // 
            this.bdCamaraComercioDataSet.DataSetName = "bdCamaraComercioDataSet";
            this.bdCamaraComercioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.bdCamaraComercioDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ccquevedo_.bdCamaraComercioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.categoriasBindingSource;
            this.cmbCategoria.DisplayMember = "descripcion";
            this.cmbCategoria.DropDownHeight = 100;
            this.cmbCategoria.DropDownWidth = 272;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.Location = new System.Drawing.Point(782, 168);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(272, 30);
            this.cmbCategoria.TabIndex = 10;
            this.cmbCategoria.ValueMember = "Id_Categoria";
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtEtiqueta.Location = new System.Drawing.Point(236, 432);
            this.txtEtiqueta.Multiline = true;
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(272, 67);
            this.txtEtiqueta.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label10.Location = new System.Drawing.Point(31, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 44);
            this.label10.TabIndex = 62;
            this.label10.Text = "Etiquetas:\r\n(Ejemplo:blusa,ropa)";
            // 
            // mcFechaFin
            // 
            this.mcFechaFin.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaFin.Location = new System.Drawing.Point(782, 311);
            this.mcFechaFin.Name = "mcFechaFin";
            this.mcFechaFin.Size = new System.Drawing.Size(272, 31);
            this.mcFechaFin.TabIndex = 65;
            // 
            // mcFechaInicio
            // 
            this.mcFechaInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicio.CustomFormat = "";
            this.mcFechaInicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFechaInicio.Location = new System.Drawing.Point(782, 263);
            this.mcFechaInicio.Name = "mcFechaInicio";
            this.mcFechaInicio.Size = new System.Drawing.Size(272, 31);
            this.mcFechaInicio.TabIndex = 64;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1107, 563);
            this.Controls.Add(this.mcFechaFin);
            this.Controls.Add(this.mcFechaInicio);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuadar);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtDescriComple);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtPrecioNormal);
            this.Controls.Add(this.txtDesCorta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblPrecionormal);
            this.Controls.Add(this.lblDescripcionCorta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modificar_FormClosing);
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCamaraComercioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPrecionormal;
        private System.Windows.Forms.Label lblDescripcionCorta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuadar;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDesCorta;
        public System.Windows.Forms.TextBox txtPrecioNormal;
        public System.Windows.Forms.TextBox txtPrecioOferta;
        public System.Windows.Forms.TextBox txtTipoProducto;
        public System.Windows.Forms.TextBox txtImage;
        public System.Windows.Forms.TextBox txtDescriComple;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private bdCamaraComercioDataSet bdCamaraComercioDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private bdCamaraComercioDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private bdCamaraComercioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtEtiqueta;
        public System.Windows.Forms.DateTimePicker mcFechaFin;
        public System.Windows.Forms.DateTimePicker mcFechaInicio;
    }
}