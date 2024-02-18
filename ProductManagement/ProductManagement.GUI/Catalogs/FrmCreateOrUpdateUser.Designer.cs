namespace ProductManagement.GUI.Catalogs
{
    partial class FrmCreateOrUpdateUser
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(256, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(26, 150);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(590, 78);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(150, 26);
            this.txtStatus.TabIndex = 7;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(594, 150);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(150, 26);
            this.txtCreatedDate.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(256, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 20);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Apellido";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(26, 127);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(193, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 20);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Correo Electronico";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(352, 197);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(71, 20);
            this.lblTelephone.TabIndex = 13;
            this.lblTelephone.Text = "Telefono";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(590, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Estado";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(594, 127);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(140, 20);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "Fecha de Registro";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(531, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 44);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(687, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 44);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(356, 150);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(150, 26);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(352, 127);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(165, 20);
            this.lblConfirmPassword.TabIndex = 19;
            this.lblConfirmPassword.Text = "Confirmar Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblConfirmPassword);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCreatedDate);
            this.groupBox1.Controls.Add(this.lblCreatedDate);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblTelephone);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 275);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARIO";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(356, 220);
            this.txtTelephone.Mask = "0000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(150, 26);
            this.txtTelephone.TabIndex = 6;
            this.txtTelephone.ValidatingType = typeof(int);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(382, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 44);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmCreateOrUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 394);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmCreateOrUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.FrmCreateOrUpdateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.Button btnDelete;
    }
}