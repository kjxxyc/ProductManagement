namespace ProductManagement.GUI.Catalogs
{
    partial class FrmProducts
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatusAC = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStatusIN = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1016, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Salir";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NumFile,
            this.Code,
            this.ProductName,
            this.QuantityStock,
            this.Status,
            this.CreatedDate,
            this.ImageProduct});
            this.dgvProducts.Location = new System.Drawing.Point(25, 204);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1105, 440);
            this.dgvProducts.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // NumFile
            // 
            this.NumFile.HeaderText = "N#";
            this.NumFile.MinimumWidth = 8;
            this.NumFile.Name = "NumFile";
            this.NumFile.ReadOnly = true;
            this.NumFile.Width = 150;
            // 
            // Code
            // 
            this.Code.HeaderText = "Código";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Nombre del Producto";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // QuantityStock
            // 
            this.QuantityStock.HeaderText = "Existencia";
            this.QuantityStock.MinimumWidth = 8;
            this.QuantityStock.Name = "QuantityStock";
            this.QuantityStock.ReadOnly = true;
            this.QuantityStock.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Fecha Creación";
            this.CreatedDate.MinimumWidth = 8;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 150;
            // 
            // ImageProduct
            // 
            this.ImageProduct.HeaderText = "Imagen del producto";
            this.ImageProduct.MinimumWidth = 8;
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.ReadOnly = true;
            this.ImageProduct.Visible = false;
            this.ImageProduct.Width = 150;
            // 
            // btnStatusAC
            // 
            this.btnStatusAC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStatusAC.Location = new System.Drawing.Point(17, 29);
            this.btnStatusAC.Name = "btnStatusAC";
            this.btnStatusAC.Size = new System.Drawing.Size(100, 40);
            this.btnStatusAC.TabIndex = 3;
            this.btnStatusAC.Text = "Activos";
            this.btnStatusAC.UseVisualStyleBackColor = false;
            this.btnStatusAC.Click += new System.EventHandler(this.btnStatusAC_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(516, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStatusIN
            // 
            this.btnStatusIN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStatusIN.Location = new System.Drawing.Point(126, 29);
            this.btnStatusIN.Name = "btnStatusIN";
            this.btnStatusIN.Size = new System.Drawing.Size(100, 40);
            this.btnStatusIN.TabIndex = 5;
            this.btnStatusIN.Text = "Inactivos";
            this.btnStatusIN.UseVisualStyleBackColor = false;
            this.btnStatusIN.Click += new System.EventHandler(this.btnStatusIN_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 26);
            this.txtSearch.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatusIN);
            this.groupBox1.Controls.Add(this.btnStatusAC);
            this.groupBox1.Location = new System.Drawing.Point(704, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Estados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(25, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por Nombre";
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(25, 146);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(209, 40);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Ver Opciones Asociadas";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateProduct.Location = new System.Drawing.Point(491, 146);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(150, 40);
            this.btnCreateProduct.TabIndex = 11;
            this.btnCreateProduct.Text = "Crear Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateProduct.Location = new System.Drawing.Point(262, 146);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateProduct.TabIndex = 12;
            this.btnUpdateProduct.Text = "Ver / Modificar Producto";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1167, 668);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnStatusAC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStatusIN;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
    }
}