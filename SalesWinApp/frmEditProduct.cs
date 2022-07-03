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
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }
        private static IProductRepository productRepository = new ProductRepository();
        public bool InsertOrUpdate { get; set; }

        public Product productInfo { get; set; }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = true;
                if (txt_CategoryID.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderCategoryID.SetError(txt_CategoryID, "Please input the category id!");
                }
                else
                {
                    errorProviderCategoryID.SetError(txt_CategoryID, "");
                }
                if (txt_ProductName.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderProductName.SetError(txt_ProductName, "Please input the product name!");
                }
                else
                {
                    errorProviderProductName.SetError(txt_ProductName, "");
                }
                if (txt_Weight.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderWeight.SetError(txt_Weight, "Please input the weight!");
                }
                else
                {
                    errorProviderWeight.SetError(txt_Weight, "");
                }
                if (txt_UnitPrice.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderUnitPrice.SetError(txt_UnitPrice, "Please input the unit price!");
                }
                else
                {
                    errorProviderUnitPrice.SetError(txt_UnitPrice, "");
                }
                if (txt_UnitsInStock.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderUnitsInStock.SetError(txt_UnitsInStock, "Please input the unit in stock!");
                }
                else
                {
                    errorProviderUnitsInStock.SetError(txt_UnitsInStock, "");
                }
                if (validation)
                {
                    var product = new Product
                    {
                        CategoryId = int.Parse(txt_CategoryID.Text),
                        ProductName = txt_ProductName.Text,
                        Weight = txt_Weight.Text,
                        UnitPrice = decimal.Parse(txt_UnitPrice.Text),
                        UnitInStock = int.Parse(txt_UnitsInStock.Text),
                    };
                    if (InsertOrUpdate == false)
                    {
                        productRepository.AddNewProduct(product);
                    }
                    else
                    {
                        product.ProductId = int.Parse(txt_ProductID.Text);
                        productRepository.UpdateProduct(product);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new product" : "Update product");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) => Close();

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txt_ProductID.Text = productInfo.ProductId.ToString();
                txt_CategoryID.Text = productInfo.CategoryId.ToString();
                txt_ProductName.Text = productInfo.ProductName;
                txt_Weight.Text = productInfo.Weight;
                txt_UnitPrice.Text = productInfo.UnitPrice.ToString();
                txt_UnitsInStock.Text = productInfo.UnitInStock.ToString();
            }
            else
            {
                var count = productRepository.GetProducts().Count();
                if (count > 0)
                {
                    var id = productRepository.GetProducts().Max(c => c.ProductId) + 1;
                    txt_ProductID.Text = id.ToString();
                }
                else
                {
                    txt_ProductID.Text = "Randomly Generate";
                }  
            }
        }
    }
}
