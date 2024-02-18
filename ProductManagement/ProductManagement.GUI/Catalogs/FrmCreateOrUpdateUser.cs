using ProductManagement.BL.DTOs;
using ProductManagement.BL.EntitiesBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.GUI.Catalogs
{
    public partial class FrmCreateOrUpdateUser : Form
    {
        private readonly UserBL userBL;

        private ReadUserDto readUserDto = new ReadUserDto();

        public FrmCreateOrUpdateUser()
        {
            InitializeComponent();
            userBL = new UserBL();
            readUserDto.Id = 0;
        }

        public FrmCreateOrUpdateUser(int userId)
        {
            InitializeComponent();
            userBL = new UserBL();
            readUserDto.Id = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (readUserDto.Id > 0) 
            {
                // Modify User
                UpdateUser();
            }
            else 
            {
                // Add User
                CreateUser();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateOrUpdateUser_Load(object sender, EventArgs e)
        {
            if (readUserDto.Id > 0)
            {
                LoadUser(readUserDto.Id);
                EnableOrDisableControls();
            }
 
            txtCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(readUserDto.Id > 0)
            {
                var answer = MessageBox.Show("Eliminar Registro ¿Desaea continuar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(answer  == DialogResult.OK)
                {
                    DeleteUser();
                }
            }
        }

        private void LoadUser(int userId)
        {
            if (userId > 0)
            {
                var result = userBL.FindById(userId);

                if (result.Success)
                {
                    readUserDto = result.Result as ReadUserDto;
                    SetProperties(readUserDto);
                }
                else
                {
                    MessageBox.Show(result.Message, "Cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetProperties(ReadUserDto readUserDto)
        {
            txtName.Text = readUserDto.Name;
            txtUserName.Text = readUserDto.UserName;
            txtLastName.Text = readUserDto.LastName;
            txtTelephone.Text = readUserDto.Telephone;
            txtEmail.Text = readUserDto.Email;
            txtStatus.Text = readUserDto.Status; // TODO: AC- IN
        }

        private void EnableOrDisableControls()
        {
            if (readUserDto.Id > 0)
            {
                txtUserName.Enabled = false;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                txtEmail.Enabled = true;
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
        }

        private void CleanControls()
        {
            // Clean Form.
            txtName.Text = string.Empty; 
            txtLastName.Text = string.Empty; 
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty; 
            txtConfirmPassword.Text = string.Empty;
            txtTelephone.Text = string.Empty; 
            txtEmail.Text = string.Empty; 
            txtStatus.Text = string.Empty; 
        }

        private void CreateUser()
        {
            // Assignment.
            var createUserDto = new CreateUserDto();

            createUserDto.Name = txtName.Text;
            createUserDto.LastName = txtLastName.Text;
            createUserDto.UserName = txtUserName.Text;
            createUserDto.Password = txtPassword.Text;
            createUserDto.ConfirmPassword = txtConfirmPassword.Text;
            createUserDto.Telephone = txtTelephone.Text.Replace("-", "");
            createUserDto.Email = txtEmail.Text;
            createUserDto.Status = "AC";
            createUserDto.CreatedDate = DateTime.Now;

            // Implementation Business Logic.
            var result = userBL.Create(createUserDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();

                // Assignment to load the record
                readUserDto = result.Result as ReadUserDto;

                // Reload the registry.
                LoadUser(readUserDto.Id);
                EnableOrDisableControls();
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            // Assignment.
            var updateUserDto = new UpdateUserDto();            

            updateUserDto.Id = readUserDto.Id;
            updateUserDto.Name = txtName.Text;
            updateUserDto.LastName = txtLastName.Text;
            updateUserDto.Telephone = txtTelephone.Text.Replace("-", "");

            // Implementation Business Logic.
            var result = userBL.Update(updateUserDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();
                readUserDto = result.Result as ReadUserDto;
                LoadUser(readUserDto.Id);
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteUser()
        {
            var result = userBL.Delete(readUserDto.Id);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();

                readUserDto = new ReadUserDto();
            }
            else
            {
                MessageBox.Show(result.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
