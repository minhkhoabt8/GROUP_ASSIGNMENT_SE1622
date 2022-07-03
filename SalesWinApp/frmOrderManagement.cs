using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderManagement : Form
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }
        OrderRepository orderRepository = new OrderRepository();
        private void LoadOrders()
        {
            var orders = OrderDAO.Instance.GetOrders();

            txt_OrderID.DataBindings.Clear();
            txtMemberID.DataBindings.Clear();
            txtFreight.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();

            txt_OrderID.DataBindings.Add("Text", orders, "OrderID");
            txtMemberID.DataBindings.Add("Text", orders, "MemberID");
            txtFreight.DataBindings.Add("Text", orders, "Freight");
            txtOrderDate.DataBindings.Add("Text", orders, "OrderDate");
            txtRequiredDate.DataBindings.Add("Text", orders, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", orders, "ShippedDate");

            dgv_OrderList.DataSource = orders;

            if (orders.Count > 0)
            {
                btn_DeleteOrder.Enabled = true;
            }
            else
            {
                btn_DeleteOrder.Enabled = false;
            }
        }
        private void frmOrderManagement_Load(object sender, EventArgs e) => LoadOrders();
        

        private void btn_CloseClick(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmEditOrder frmEditOrder = new frmEditOrder
            {
                Text = "Add new order",
                InsertOrUpdate = false
            };
            if (frmEditOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrders();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEditOrder frmEditOrder = new frmEditOrder
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                orderInfo = GetOrderObject()

            };
            if (frmEditOrder.ShowDialog() == DialogResult.OK)
            {
                LoadOrders();
            }
        }
        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = int.Parse(txt_OrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                orderRepository.DeleteOrder(int.Parse(txt_OrderID.Text));
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }
    }
}
