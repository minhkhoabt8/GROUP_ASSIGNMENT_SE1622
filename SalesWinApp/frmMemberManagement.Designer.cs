namespace SalesWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_MemberList = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_AddNewMember = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_Country = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.btn_UpdateMember = new System.Windows.Forms.Button();
            this.btn_DeleteMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MemberList
            // 
            this.dgv_MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberList.Location = new System.Drawing.Point(403, 83);
            this.dgv_MemberList.Name = "dgv_MemberList";
            this.dgv_MemberList.ReadOnly = true;
            this.dgv_MemberList.RowHeadersWidth = 51;
            this.dgv_MemberList.RowTemplate.Height = 29;
            this.dgv_MemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MemberList.Size = new System.Drawing.Size(662, 312);
            this.dgv_MemberList.TabIndex = 70;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(935, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 29);
            this.btn_Search.TabIndex = 73;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_SearchValue
            // 
            this.txt_SearchValue.Location = new System.Drawing.Point(489, 41);
            this.txt_SearchValue.Name = "txt_SearchValue";
            this.txt_SearchValue.Size = new System.Drawing.Size(427, 27);
            this.txt_SearchValue.TabIndex = 72;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(683, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn_AddNewMember
            // 
            this.btn_AddNewMember.Location = new System.Drawing.Point(403, 433);
            this.btn_AddNewMember.Name = "btn_AddNewMember";
            this.btn_AddNewMember.Size = new System.Drawing.Size(207, 50);
            this.btn_AddNewMember.TabIndex = 68;
            this.btn_AddNewMember.Text = "Add New Member";
            this.btn_AddNewMember.UseVisualStyleBackColor = true;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(186, 123);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(211, 27);
            this.txt_Email.TabIndex = 66;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(186, 304);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(211, 27);
            this.txt_Country.TabIndex = 65;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(186, 368);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(211, 27);
            this.txt_City.TabIndex = 64;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(186, 242);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(211, 27);
            this.txt_CompanyName.TabIndex = 63;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(186, 188);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(211, 27);
            this.txt_Password.TabIndex = 62;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(186, 62);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.ReadOnly = true;
            this.txt_MemberID.Size = new System.Drawing.Size(205, 27);
            this.txt_MemberID.TabIndex = 61;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(49, 130);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 20);
            this.lb_Email.TabIndex = 60;
            this.lb_Email.Text = "Email";
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(49, 246);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(116, 20);
            this.lb_CompanyName.TabIndex = 59;
            this.lb_CompanyName.Text = "Company Name";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(49, 364);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(34, 20);
            this.lb_City.TabIndex = 58;
            this.lb_City.Text = "City";
            // 
            // lb_Country
            // 
            this.lb_Country.AutoSize = true;
            this.lb_Country.Location = new System.Drawing.Point(49, 306);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(60, 20);
            this.lb_Country.TabIndex = 57;
            this.lb_Country.Text = "Country";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(49, 195);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(70, 20);
            this.lb_Password.TabIndex = 56;
            this.lb_Password.Text = "Password";
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(49, 68);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(80, 20);
            this.lb_MemberID.TabIndex = 55;
            this.lb_MemberID.Text = "MemberID";
            // 
            // btn_UpdateMember
            // 
            this.btn_UpdateMember.Location = new System.Drawing.Point(631, 433);
            this.btn_UpdateMember.Name = "btn_UpdateMember";
            this.btn_UpdateMember.Size = new System.Drawing.Size(207, 50);
            this.btn_UpdateMember.TabIndex = 74;
            this.btn_UpdateMember.Text = "Update Member";
            this.btn_UpdateMember.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteMember
            // 
            this.btn_DeleteMember.Location = new System.Drawing.Point(858, 433);
            this.btn_DeleteMember.Name = "btn_DeleteMember";
            this.btn_DeleteMember.Size = new System.Drawing.Size(207, 50);
            this.btn_DeleteMember.TabIndex = 75;
            this.btn_DeleteMember.Text = "Delete Member";
            this.btn_DeleteMember.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 564);
            this.Controls.Add(this.btn_DeleteMember);
            this.Controls.Add(this.btn_UpdateMember);
            this.Controls.Add(this.dgv_MemberList);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_AddNewMember);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_CompanyName);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_MemberID);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_MemberList;
        private Button btn_Search;
        private TextBox txt_SearchValue;
        private Button btnClose;
        private Button btn_AddNewMember;
        private TextBox txt_Email;
        private TextBox txt_Country;
        private TextBox txt_City;
        private TextBox txt_CompanyName;
        private TextBox txt_Password;
        private TextBox txt_MemberID;
        private Label lb_Email;
        private Label lb_CompanyName;
        private Label lb_City;
        private Label lb_Country;
        private Label lb_Password;
        private Label lb_MemberID;
        private Button btn_UpdateMember;
        private Button btn_DeleteMember;
    }
}