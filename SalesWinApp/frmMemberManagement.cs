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
    public partial class frmMemberManagement : Form
    {
        private static IMemberRepository memberRepository = new MemberRepository();

        public frmMemberManagement()
        {
            InitializeComponent();
        }
        


        private void btn_AddNewMember_Click(object sender, EventArgs e)
        {
            frmEditMember frmEditMember = new frmEditMember
            {
                Text = "Create Member",
                CreateOrUpdate = true,
            };
            if (frmEditMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();

            }

        }

        private void btn_UpdateMember_Click(object sender, EventArgs e)
        {
            frmEditMember frmMemberDetail = new frmEditMember
            {
                CreateOrUpdate = false,
                Text = "Update new member",
                MemberInfo = GetMemberObject(),


            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = Int32.Parse(txt_MemberID.Text),
                    Email = txt_Email.Text,
                    Password = txt_Password.Text,
                    CompanyName = txt_CompanyName.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text,
                    
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
       

        private void btnClose_Click(object sender, EventArgs e) => Close();


        private void LoadMemberList()
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
            dgv_MemberList.DataSource = members;
            if(members.Count > 0)
            {
                btn_DeleteMember.Enabled = true;
            }
            else
            {
                btn_DeleteMember.Enabled = false;
            }

        }
        private void dgv_MemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditMember frmEditMember = new frmEditMember
            {
                CreateOrUpdate = false,
                MemberInfo = GetMemberObject(),
                Text = "Update member info"
            };
            if (frmEditMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        private void btn_DeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                memberRepository.DeleteMember(int.Parse(txt_MemberID.Text));
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }
    }


}
