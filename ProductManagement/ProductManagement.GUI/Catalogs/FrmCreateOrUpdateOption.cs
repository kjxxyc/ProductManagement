using ProductManagement.BL.DTOs;
using ProductManagement.BL.EntitiesBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement.GUI.Catalogs
{
    public partial class FrmCreateOrUpdateOption : Form
    {
        private readonly OptionBL optionBL;

        public FrmCreateOrUpdateOption()
        {
            InitializeComponent();
            optionBL = new OptionBL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Assignament.
            var createOptionDto = new CreateOptionDto();

            createOptionDto.OptionName = txtOptionName.Text;
            createOptionDto.Status = "AC";
            createOptionDto.CreatedDate = DateTime.Now;

            // Implement Business Logic.
            var result = optionBL.Create(createOptionDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                txtOptionName.Text = null;
                txtStatus.Text = null;
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateOrUpdateOption_Load(object sender, EventArgs e)
        {
            txtCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
