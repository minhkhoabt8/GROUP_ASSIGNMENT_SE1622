﻿using BusinessObject;
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
    public partial class frmOrderHistory : Form
    {

        IMemberRepository memberRepository;

        public frmOrderHistory()
        {
            InitializeComponent();
        }
        public OrderRepository OrderRepo { get; set; }
        public OrderDetailRepository OrderDetailRepo { get; set; }
        public IEnumerable<Order> orderHistoryInfo { get; set; }
        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            LoadMemberOrderHistory();
        }
        private void LoadMemberOrderHistory()
        {
            try
            {
                
                dgv_OrderHistory.DataSource = orderHistoryInfo.ToList();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member Order History");
            }
        }
        private void dgvOrderHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails orderDetailsForm = new frmOrderDetails
            {
                OrderDetailRepo = this.OrderDetailRepo,
                //get current row and get cell of orderID
                OrderID = int.Parse(dgv_OrderHistory.Rows[e.RowIndex].Cells[0].Value.ToString())
                
            };
            
            orderDetailsForm.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
