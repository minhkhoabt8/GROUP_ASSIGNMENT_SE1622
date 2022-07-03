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
using DataAccess;

namespace SalesWinApp
{
    public partial class frmMemberMainForm : Form
    {
        private static IMemberRepository memberRepository = new MemberRepository();

        public Member member { get; set; }
        public Member currMember = null;
        public bool CreateOrUpdate { get; set; }
        public Member MemberInfo { get; set; }

        public frmMemberMainForm()
        {
            InitializeComponent();
        }

  
        private void btn_UpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewOrderHistory_Click(object sender, EventArgs e)
        {
            //currMember = memberRepository.GetMemberByID(MemberID);
            //frmOrderHistory frmOrderHistory = new frmOrderHistory
            //{
               
            //   MemberInfo = currMember
            //};
            //frmOrderHistory.ShowDialog();



        }

        private void btn_Close_Click(object sender, EventArgs e) => Close();

        private void frmMemberMainForm_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void LoadMember()
        {
            var members = MemberDAO.Instance.GetMembers();
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
