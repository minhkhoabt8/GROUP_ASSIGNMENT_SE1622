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
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        public OrderDetailRepository OrderDetailRepo { get; set; }
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public int OrderID { get; set; }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            MessageBox.Show(""+OrderID);
            var orderDetails = orderDetailRepository.GetOrderDetailsByID(OrderID)
                .Select(order => new
                {
                    order.ProductId,
                    order.UnitPrice,
                    order.Quantity,
                    order.Discount,
                    TotalPrice = decimal.ToDouble(order.UnitPrice) * order.Quantity * (100 - order.Discount) / 100
                }).ToList();
            dgv_OrderDetails.DataSource = orderDetails;
            dgv_OrderDetails.ClearSelection();
            txt_CurrentOrderID.Text = OrderID.ToString();

            double orderTotalPrice = 0;
            for (int i = 0; i < dgv_OrderDetails.Rows.Count; i++)
            {
                // Total Price of each product is on column 4
                orderTotalPrice += (double)dgv_OrderDetails.Rows[i].Cells[4].Value;
            }
            txt_TotalOrderPrice.Text = orderTotalPrice.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
