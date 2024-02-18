using ProductManagement.BL.EntitiesBL;
using ProductManagement.GUI.Catalogs;
using ProductManagement.GUI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.GUI.Login
{
    public partial class FrmLogin : Form
    {
        // Instances
        private readonly UserBL userBL;

        FrmMenu frmMenu = new FrmMenu();

        public FrmLogin()
        {
            InitializeComponent();
            userBL = new UserBL();
            frmMenu = new FrmMenu();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Call to the user registration screen.
            FrmCreateOrUpdateUser frmCreateOrUpdateUser = new FrmCreateOrUpdateUser();
            
            frmCreateOrUpdateUser.ShowDialog();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate credentials with BL
            var result = userBL.ValidateLogin(txtUserName.Text.ToString(), txtPassword.Text.ToString());

            // Evaluation of the result.
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Close();
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
