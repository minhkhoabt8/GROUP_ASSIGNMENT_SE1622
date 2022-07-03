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
                LoadMemberList(member.MemberId);
            }
            else
            {
                frmMemberManagement = new frmMemberManagement();
            }
            frmMemberManagement.Text = "Members Form";
            frmMemberManagement.StartPosition = FormStartPosition.Manual;
            frmMemberManagement.Show();

        }
        private void LoadMemberList(int memberID)
        {
            var members = MemberDAO.Instance.GetMember(memberID);
            txt_MemberID.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_CompanyName.DataBindings.Clear();
            txt_Password.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Country.DataBindings.Clear();

            txt_MemberID.DataBindings.Add("Text", members, "MemberId");
            txt_Email.DataBindings.Add("Text", members, "Email");
            txt_CompanyName.DataBindings.Add("Text", members, "CompanyName");
            txt_City.DataBindings.Add("Text", members, "City");
            txt_Country.DataBindings.Add("Text", members, "Country");
            txt_Password.DataBindings.Add("Text", members, "Password");
            txt_MemberID.Enabled = false;
        }
    }
}
