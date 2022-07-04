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
    public partial class frmOrderDetailManagement : Form
    {
        public frmOrderDetailManagement()
        {
            InitializeComponent();
        }
        IOrderDetailRepository orderDetailRepo = new OrderDetailRepository();

        private void frmOrderDetailManagement_Load(object sender, EventArgs e)
        {
            try
            {

                var ordersDetail = orderDetailRepo.GetOrderDetails();
                txt_OrderID.DataBindings.Clear();
                txt_ProductID.DataBindings.Clear();
                txt_UnitPrice.DataBindings.Clear();
                txt_Quantity.DataBindings.Clear();
                txt_Discount.DataBindings.Clear();
                

                txt_OrderID.DataBindings.Add("Text", ordersDetail, "OrderID");
                txt_ProductID.DataBindings.Add("Text", ordersDetail, "ProductID");
                txt_UnitPrice.DataBindings.Add("Text", ordersDetail, "UnitPrice");
                txt_Quantity.DataBindings.Add("Text", ordersDetail, "Quantity");
                txt_Discount.DataBindings.Add("Text", ordersDetail, "Discount");
               
                dgv_OrderDetailList.DataSource = null;
                dgv_OrderDetailList.DataSource = ordersDetail;
                if (ordersDetail.Any())
                {
                    btn_DeleteDetail.Enabled = true;
                    btn_UpdateDetail.Enabled = true;
                }
                else
                {

                    btn_DeleteDetail.Enabled = false;
                    btn_UpdateDetail.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddNewDetails_Click(object sender, EventArgs e)
        {
            frmEditOrderDetail frmEditOrder = new frmEditOrderDetail
            {
                Text = "Add new order",
                InsertOrUpdate = false
            };
            if (frmEditOrder.ShowDialog() == DialogResult.OK)
            {
                try { 
                var ordersDetail = orderDetailRepo.GetOrderDetails();
                txt_OrderID.DataBindings.Clear();
                txt_ProductID.DataBindings.Clear();
                txt_UnitPrice.DataBindings.Clear();
                txt_Quantity.DataBindings.Clear();
                txt_Discount.DataBindings.Clear();


                txt_OrderID.DataBindings.Add("Text", ordersDetail, "OrderID");
                txt_ProductID.DataBindings.Add("Text", ordersDetail, "ProductID");
                txt_UnitPrice.DataBindings.Add("Text", ordersDetail, "UnitPrice");
                txt_Quantity.DataBindings.Add("Text", ordersDetail, "Quantity");
                txt_Discount.DataBindings.Add("Text", ordersDetail, "Discount");

                dgv_OrderDetailList.DataSource = null;
                dgv_OrderDetailList.DataSource = ordersDetail;
                if (ordersDetail.Any())
                {
                    btn_DeleteDetail.Enabled = true;
                    btn_UpdateDetail.Enabled = true;
                }
                else
                {

                    btn_DeleteDetail.Enabled = false;
                    btn_UpdateDetail.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }

        private void btn_UpdateDetail_Click(object sender, EventArgs e)
        {
            frmEditOrderDetail frmEditOrderDetail = new frmEditOrderDetail
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                orderInfo = GetOrderObject()

            };
            if (frmEditOrderDetail.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var ordersDetail = orderDetailRepo.GetOrderDetails();
                    txt_OrderID.DataBindings.Clear();
                    txt_ProductID.DataBindings.Clear();
                    txt_UnitPrice.DataBindings.Clear();
                    txt_Quantity.DataBindings.Clear();
                    txt_Discount.DataBindings.Clear();


                    txt_OrderID.DataBindings.Add("Text", ordersDetail, "OrderID");
                    txt_ProductID.DataBindings.Add("Text", ordersDetail, "ProductID");
                    txt_UnitPrice.DataBindings.Add("Text", ordersDetail, "UnitPrice");
                    txt_Quantity.DataBindings.Add("Text", ordersDetail, "Quantity");
                    txt_Discount.DataBindings.Add("Text", ordersDetail, "Discount");

                    dgv_OrderDetailList.DataSource = null;
                    dgv_OrderDetailList.DataSource = ordersDetail;
                    if (ordersDetail.Any())
                    {
                        btn_DeleteDetail.Enabled = true;
                        btn_UpdateDetail.Enabled = true;
                    }
                    else
                    {

                        btn_DeleteDetail.Enabled = false;
                        btn_UpdateDetail.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private OrderDetail GetOrderObject()
        {
            OrderDetail order = null;
            try
            {
                order = new OrderDetail
                {
                    OrderId = int.Parse(txt_OrderID.Text),
                    ProductId = int.Parse(txt_ProductID.Text),
                    UnitPrice = decimal.Parse(txt_UnitPrice.Text),
                    Quantity = int.Parse(txt_Quantity.Text),
                    Discount = double.Parse(txt_Discount.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }
            
         private void btn_DeleteDetail_Click(object sender, EventArgs e)
         {
            try
            {
                orderDetailRepo.DeleteOrderDetail(int.Parse(txt_OrderID.Text), int.Parse(txt_ProductID.Text));
                //load order details
                try
                {
                    var ordersDetail = orderDetailRepo.GetOrderDetails();
                    txt_OrderID.DataBindings.Clear();
                    txt_ProductID.DataBindings.Clear();
                    txt_UnitPrice.DataBindings.Clear();
                    txt_Quantity.DataBindings.Clear();
                    txt_Discount.DataBindings.Clear();


                    txt_OrderID.DataBindings.Add("Text", ordersDetail, "OrderID");
                    txt_ProductID.DataBindings.Add("Text", ordersDetail, "ProductID");
                    txt_UnitPrice.DataBindings.Add("Text", ordersDetail, "UnitPrice");
                    txt_Quantity.DataBindings.Add("Text", ordersDetail, "Quantity");
                    txt_Discount.DataBindings.Add("Text", ordersDetail, "Discount");

                    dgv_OrderDetailList.DataSource = null;
                    dgv_OrderDetailList.DataSource = ordersDetail;
                    if (ordersDetail.Any())
                    {
                        btn_DeleteDetail.Enabled = true;
                        btn_UpdateDetail.Enabled = true;
                    }
                    else
                    {

                        btn_DeleteDetail.Enabled = false;
                        btn_UpdateDetail.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
