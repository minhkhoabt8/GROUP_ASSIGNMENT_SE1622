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
using DataAccess;

namespace SalesWinApp
{
    public partial class frmMemberMainForm : Form
    {
        private static IMemberRepository memberRepository = new MemberRepository();
        private static IOrderRepository orderRepository = new OrderRepository();
        public bool InsertOrUpdate { get; set; }
        public Member MemberDetails { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        
       

        public frmMemberMainForm()
        {
            InitializeComponent();
        }

  
        private void btn_UpdateProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ViewOrderHistory_Click(object sender, EventArgs e)
        {
            var currMember = orderRepository.GetOrderHistory(MemberDetails.MemberId);
            
            frmOrderHistory frmOrderHistory = new frmOrderHistory
            {
                orderHistoryInfo = currMember
            };
            frmOrderHistory.ShowDialog();

        }

        private void btn_Close_Click(object sender, EventArgs e) => Close();

        private void frmMemberMainForm_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void LoadMember()
        {
            
            txt_MemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txt_MemberID.Text = MemberDetails.MemberId.ToString();
                txt_Email.Text = MemberDetails.Email;
                txt_CompanyName.Text = MemberDetails.CompanyName;
                txt_Password.Text = MemberDetails.Password;
                txt_City.Text = MemberDetails.City;
                txt_Country.Text = MemberDetails.Country;
            }
        }
    }
}
