using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();
        }

        ProductRepository productRepository = new ProductRepository();

        private void LoadProducts()
        {
            var products = ProductDAO.Instance.GetProducts();

            txtProductID.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text",  products, "ProductID");
            txtCategoryID.DataBindings.Add("Text", products, "CategoryID");
            txtProductName.DataBindings.Add("Text", products, "ProductName");
            txtWeight.DataBindings.Add("Text", products, "Weight");
            txtUnitPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", products, "UnitInStock");

            dgv_ProductList.DataSource = products;

            if(products.Count > 0)
            {
                btn_DeleteProduct.Enabled = true;
            }
            else
            {
                btn_DeleteProduct.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmEditProduct frmEditProduct = new frmEditProduct
            {
                Text = "Add new product",
                InsertOrUpdate = false
            };
            if (frmEditProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void frmProductManagement_Load(object sender, EventArgs e) => LoadProducts();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productRepository.DeleteProduct(int.Parse(txtProductID.Text));
                LoadProducts();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEditProduct frmEditProduct = new frmEditProduct
            {
                Text = "Update product",
                InsertOrUpdate = true,
                productInfo = GetProductObject()
            };
            if (frmEditProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }//end btnUpdate_Click

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitsInStock.Text)
                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return product;
        }
    }
}
