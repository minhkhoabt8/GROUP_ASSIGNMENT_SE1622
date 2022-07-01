using BusinessObject;

using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SalesWinApp
{
    public partial class frmMemberManagement : Form
    {
        Member member;
        IMemberRepository memberRepository = new MemberRepository();

        public frmMemberManagement()
        {
            InitializeComponent();
        }
        public frmMemberManagement(Member member)
        {
            InitializeComponent();
            this.member = member;
            btn_AddNewMember.Enabled = false;
            btn_DeleteMember.Enabled = false;
        }

        private void ClearDataBinding()
        {
            txt_MemberID.DataBindings.Clear();
            txt_CompanyName.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_Password.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Country.DataBindings.Clear();
        }

        private void AddDataBinding(BindingSource bindingSource)
        {
            txt_MemberID.DataBindings.Add("Text", bindingSource, "MemberId");
            txt_Email.DataBindings.Add("Text", bindingSource, "Email");
            txt_CompanyName.DataBindings.Add("Text", bindingSource, "CompanyName");
            txt_City.DataBindings.Add("Text", bindingSource, "City");
            txt_Country.DataBindings.Add("Text", bindingSource, "Country");
            txt_Password.DataBindings.Add("Text", bindingSource, "Password");

        }


        private void btn_AddNewMember_Click(object sender, EventArgs e)
        {
            frmEditMember frmMemberDetail = new frmEditMember
            {
                Text = "Create Member",
                MemberRepository = memberRepository,
                CreateOrUpdate = true,
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();

            }

        }

        private void btn_UpdateMember_Click(object sender, EventArgs e)
        {
            frmEditMember frmMemberDetail = new frmEditMember
            {
                MemberRepository = this.memberRepository,
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
                member = new Member()
                {
                    MemberId = int.Parse(txt_MemberID.Text),
                    Email = txt_Email.Text,
                    CompanyName = txt_CompanyName.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text,
                    Password = txt_Password.Text,
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
            if (member == null)
            {
                try
                {
                    var memberList = memberRepository.GetMembers();
                    BindingSource source = new BindingSource();
                    source.DataSource = memberList;

                    ClearDataBinding();
                    AddDataBinding(source);

                    dgv_MemberList.DataSource = null;
                    dgv_MemberList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on Loading");
                }
            }
            else
            {
                try
                {
                    member = memberRepository.GetMembers().SingleOrDefault(value => value.MemberId == member.MemberId);
                    BindingSource source = new BindingSource();
                    source.DataSource = member;

                    ClearDataBinding();
                    AddDataBinding(source);

                    dgv_MemberList.DataSource = null;
                    dgv_MemberList.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on Loading");
                }
            }

        }


        private void dgv_MemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditMember frmEditMember = new frmEditMember
            {
                MemberRepository = this.memberRepository,
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
                var member = GetMemberObject();
                var Confirm = MessageBox.Show("Are you want to delete this member?", "Confirm Delete!!", MessageBoxButtons.YesNo);
                if(Confirm == DialogResult.Yes)
                {
                    memberRepository.DeleteMember(member);
                    MessageBox.Show("Delete Succesful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMemberList();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member");
            }
        }
    }


}
