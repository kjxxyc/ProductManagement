namespace ProductManagement.GUI.Catalogs
{
    partial class FrmCreateOrUpdateProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteOption = new System.Windows.Forms.Button();
            this.btnEditOption = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuantityStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCreatedUser = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtQuantityStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.pbImgen = new System.Windows.Forms.PictureBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.dgvTxtOptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtOptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtCreatedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteOption);
            this.groupBox1.Controls.Add(this.btnEditOption);
            this.groupBox1.Controls.Add(this.btnSaveProduct);
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.btnLoadImage);
            this.groupBox1.Controls.Add(this.lblCreatedUser);
            this.groupBox1.Controls.Add(this.btnAddOption);
            this.groupBox1.Controls.Add(this.lblCreatedDate);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblQuantityStock);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.txtCreatedUser);
            this.groupBox1.Controls.Add(this.txtCreatedDate);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtQuantityStock);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(972, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // btnDeleteOption
            // 
            this.btnDeleteOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOption.Location = new System.Drawing.Point(331, 70);
            this.btnDeleteOption.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOption.Name = "btnDeleteOption";
            this.btnDeleteOption.Size = new System.Drawing.Size(151, 28);
            this.btnDeleteOption.TabIndex = 24;
            this.btnDeleteOption.Text = "EliminarOpción";
            this.btnDeleteOption.UseVisualStyleBackColor = true;
            this.btnDeleteOption.Click += new System.EventHandler(this.btnDeleteOption_Click);
            // 
            // btnEditOption
            // 
            this.btnEditOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOption.Location = new System.Drawing.Point(176, 70);
            this.btnEditOption.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditOption.Name = "btnEditOption";
            this.btnEditOption.Size = new System.Drawing.Size(151, 28);
            this.btnEditOption.TabIndex = 23;
            this.btnEditOption.Text = "Editar Opción";
            this.btnEditOption.UseVisualStyleBackColor = true;
            this.btnEditOption.Click += new System.EventHandler(this.btnEditOption_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(760, 70);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(151, 28);
            this.btnSaveProduct.TabIndex = 22;
            this.btnSaveProduct.Text = "Guardar Producto";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(721, 38);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(99, 21);
            this.cmbSupplier.TabIndex = 20;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(723, 20);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(56, 13);
            this.lblSupplier.TabIndex = 16;
            this.lblSupplier.Text = "Proveedor";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(605, 70);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(151, 28);
            this.btnLoadImage.TabIndex = 21;
            this.btnLoadImage.Text = "Agregar Imagen";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Location = new System.Drawing.Point(838, 21);
            this.lblCreatedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(88, 13);
            this.lblCreatedUser.TabIndex = 15;
            this.lblCreatedUser.Text = "Usuario Creación";
            // 
            // btnAddOption
            // 
            this.btnAddOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOption.Location = new System.Drawing.Point(19, 70);
            this.btnAddOption.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(151, 28);
            this.btnAddOption.TabIndex = 19;
            this.btnAddOption.Text = "Agregar Opción";
            this.btnAddOption.UseVisualStyleBackColor = true;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(611, 21);
            this.lblCreatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(97, 13);
            this.lblCreatedDate.TabIndex = 14;
            this.lblCreatedDate.Text = "Fecha de Creación";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(525, 21);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Estado";
            // 
            // lblQuantityStock
            // 
            this.lblQuantityStock.AutoSize = true;
            this.lblQuantityStock.Location = new System.Drawing.Point(436, 23);
            this.lblQuantityStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantityStock.Name = "lblQuantityStock";
            this.lblQuantityStock.Size = new System.Drawing.Size(60, 13);
            this.lblQuantityStock.TabIndex = 11;
            this.lblQuantityStock.Text = "Existencias";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(104, 23);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(107, 13);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Nombre del Producto";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(19, 23);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Código";
            // 
            // txtCreatedUser
            // 
            this.txtCreatedUser.Location = new System.Drawing.Point(838, 40);
            this.txtCreatedUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatedUser.Name = "txtCreatedUser";
            this.txtCreatedUser.ReadOnly = true;
            this.txtCreatedUser.Size = new System.Drawing.Size(84, 20);
            this.txtCreatedUser.TabIndex = 6;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(611, 40);
            this.txtCreatedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(68, 20);
            this.txtCreatedDate.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(525, 40);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(68, 20);
            this.txtStatus.TabIndex = 4;
            // 
            // txtQuantityStock
            // 
            this.txtQuantityStock.Location = new System.Drawing.Point(436, 40);
            this.txtQuantityStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantityStock.Name = "txtQuantityStock";
            this.txtQuantityStock.Size = new System.Drawing.Size(68, 20);
            this.txtQuantityStock.TabIndex = 2;
            this.txtQuantityStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(104, 40);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(301, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(19, 40);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(68, 20);
            this.txtCode.TabIndex = 0;
            // 
            // pbImgen
            // 
            this.pbImgen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgen.Location = new System.Drawing.Point(2, 15);
            this.pbImgen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImgen.Name = "pbImgen";
            this.pbImgen.Size = new System.Drawing.Size(348, 358);
            this.pbImgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgen.TabIndex = 18;
            this.pbImgen.TabStop = false;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // dgvOptions
            // 
            this.dgvOptions.AllowUserToAddRows = false;
            this.dgvOptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtOptionId,
            this.dgvTxtOptionName,
            this.dgvTxtStatus,
            this.dgvTxtCreatedDate,
            this.ProductId,
            this.dgvTxtCreatedUser});
            this.dgvOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOptions.Location = new System.Drawing.Point(2, 15);
            this.dgvOptions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOptions.MultiSelect = false;
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.ReadOnly = true;
            this.dgvOptions.RowHeadersVisible = false;
            this.dgvOptions.RowHeadersWidth = 62;
            this.dgvOptions.RowTemplate.Height = 28;
            this.dgvOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOptions.Size = new System.Drawing.Size(609, 359);
            this.dgvOptions.TabIndex = 19;
            // 
            // dgvTxtOptionId
            // 
            this.dgvTxtOptionId.DataPropertyName = "Id";
            this.dgvTxtOptionId.HeaderText = "Id";
            this.dgvTxtOptionId.MinimumWidth = 8;
            this.dgvTxtOptionId.Name = "dgvTxtOptionId";
            this.dgvTxtOptionId.ReadOnly = true;
            this.dgvTxtOptionId.Visible = false;
            this.dgvTxtOptionId.Width = 150;
            // 
            // dgvTxtOptionName
            // 
            this.dgvTxtOptionName.DataPropertyName = "OptionName";
            this.dgvTxtOptionName.FillWeight = 74.16563F;
            this.dgvTxtOptionName.HeaderText = "Opción";
            this.dgvTxtOptionName.MinimumWidth = 8;
            this.dgvTxtOptionName.Name = "dgvTxtOptionName";
            this.dgvTxtOptionName.ReadOnly = true;
            this.dgvTxtOptionName.Width = 150;
            // 
            // dgvTxtStatus
            // 
            this.dgvTxtStatus.DataPropertyName = "Status";
            this.dgvTxtStatus.FillWeight = 93.69008F;
            this.dgvTxtStatus.HeaderText = "Estado";
            this.dgvTxtStatus.MinimumWidth = 8;
            this.dgvTxtStatus.Name = "dgvTxtStatus";
            this.dgvTxtStatus.ReadOnly = true;
            this.dgvTxtStatus.Width = 189;
            // 
            // dgvTxtCreatedDate
            // 
            this.dgvTxtCreatedDate.DataPropertyName = "CreatedDate";
            this.dgvTxtCreatedDate.FillWeight = 109.5944F;
            this.dgvTxtCreatedDate.HeaderText = "Fecha Creación";
            this.dgvTxtCreatedDate.MinimumWidth = 8;
            this.dgvTxtCreatedDate.Name = "dgvTxtCreatedDate";
            this.dgvTxtCreatedDate.ReadOnly = true;
            this.dgvTxtCreatedDate.Width = 222;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 150;
            // 
            // dgvTxtCreatedUser
            // 
            this.dgvTxtCreatedUser.DataPropertyName = "CreatedUser";
            this.dgvTxtCreatedUser.FillWeight = 122.5499F;
            this.dgvTxtCreatedUser.HeaderText = "Creado Por";
            this.dgvTxtCreatedUser.MinimumWidth = 8;
            this.dgvTxtCreatedUser.Name = "dgvTxtCreatedUser";
            this.dgvTxtCreatedUser.ReadOnly = true;
            this.dgvTxtCreatedUser.Width = 248;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOptions);
            this.groupBox2.Location = new System.Drawing.Point(9, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(613, 376);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones del Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImgen);
            this.groupBox3.Location = new System.Drawing.Point(628, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(352, 375);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen del Producto";
            // 
            // FrmCreateOrUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 574);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateOrUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Actualizar Producto";
            this.Load += new System.EventHandler(this.FrmCreateOrUpdateProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuantityStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCreatedUser;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.PictureBox pbImgen;
        private System.Windows.Forms.TextBox txtQuantityStock;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DataGridView dgvOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtOptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtOptionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtCreatedUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditOption;
        private System.Windows.Forms.Button btnDeleteOption;
    }
}