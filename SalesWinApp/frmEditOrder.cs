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
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
        }
        OrderRepository orderRepository = new OrderRepository();
        public bool InsertOrUpdate { get; set; }

        public Order orderInfo { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = true;
                if (txt_MemberID.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderMemberID.SetError(txt_MemberID, "Please input the member id!");
                }
                else
                {
                    errorProviderMemberID.SetError(txt_MemberID, "");
                }
                if (txt_Freight.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderFreight.SetError(txt_Freight, "Please input the freight!");
                }
                else
                {
                    errorProviderFreight.SetError(txt_Freight, "");
                }
                if (txt_OrderDate.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderOrderDate.SetError(txt_OrderDate, "Please input the order date!");
                }
                else
                {
                    errorProviderOrderDate.SetError(txt_OrderDate, "");
                }
                if (txt_RequiredDate.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderRequireDate.SetError(txt_RequiredDate, "Please input the order date!");
                }
                else
                {
                    errorProviderRequireDate.SetError(txt_RequiredDate, "");
                }
                if (txt_ShippedDate.Text.Trim().Length == 0)
                {
                    validation = false;
                    errorProviderShippedDate.SetError(txt_ShippedDate, "Please input the order date!");
                }
                else
                {
                    errorProviderShippedDate.SetError(txt_ShippedDate, "");
                }
                if (validation)
                {
                    var order = new Order
                    {
                        MemberId = int.Parse(txt_MemberID.Text),
                        Freight = decimal.Parse(txt_Freight.Text),
                        OrderDate = DateTime.Parse(txt_OrderDate.Text),
                        RequiredDate = DateTime.Parse(txt_RequiredDate.Text),
                        ShippedDate = DateTime.Parse(txt_ShippedDate.Text),
                    };
                    if (InsertOrUpdate == false)
                    {
                        orderRepository.AddNewOrder(order);
                    }
                    else
                    {
                        order.OrderId = int.Parse(txt_OrderID.Text);
                        orderRepository.UpdateOrder(order);
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
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Order" : "Update order");
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e) => Close();
        

        private void frmEditOrder_Load(object sender, EventArgs e)
        {
            var id = orderRepository.GetOrders().Max(c => c.OrderId) + 1;
            txt_OrderID.Text = id.ToString();
            if (InsertOrUpdate == true)
            {
                txt_OrderID.Text = orderInfo.OrderId.ToString();
                txt_MemberID.Text = orderInfo.MemberId.ToString();
                txt_Freight.Text = orderInfo.Freight.ToString();
                txt_OrderDate.Text = orderInfo.OrderDate.ToString();
                txt_RequiredDate.Text = orderInfo.RequiredDate.ToString();
                txt_ShippedDate.Text = orderInfo.ShippedDate.ToString();
            }
        }
    }
}
