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

namespace ProductManagement.GUI.Catalogs
{
    public partial class FrmCreateOrUpdateProduct : Form
    {
        private readonly ProductBL productBL;

        private readonly SupplierBL supplierBL;

        private ReadProductDto readProductDto = new ReadProductDto();

        private ReadSupplierDto readSupplierDto = new ReadSupplierDto();

        private List<ReadSupplierDto> ListSupplierDto = new List<ReadSupplierDto>();

        public FrmCreateOrUpdateProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
            supplierBL = new SupplierBL();
            readProductDto.Id = 0;
        }

        public FrmCreateOrUpdateProduct(int productId)
        {
            InitializeComponent();
            productBL = new ProductBL();
            supplierBL = new SupplierBL();
            readProductDto.Id = productId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (readProductDto.Id > 0)
            {
                // Modify Product
                UpdateProduct();
            }
            else
            {
                // Add Product
                CreateProduct();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateOrUpdateProduct_Load(object sender, EventArgs e)
        {
            if (readProductDto.Id > 0)
            {
                LoadProduct(readProductDto.Id);
                EnableOrDisableControls();
            }

            txtCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LoadSuppliers();
        }

        private void LoadProduct(int productId)
        {
            if (productId > 0)
            {
                var result = productBL.FindById(productId);

                if (result.Success)
                {
                    readProductDto = result.Result as ReadProductDto;
                    SetProperties(readProductDto);
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
        }

        private void EnableOrDisableControls()
        {
            if (readProductDto.Id > 0)
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
                        

            // Implementation Business Logic.
            var result = productBL.Create(createProductDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();

                // Assignment to load the record
                readProductDto = result.Result as ReadProductDto;

                // Reload the registry.
                LoadProduct(readProductDto.Id);
                EnableOrDisableControls();
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Achivos de Imagen | *.png; *.jpg; *.jpeg";

            try
            {
                if(openFileDialogImage.ShowDialog() == DialogResult.OK) 
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
               
        private void UpdateProduct()
        {
            // Assignment.
            var updateProductDto = new UpdateProductDto();
            
            updateProductDto.Id = readProductDto.Id;
            updateProductDto.ProductName = txtProductName.Text;
            updateProductDto.QuantityStock = decimal.Parse(txtQuantityStock.Text);
            updateProductDto.ImageProduct = ConvertImageToByteArray(pbImgen.Image);

            // Implementation Business Logic.
            var result = productBL.Update(updateProductDto);

            // Evaluation of the result.
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clean Form.
                CleanControls();
                readProductDto = result.Result as ReadProductDto;
                LoadProduct(readProductDto.Id);
            }
            else
            {
                MessageBox.Show(result.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            ListSupplierDto = new List<ReadSupplierDto>();

            var result = supplierBL.GetListSupplier();

            ListSupplierDto = result.Result as List<ReadSupplierDto>;

            if (result.Success)
            {               
                ListSupplierDto.ForEach(x => x.SupplierName = x.Id +" | "+ x.SupplierName);
                cmbSupplier.DataSource = ListSupplierDto;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "Id";
            }
        }
    }
}
