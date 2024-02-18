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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbImgen = new System.Windows.Forms.PictureBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblImageProduct = new System.Windows.Forms.Label();
            this.lblQuantityStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCreatedUser = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtQuantityStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnLoadImage);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.pbImgen);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.lblCreatedUser);
            this.groupBox1.Controls.Add(this.lblCreatedDate);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblImageProduct);
            this.groupBox1.Controls.Add(this.lblQuantityStock);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.txtCreatedUser);
            this.groupBox1.Controls.Add(this.txtCreatedDate);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtQuantityStock);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTO";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(651, 149);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(147, 28);
            this.cmbSupplier.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(570, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(328, 103);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(150, 40);
            this.btnLoadImage.TabIndex = 19;
            this.btnLoadImage.Text = "Cargar Imagen";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(698, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbImgen
            // 
            this.pbImgen.Location = new System.Drawing.Point(28, 149);
            this.pbImgen.Name = "pbImgen";
            this.pbImgen.Size = new System.Drawing.Size(450, 206);
            this.pbImgen.TabIndex = 18;
            this.pbImgen.TabStop = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(655, 121);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(81, 20);
            this.lblSupplier.TabIndex = 16;
            this.lblSupplier.Text = "Proveedor";
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Location = new System.Drawing.Point(655, 192);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(131, 20);
            this.lblCreatedUser.TabIndex = 15;
            this.lblCreatedUser.Text = "Usuario Creación";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(502, 192);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(143, 20);
            this.lblCreatedDate.TabIndex = 14;
            this.lblCreatedDate.Text = "Fecha de Creación";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(506, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Estado";
            // 
            // lblImageProduct
            // 
            this.lblImageProduct.AutoSize = true;
            this.lblImageProduct.Location = new System.Drawing.Point(6, 121);
            this.lblImageProduct.Name = "lblImageProduct";
            this.lblImageProduct.Size = new System.Drawing.Size(156, 20);
            this.lblImageProduct.TabIndex = 12;
            this.lblImageProduct.Text = "Imagen del Producto";
            // 
            // lblQuantityStock
            // 
            this.lblQuantityStock.AutoSize = true;
            this.lblQuantityStock.Location = new System.Drawing.Point(655, 35);
            this.lblQuantityStock.Name = "lblQuantityStock";
            this.lblQuantityStock.Size = new System.Drawing.Size(81, 20);
            this.lblQuantityStock.TabIndex = 11;
            this.lblQuantityStock.Text = "Existencia";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(156, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(158, 20);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Nombre del Producto";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(28, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 20);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Código";
            // 
            // txtCreatedUser
            // 
            this.txtCreatedUser.Location = new System.Drawing.Point(655, 220);
            this.txtCreatedUser.Name = "txtCreatedUser";
            this.txtCreatedUser.ReadOnly = true;
            this.txtCreatedUser.Size = new System.Drawing.Size(100, 26);
            this.txtCreatedUser.TabIndex = 6;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(502, 220);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(100, 26);
            this.txtCreatedDate.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(506, 149);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 26);
            this.txtStatus.TabIndex = 4;
            // 
            // txtQuantityStock
            // 
            this.txtQuantityStock.Location = new System.Drawing.Point(655, 61);
            this.txtQuantityStock.Name = "txtQuantityStock";
            this.txtQuantityStock.Size = new System.Drawing.Size(100, 26);
            this.txtQuantityStock.TabIndex = 2;
            this.txtQuantityStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(156, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(450, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(28, 61);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 26);
            this.txtCode.TabIndex = 0;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // FrmCreateOrUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCreateOrUpdateProduct";
            this.Text = "PRODUCTO";
            this.Load += new System.EventHandler(this.FrmCreateOrUpdateProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblImageProduct;
        private System.Windows.Forms.Label lblQuantityStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCreatedUser;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pbImgen;
        private System.Windows.Forms.TextBox txtQuantityStock;
        private System.Windows.Forms.ComboBox cmbSupplier;
    }
}