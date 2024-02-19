using ProductManagement.BL.DTOs;
using ProductManagement.BL.EntitiesBL;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProductManagement.GUI.Catalogs
{
    public partial class FrmCreateOrUpdateOption : Form
    {
        private CreateOrUpdateOptionDto _createOrUpdateOption;

        private OptionBL _optionBL;

        private ReadOptionDto _readOptionDto;

        public FrmCreateOrUpdateOption()
        {
            InitializeComponent();
            LoadStatus();
            _optionBL = new OptionBL();
        }

        public FrmCreateOrUpdateOption(int optionId)
        {
            InitializeComponent();
            LoadStatus();
            _readOptionDto = new ReadOptionDto() { Id = optionId };
            _optionBL = new OptionBL();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateOrUpdateOption_Load(object sender, EventArgs e)
        {
            if (_readOptionDto != null && _readOptionDto.Id > 0)
            {
                LoadOption(_readOptionDto.Id);
                EnableOrDisableControls();
            }

            txtCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void AddOption()
        {
            //Check Action...
            if (_readOptionDto != null && _readOptionDto.Id > 0) //It's Update...
            {
                _createOrUpdateOption = new CreateOrUpdateOptionDto
                {
                    Id = _readOptionDto.Id,
                    OptionName = txtOptionName.Text,
                    Status = cmbStatus.SelectedValue.ToString(),
                    ProductId = _readOptionDto.ProductId,
                    CreatedUserId = _readOptionDto.CreatedUserId
                };
            }
            else //it's a Create...
            {
                _createOrUpdateOption = new CreateOrUpdateOptionDto
                {
                    OptionName = txtOptionName.Text,
                    Status = cmbStatus.SelectedValue.ToString(),
                    CreatedDate = DateTime.Now,
                    CreatedUserId = 1,
                };
            }

            // Evaluation of the result.
            Close();
        }

        private void LoadOption(int optionId)
        {
            if (optionId > 0)
            {
                var result = _optionBL.FindById(optionId);

                if (result.Success)
                {
                    _readOptionDto = result.Result as ReadOptionDto;
                    SetProperties(_readOptionDto);
                }
                else
                {
                    MessageBox.Show(result.Message, "Cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnableOrDisableControls()
        {
            if (_readOptionDto.Id > 0)
            {
                cmbStatus.Enabled = false;
            }
            else
            {
                cmbStatus.Enabled = true;
            }
        }

        private void SetProperties(ReadOptionDto readOptionDto)
        {
            txtOptionName.Text = readOptionDto.OptionName;
            txtCreatedDate.Text = DateTime.Now.ToString();
            txtCreatedUser.Text = readOptionDto.Id.ToString();
            cmbStatus.SelectedValue = readOptionDto.Status;
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            AddOption();
        }

        public CreateOrUpdateOptionDto GetProductOption()
        {
            return _createOrUpdateOption;
        }


        private void LoadStatus()
        {
            var status = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("AC", "Activo"),
                new KeyValuePair<string, string>("IN", "Inactivo")
            };

            cmbStatus.DataSource = status;
            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";
        }
    }
}
