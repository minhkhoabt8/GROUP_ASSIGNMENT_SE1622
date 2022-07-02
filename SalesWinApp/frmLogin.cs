using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
namespace SalesWinApp
{


    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        private IEnumerable<Member> members = null;
        
        public frmLogin()
        {
            InitializeComponent();
            members = memberRepository.GetMembers();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var adminAccount = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("DefaultEmail").Get<Member>();
            string email = txt_Email.Text;
            string password = txt_Password.Text;
            if(email.Equals(adminAccount.Email) && password.Equals(adminAccount.Password))
            {
                frmMemberMainForm frmMemberMainForm = new frmMemberMainForm();
                this.Hide();
                frmMemberMainForm.ShowDialog();
               return;
            }
            foreach(Member member in members)
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