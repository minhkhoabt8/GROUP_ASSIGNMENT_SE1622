using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmAdminMainForm : Form
    {
        public frmAdminMainForm()
        {
            InitializeComponent();
        }

        private void btn_Member_Management_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.ShowDialog();
        }

        private void btn_ProductManagement_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement();
            frmProductManagement.ShowDialog();
        }

        private void btn_OrderManagement_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            frmOrderManagement.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdminMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
