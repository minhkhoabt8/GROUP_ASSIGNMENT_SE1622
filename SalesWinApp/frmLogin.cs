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
        private bool checkAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            if (txt_Email.Text.Equals(config["AdminAccount:Email"]) &&
                 txt_Password.Text.Equals(config["AdminAccount:Password"]))
            {
                return true;
            }

            return false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Password.Text;


            IConfiguration config = new ConfigurationBuilder()
                                       .SetBasePath(Directory.GetCurrentDirectory())
                                       .AddJsonFile("appsettings.json", true, true)
                                       .Build();


            if (email.Equals(config["DefaultEmail:Email"]) &&
                 password.Equals(config["DefaultEmail:Password"]))
            {
                frmAdminMainForm admin = new frmAdminMainForm();
                admin.ShowDialog();
            }
            else
            {
                foreach (Member member in memberList)
                {
                    if (email.Equals(member.Email) && password.Equals(member.Password))
                    {
                        frmMemberMainForm frmMemberMainForm = new frmMemberMainForm();
                        
                        frmMemberMainForm.ShowDialog();
                        

                    }
                }
                MessageBox.Show("Email or Password is wrong", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();
        
    }
}