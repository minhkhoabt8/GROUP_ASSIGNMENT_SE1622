﻿using System;
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
            frmEditMember frmEditMember = new frmEditMember
            {
                Text = "Update Profile",
                MemberInfo = GetMemberObject()
            };
            if (frmEditMember.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
            }
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
 
                LoadMemberList(MemberDetails.MemberId);
            
           
        }
        private void LoadMemberList(int memberID)
        {
            var members = memberRepository.GetMemberByID(memberID);
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

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txt_MemberID.Text),
                    Email = txt_Email.Text,
                    Password = txt_Password.Text,
                    CompanyName = txt_CompanyName.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
    }
}
