﻿namespace Proyecto_Final_Lab_I
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo_venta = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dgv_busquedaProd = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pb_buscar = new System.Windows.Forms.PictureBox();
            this.dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.txt_numFac = new System.Windows.Forms.TextBox();
            this.lbl_teextranio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_venta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_venta.Location = new System.Drawing.Point(459, 9);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(74, 29);
            this.lbl_titulo_venta.TabIndex = 0;
            this.lbl_titulo_venta.Text = "Venta";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descripcion.Location = new System.Drawing.Point(12, 128);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(293, 15);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.Text = "Descripción";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar.Location = new System.Drawing.Point(12, 278);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(299, 15);
            this.txt_buscar.TabIndex = 8;
            this.txt_buscar.Text = "Buscar";
            this.txt_buscar.TextChanged += new System.EventHandler(this.pb_buscar_Click);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            this.txt_buscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_buscar_MouseDown);
            // 
            // btn_facturar
            // 
            this.btn_facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facturar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_facturar.FlatAppearance.BorderSize = 3;
            this.btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_facturar.Location = new System.Drawing.Point(887, 532);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(151, 66);
            this.btn_facturar.TabIndex = 9;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bnt_cancelar.FlatAppearance.BorderSize = 3;
            this.bnt_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bnt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_cancelar.ForeColor = System.Drawing.Color.Tomato;
            this.bnt_cancelar.Location = new System.Drawing.Point(694, 532);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(151, 66);
            this.bnt_cancelar.TabIndex = 10;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            this.bnt_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1050, 610);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 171;
            this.lineShape6.X2 = 308;
            this.lineShape6.Y1 = 185;
            this.lineShape6.Y2 = 185;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 12;
            this.lineShape5.X2 = 360;
            this.lineShape5.Y1 = 297;
            this.lineShape5.Y2 = 297;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 11;
            this.lineShape4.X2 = 309;
            this.lineShape4.Y1 = 149;
            this.lineShape4.Y2 = 149;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 11;
            this.lineShape3.X2 = 155;
            this.lineShape3.Y1 = 108;
            this.lineShape3.Y2 = 108;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 150;
            this.lineShape1.Y1 = 185;
            this.lineShape1.Y2 = 185;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad.Location = new System.Drawing.Point(175, 165);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(130, 15);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.Text = "Cantidad";
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            this.txt_cantidad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseDown);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_precio.Location = new System.Drawing.Point(13, 165);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(130, 15);
            this.txt_precio.TabIndex = 1;
            this.txt_precio.TabStop = false;
            this.txt_precio.Text = "$ 0.00";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(12, 87);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(293, 15);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.Text = "Código del producto";
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            this.txt_codigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_codigo_MouseDown);
            // 
            // dgv_busquedaProd
            // 
            this.dgv_busquedaProd.AllowUserToResizeColumns = false;
            this.dgv_busquedaProd.AllowUserToResizeRows = false;
            this.dgv_busquedaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_busquedaProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgv_busquedaProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_busquedaProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_busquedaProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_busquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_busquedaProd.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_busquedaProd.EnableHeadersVisualStyles = false;
            this.dgv_busquedaProd.GridColor = System.Drawing.Color.LightGreen;
            this.dgv_busquedaProd.Location = new System.Drawing.Point(12, 307);
            this.dgv_busquedaProd.Name = "dgv_busquedaProd";
            this.dgv_busquedaProd.ReadOnly = true;
            this.dgv_busquedaProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_busquedaProd.RowHeadersVisible = false;
            this.dgv_busquedaProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_busquedaProd.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgv_busquedaProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busquedaProd.Size = new System.Drawing.Size(395, 291);
            this.dgv_busquedaProd.TabIndex = 6;
            this.dgv_busquedaProd.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.Location = new System.Drawing.Point(13, 202);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(341, 37);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pb_buscar
            // 
            this.pb_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_buscar.Image = global::Proyecto_Final_Lab_I.Properties.Resources.image1;
            this.pb_buscar.Location = new System.Drawing.Point(322, 264);
            this.pb_buscar.Name = "pb_buscar";
            this.pb_buscar.Size = new System.Drawing.Size(39, 29);
            this.pb_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_buscar.TabIndex = 12;
            this.pb_buscar.TabStop = false;
            this.pb_buscar.Click += new System.EventHandler(this.pb_buscar_Click);
            // 
            // dgv_detalleFactura
            // 
            this.dgv_detalleFactura.AllowUserToResizeColumns = false;
            this.dgv_detalleFactura.AllowUserToResizeRows = false;
            this.dgv_detalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalleFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgv_detalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detalleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_detalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalleFactura.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgv_detalleFactura.EnableHeadersVisualStyles = false;
            this.dgv_detalleFactura.GridColor = System.Drawing.Color.LightGreen;
            this.dgv_detalleFactura.Location = new System.Drawing.Point(454, 87);
            this.dgv_detalleFactura.Name = "dgv_detalleFactura";
            this.dgv_detalleFactura.ReadOnly = true;
            this.dgv_detalleFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgv_detalleFactura.RowHeadersVisible = false;
            this.dgv_detalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_detalleFactura.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgv_detalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalleFactura.Size = new System.Drawing.Size(565, 422);
            this.dgv_detalleFactura.TabIndex = 13;
            // 
            // txt_numFac
            // 
            this.txt_numFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_numFac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numFac.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_numFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numFac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_numFac.Location = new System.Drawing.Point(454, 66);
            this.txt_numFac.Name = "txt_numFac";
            this.txt_numFac.Size = new System.Drawing.Size(85, 15);
            this.txt_numFac.TabIndex = 14;
            this.txt_numFac.Text = "N° Factura ";
            // 
            // lbl_teextranio
            // 
            this.lbl_teextranio.AutoSize = true;
            this.lbl_teextranio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teextranio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_teextranio.Location = new System.Drawing.Point(449, 532);
            this.lbl_teextranio.Name = "lbl_teextranio";
            this.lbl_teextranio.Size = new System.Drawing.Size(76, 25);
            this.lbl_teextranio.TabIndex = 15;
            this.lbl_teextranio.Text = "Carrito";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.lbl_teextranio);
            this.Controls.Add(this.txt_numFac);
            this.Controls.Add(this.dgv_detalleFactura);
            this.Controls.Add(this.pb_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_busquedaProd);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_titulo_venta);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button bnt_cancelar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pb_buscar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridView dgv_busquedaProd;
        private System.Windows.Forms.Button btn_agregar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.DataGridView dgv_detalleFactura;
        private System.Windows.Forms.TextBox txt_numFac;
        private System.Windows.Forms.Label lbl_teextranio;
    }
}