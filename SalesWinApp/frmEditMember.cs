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
    public partial class frmEditMember : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool CreateOrUpdate { get; set; }
        public Member MemberInfo { get; set; }

        public frmEditMember()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            try
            {
                var members = new Member
                {
                    MemberId = int.Parse(txt_MemberID.Text),
                    CompanyName = txt_CompanyName.Text,
                    Email = txt_MemberEmail.Text,
                    Password = txt_MemberPassword.Text,
                    City = cbo_City.Text,
                    Country = cbo_Country.Text,
                };
                if (!Regex.IsMatch(members.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                {
                    throw new Exception("Wrong Format Email!");
                }

                if (members.CompanyName.Equals("") || members.Password.Equals("") || members.City.Equals("") || members.Country.Equals(""))
                {
                    throw new Exception("All field required!");
                }
                if (CreateOrUpdate == true)
                {
                    MemberRepository.AddNewMember(members);
                }
                else
                {
                    MemberRepository.UpdateMember(members);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == true? "Create new Member" : "Update Member");
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e) => Close();


        private void frmEditMember_Load(object sender, EventArgs e)
        {
            cbo_City.SelectedIndex = 0;
            cbo_Country.SelectedIndex = 0;
            txt_MemberID.Enabled = CreateOrUpdate;
            if (CreateOrUpdate == false)
            {
                txt_MemberID.Text = MemberInfo.MemberId.ToString();
                txt_CompanyName.Text = MemberInfo.CompanyName.ToString();
                txt_MemberEmail.Text = MemberInfo.Email;
                txt_MemberPassword.Text = MemberInfo.Password;
                cbo_City.Text = MemberInfo.City.Trim();
                cbo_Country.Text = MemberInfo.Country.Trim();
            }
        }
    }
}
