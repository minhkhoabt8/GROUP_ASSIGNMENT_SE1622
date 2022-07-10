using BusinessObject;
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
    public partial class frmEditOrderDetail : Form
    {
        public frmEditOrderDetail()
        {
            InitializeComponent();
        }
        IOrderDetailRepository orderdetailRepository = new OrderDetailRepository();
        public bool InsertOrUpdate { get; set; }

        public OrderDetail orderInfo { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try{
                var order = new OrderDetail
                {
                    OrderId = int.Parse(txt_OrderID.Text),
                    ProductId = int.Parse(txt_ProductID.Text),
                    UnitPrice = decimal.Parse(txt_UnitPrice.Text),
                    Quantity = int.Parse(txt_Quantity.Text),
                    Discount = double.Parse(txt_Discount.Text)
                };
                if (InsertOrUpdate == false)
                {
                    orderdetailRepository.AddNewOrderDetail(order);
                }
                else
                {
                    order.OrderId = int.Parse(txt_OrderID.Text);
                    orderdetailRepository.UpdateOrderDetail(order);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
