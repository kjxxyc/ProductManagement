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
    public partial class FrmProducts : Form
    {
        private readonly ProductBL productBL;

        private ReadProductDto readProductDto = new ReadProductDto();

        private List<ReadProductDto> ListProducts = new List<ReadProductDto>();

        public FrmProducts()
        {
            InitializeComponent();
            productBL = new ProductBL();  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListProducts = new List<ReadProductDto>();

            var result = productBL.GetListProductsWithFilter(txtSearch.Text.ToString(), string.Empty);

            if (result.Success)
            {
                ListProducts = result.Result as List<ReadProductDto>;
                LoadGrid(ListProducts);
            }
            else
            {
                MessageBox.Show(result.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void LoadGrid(List<ReadProductDto> list)
        {
            int num = 0;
            dgvProducts.Rows.Clear();

            foreach (var product in list)
            {
                num++;
                dgvProducts.Rows.Add(
                    product.Id,
                    num,
                    product.CodeProduct,
                    product.ProductName,
                    product.QuantityStock,
                    product.Status,
                    product.CreatedDate
                    );
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Call create product.
            FrmCreateOrUpdateProduct frmCreateOrUpdateProduct = new FrmCreateOrUpdateProduct();

            frmCreateOrUpdateProduct.ShowDialog();
            
        }

        private void btnStatusAC_Click(object sender, EventArgs e)
        {
            ListProducts = new List<ReadProductDto>();

            var result = productBL.GetListProductsWithFilter(txtSearch.Text.ToString(), "AC");

            if (result.Success)
            {
                ListProducts = result.Result as List<ReadProductDto>;
                LoadGrid(ListProducts);
            }
            else
            {
                MessageBox.Show(result.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStatusIN_Click(object sender, EventArgs e)
        {
            ListProducts = new List<ReadProductDto>();

            var result = productBL.GetListProductsWithFilter(txtSearch.Text.ToString(), "IN");

            if (result.Success)
            {
                ListProducts = result.Result as List<ReadProductDto>;
                LoadGrid(ListProducts);
            }
            else
            {
                MessageBox.Show(result.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProducts.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            //var currentIndex = selectedRow.Index;

            if (selectedRow != null)
            {
                int id = (int)selectedRow.Cells["Id"].Value;
                var product = productBL.FindById(id);

                if (product != null)
                {
                    var frm = new FrmCreateOrUpdateProduct(id);
                    frm.ShowDialog(owner: this);
                }
            }
            else
            {
                MessageBox.Show("Debe haber un registro seleccionado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            ListProducts = new List<ReadProductDto>();

            var result = productBL.GetListProductsWithFilter(string.Empty, string.Empty);

            if (result.Success)
            {
                ListProducts = result.Result as List<ReadProductDto>;
                LoadGrid(ListProducts);
            }
            else
            {
                MessageBox.Show(result.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
