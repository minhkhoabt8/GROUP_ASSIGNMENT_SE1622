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
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMemberMainForm : Form
    {
        public Member member { get; set; }
        public frmMemberMainForm()
        {
            InitializeComponent();
        }
        IProductRepository productRepository = new ProductRepository();
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source = null;
        public frmMemberMainForm(Member member)
        {
            InitializeComponent();
            this.member = member;

        }
        private void btn_UpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewOrderHistory_Click(object sender, EventArgs e)
        {




        }

        private void btn_Close_Click(object sender, EventArgs e) => Close();

        private void frmMemberMainForm_Load(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = null;
            if (member != null)
            {
                frmMemberManagement = new frmMemberManagement();

            }
            else
            {
                frmMemberManagement = new frmMemberManagement();
            }
            frmMemberManagement.Text = "Members Form";
            frmMemberManagement.StartPosition = FormStartPosition.Manual;
            frmMemberManagement.Show();

        }
        
    }
}
