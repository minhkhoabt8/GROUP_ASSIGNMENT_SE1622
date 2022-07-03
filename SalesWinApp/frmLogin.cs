using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
namespace SalesWinApp
{


    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        private List<Member> memberList = new List<Member>();

        public frmLogin()
        {
            InitializeComponent();
            memberList = (List<Member>)memberRepository.GetMembers();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Password.Text;
            /* String fileName = "appsettings.json";
             String json = File.ReadAllText(fileName);
             var adminAccount = JsonSerializer.Deserialize<Member>(json, null);

             if(email.Equals(adminAccount.Email) && password.Equals(adminAccount.Password))
             {
                 frmMemberMainForm frmMemberMainForm = new frmMemberMainForm();
                 this.Hide();
                 frmMemberMainForm.ShowDialog();
                return;
             }*/
            foreach (Member member in memberList)
            {
                if(email.Equals(member.Email) && password.Equals(member.Password))
                {
                    frmMemberMainForm frmMemberMainForm = new frmMemberMainForm(member);
                    this.Hide();
                    frmMemberMainForm.ShowDialog();
                    return;

                }
            }
            MessageBox.Show("Email or Password is wrong", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();
        
    }
}