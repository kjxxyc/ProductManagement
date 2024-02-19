using ProductManagement.BL.DTOs;
using ProductManagement.BL.EntitiesBL;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace ProductManagement.GUI.Catalogs
{
    public partial class FrmCreateOrUpdateProduct : Form
    {
        #region private Fields

        private readonly ProductBL _productBL;

        private readonly SupplierBL _supplierBL;

        private ReadProductDto _readProductDto;

        private List<ReadSupplierDto> _listSupplierDto;

        private List<ReadOptionDto> _readProductOptions;

        #endregion


        #region Form Constructors

        public FrmCreateOrUpdateProduct()
        {
            InitializeComponent();

            _productBL = new ProductBL();
            _supplierBL = new SupplierBL();
            _readProductDto = new ReadProductDto();
            _listSupplierDto = new List<ReadSupplierDto>();
            _readProductOptions = new List<ReadOptionDto>();
        }

        public FrmCreateOrUpdateProduct(int productId)
        {
            InitializeComponent();

            _productBL = new ProductBL();
            _supplierBL = new SupplierBL();

            _readProductDto = new ReadProductDto();
            _readProductDto.Id = productId;

            _listSupplierDto = new List<ReadSupplierDto>();
            _readProductOptions = new List<ReadOptionDto>();
        }


        #endregion


        #region Control Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateOrUpdateProduct_Load(object sender, EventArgs e)
        {
            if (_readProductDto != null && _readProductDto.Id > 0)
            {
                LoadProduct(_readProductDto.Id);
                EnableOrDisableControls();
            }

            txtCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LoadSuppliers();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Achivos de Imagen | *.png; *.jpg; *.jpeg";

            try
            {
                if (openFileDialogImage.ShowDialog() == DialogResult.OK)
                {
                    string route = openFileDialogImage.FileName;
                    pbImgen.Image = Image.FromFile(openFileDialogImage.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            using (var frmAddOption = new FrmCreateOrUpdateOption())
            {
                frmAddOption.ShowDialog(this);
                var createOrUpdateOption = frmAddOption.GetProductOption(); //Obtener la Opcion luego de cerrado el formulario..

                //TODO: Validar Opción antes de agregarla...

                if (createOrUpdateOption != null)
                {
                    //Add Option to our internal list...
                    var readOption = new ReadOptionDto()
                    {
                        Id = createOrUpdateOption.Id,
                        OptionName = createOrUpdateOption.OptionName,
                        Status = createOrUpdateOption.Status,
                        ProductId = createOrUpdateOption.ProductId,
                        CreatedDate = createOrUpdateOption.CreatedDate.ToString("dd/MM/yyyy - hh:mm:ss tt"),
                        CreatedUserId = createOrUpdateOption.CreatedUserId,
                        CreatedUserName = "-"
                    };

                    _readProductOptions.Add(readOption);


                    //Also add Option to grid to show it graphically to the user...
                    dgvOptions.Rows.Add(createOrUpdateOption.Id,
                                        createOrUpdateOption.OptionName,
                                        createOrUpdateOption.Status,
                                        createOrUpdateOption.CreatedDate,
                                        createOrUpdateOption.CreatedUserId,
                                        createOrUpdateOption.ProductId);

                    //Resize grid to adjust to new rows content...
                    dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOptions.AutoResizeColumns();
                }
            }
        }

        private void btnEditOption_Click(object sender, EventArgs e)
        {
            if (dgvOptions.RowCount > 0)
            {
                var optionId = Convert.ToInt32(dgvOptions.CurrentRow.Cells["dgvTxtOptionId"].Value);
                var selectedRow = dgvOptions.CurrentRow;

                using (var frmAddOption = new FrmCreateOrUpdateOption(optionId))
                {
                    frmAddOption.ShowDialog(this);
                    var createOrUpdateOption = frmAddOption.GetProductOption(); //Obtener la Opcion luego de cerrado el formulario..

                    if (createOrUpdateOption != null)
                    {
                        //Add Option to our internal list...
                        var readOption = new ReadOptionDto()
                        {
                            Id = createOrUpdateOption.Id,
                            OptionName = createOrUpdateOption.OptionName,
                            Status = createOrUpdateOption.Status,
                            ProductId = createOrUpdateOption.ProductId,
                            CreatedDate = createOrUpdateOption.CreatedDate.ToString("dd/MM/yyyy - hh:mm:ss tt"),
                            CreatedUserId = createOrUpdateOption.CreatedUserId,
                            CreatedUserName = "-"
                        };

                        _readProductOptions.Add(readOption);

                        //Also Update Option to grid to show it graphically to the user...
                        selectedRow.Cells[0].Value = createOrUpdateOption.Id;
                        selectedRow.Cells[1].Value = createOrUpdateOption.OptionName;
                        selectedRow.Cells[2].Value = createOrUpdateOption.Status;
                        selectedRow.Cells[3].Value = createOrUpdateOption.CreatedDate;
                        selectedRow.Cells[4].Value = createOrUpdateOption.CreatedUserId;
                        selectedRow.Cells[5].Value = createOrUpdateOption.ProductId;

                        //Resize grid to adjust to new rows content...
                        dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvOptions.AutoResizeColumns();
                    }
                }
            }
        }

        private void btnDeleteOption_Click(object sender, EventArgs e)
        {
            if (dgvOptions.RowCount > 0)
            {
                var optionId = Convert.ToInt32(dgvOptions.CurrentRow.Cells["dgvTxtOptionId"].Value);
                var readOption = _readProductOptions.FirstOrDefault(x => x.Id == optionId);    
                var selectedRow = dgvOptions.CurrentRow;

                //Remove option from list...
                _readProductOptions.Remove(readOption);

                //Remove options from grid...
                dgvOptions.Rows.Remove(selectedRow);        

                //Resize grid to adjust to new rows content...
                dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOptions.AutoResizeColumns();
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (_readProductDto.Id > 0) //An update...
            {
                UpdateProduct();
            }
            else //A create...
            {
                CreateProduct();
            }
        }


        #endregion


        #region Private Functions

        private void CreateProduct()
        {
            // Assignment.
            var createProductDto = new CreateProductDto();
            createProductDto.CodeProduct = txtCode.Text;
            createProductDto.ProductName = txtProductName.Text;
            createProductDto.QuantityStock = Decimal.Parse(txtQuantityStock.Text);
            createProductDto.ImageProduct = ConvertImageToByteArray(pbImgen.Image);
            createProductDto.SupplierId = (int)cmbSupplier.SelectedValue;
            createProductDto.CreatedUserId = 1;
            createProductDto.Status = "AC";
            createProductDto.CreatedDate = DateTime.Now;

            //Add Product Options...
            createProductDto.Options = GetCreateOrUpdateOptionsList();

            // Implementation Business Logic.
            var result = _productBL.Create(createProductDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();

                // Assignment to load the record
                _readProductDto = result.Result as ReadProductDto;

                // Reload the registry.
                LoadProduct(_readProductDto.Id);
                EnableOrDisableControls();
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct()
        {
            // Assignment.
            var updateProductDto = new UpdateProductDto();

            updateProductDto.Id = _readProductDto.Id;
            updateProductDto.ProductName = txtProductName.Text;
            updateProductDto.QuantityStock = decimal.Parse(txtQuantityStock.Text);
            updateProductDto.ImageProduct = ConvertImageToByteArray(pbImgen.Image);

            //Add Product Options...
            updateProductDto.Options = GetCreateOrUpdateOptionsList();

            // Implementation Business Logic.
            var result = _productBL.Update(updateProductDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();
                _readProductDto = result.Result as ReadProductDto;
                LoadProduct(_readProductDto.Id);
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            _listSupplierDto = new List<ReadSupplierDto>();

            var result = _supplierBL.GetListSupplier();

            _listSupplierDto = result.Result as List<ReadSupplierDto>;

            if (result.Success)
            {
                _listSupplierDto.ForEach(x => x.SupplierName = x.Id + " | " + x.SupplierName);
                cmbSupplier.DataSource = _listSupplierDto;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
            }
        }

        private void LoadProduct(int productId)
        {
            if (productId > 0)
            {
                var result = _productBL.FindById(productId);

                if (result.Success)
                {
                    _readProductDto = result.Result as ReadProductDto;
                    _readProductOptions = _readProductDto.Options;
                    SetProperties(_readProductDto);
                }
                else
                {
                    MessageBox.Show(result.Message, "Cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetProperties(ReadProductDto readProductDto)
        {
            // Clean Form.
            txtCode.Text = readProductDto.CodeProduct;
            txtProductName.Text = readProductDto.ProductName;
            txtQuantityStock.Text = readProductDto.QuantityStock.ToString();
            pbImgen.Image = ConvertByteArrayToImage(readProductDto.ImageProduct);
            txtStatus.Text = readProductDto.Status;

            //Load options to grid...
            LoadOptionsToGrid();
        }

        private void EnableOrDisableControls()
        {
            if (_readProductDto.Id > 0)
            {
                txtCode.Enabled = false;
            }
            else
            {
                txtCode.Enabled = true;
            }
        }

        private void CleanControls()
        {
            // Clean Form.
            txtCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtQuantityStock.Text = string.Empty;
            pbImgen.Image = null;
            //txtSupplier.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private List<CreateOrUpdateOptionDto> GetCreateOrUpdateOptionsList()
        {
            var listResult = new List<CreateOrUpdateOptionDto>();

            foreach (var readOption in _readProductOptions)
            {
                //Add Option to our internal list...
                var createUptateOption = new CreateOrUpdateOptionDto()
                {
                    Id = readOption.Id,
                    OptionName = readOption.OptionName,
                    Status = readOption.Status,
                    ProductId = readOption.ProductId,
                    CreatedUserId = readOption.CreatedUserId,
                };

                listResult.Add(createUptateOption);
            }

            return listResult;
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (var stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return stream.ToArray();
            }
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            using (var stream = new MemoryStream(byteArray))
            {
                return Image.FromStream(stream);
            }
        }


        private void LoadOptionsToGrid() 
        {
            dgvOptions.Rows.Clear();

            foreach (var option in _readProductOptions)
            {
                //Also add Option to grid to show it graphically to the user...
                dgvOptions.Rows.Add(option.Id,
                                   option.OptionName,
                                   option.Status,
                                   option.CreatedDate,
                                   option.CreatedUserId,
                                   option.ProductId);

                //Resize grid to adjust to new rows content...
                dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOptions.AutoResizeColumns();
            }
        }

        #endregion

    }
}
