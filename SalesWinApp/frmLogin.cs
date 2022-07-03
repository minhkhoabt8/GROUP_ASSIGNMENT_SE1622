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
            var memberDetails = memberRepository.Login(txt_Email.Text, txt_Password.Text);

            if (email.Equals(config["DefaultEmail:Email"]) &&
                 password.Equals(config["DefaultEmail:Password"]))
            {
                frmAdminMainForm admin = new frmAdminMainForm();
                admin.ShowDialog();
            }
            else if (memberDetails != null)
            {

                //direct to user page
                frmMemberMainForm frmMemberMain = new frmMemberMainForm
                {
                    Text = "User Info",
                    InsertOrUpdate = true,
                    MemberDetails = memberDetails,
                    MemberRepository = memberRepository
                };
                if (frmMemberMain.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("Goodbye! See you again!");
                }

            }
            else
            {
                MessageBox.Show("Username Or Password not Found!!");
            }



        }

        private void btn_Exit_Click(object sender, EventArgs e) => Close();

    }
}