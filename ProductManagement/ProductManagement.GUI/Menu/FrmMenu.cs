using ProductManagement.GUI.Catalogs;
using ProductManagement.GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.GUI.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            var frm = new FrmLogin();
            frm.ShowDialog(this);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmProducts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call to the user registration screen.
            FrmCreateOrUpdateUser frmCreateOrUpdateUser = new FrmCreateOrUpdateUser();

            frmCreateOrUpdateUser.ShowDialog();
        }
    }
}
