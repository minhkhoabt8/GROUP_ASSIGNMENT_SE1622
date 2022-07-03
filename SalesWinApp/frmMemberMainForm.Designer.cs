namespace SalesWinApp
{
    partial class frmMemberMainForm
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
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lb_Country = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.btn_UpdateProfile = new System.Windows.Forms.Button();
            this.btn_ViewOrderHistory = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Country
            // 
            this.txt_Country.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Country.Location = new System.Drawing.Point(496, 101);
            this.txt_Country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.ReadOnly = true;
            this.txt_Country.Size = new System.Drawing.Size(173, 23);
            this.txt_Country.TabIndex = 23;
            // 
            // txt_City
            // 
            this.txt_City.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_City.Location = new System.Drawing.Point(496, 72);
            this.txt_City.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_City.Name = "txt_City";
            this.txt_City.ReadOnly = true;
            this.txt_City.Size = new System.Drawing.Size(173, 23);
            this.txt_City.TabIndex = 22;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_CompanyName.Location = new System.Drawing.Point(496, 39);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.ReadOnly = true;
            this.txt_CompanyName.Size = new System.Drawing.Size(173, 23);
            this.txt_CompanyName.TabIndex = 21;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Password.Location = new System.Drawing.Point(158, 96);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.ReadOnly = true;
            this.txt_Password.Size = new System.Drawing.Size(179, 23);
            this.txt_Password.TabIndex = 20;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Email.Location = new System.Drawing.Point(158, 68);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(179, 23);
            this.txt_Email.TabIndex = 19;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_MemberID.Location = new System.Drawing.Point(158, 39);
            this.txt_MemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.ReadOnly = true;
            this.txt_MemberID.Size = new System.Drawing.Size(179, 23);
            this.txt_MemberID.TabIndex = 18;
            // 
            // lb_Country
            // 
            this.lb_Country.AutoSize = true;
            this.lb_Country.Location = new System.Drawing.Point(374, 104);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(56, 15);
            this.lb_Country.TabIndex = 17;
            this.lb_Country.Text = "Country :";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(374, 74);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(34, 15);
            this.lb_City.TabIndex = 16;
            this.lb_City.Text = "City :";
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(374, 41);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(100, 15);
            this.lb_CompanyName.TabIndex = 15;
            this.lb_CompanyName.Text = "Company Name :";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(36, 98);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(63, 15);
            this.lb_Password.TabIndex = 14;
            this.lb_Password.Text = "Password :";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(36, 70);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(42, 15);
            this.lb_Email.TabIndex = 13;
            this.lb_Email.Text = "Email :";
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(36, 41);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(69, 15);
            this.lb_MemberID.TabIndex = 12;
            this.lb_MemberID.Text = "MemberID :";
            // 
            // btn_UpdateProfile
            // 
            this.btn_UpdateProfile.Location = new System.Drawing.Point(256, 154);
            this.btn_UpdateProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateProfile.Name = "btn_UpdateProfile";
            this.btn_UpdateProfile.Size = new System.Drawing.Size(214, 32);
            this.btn_UpdateProfile.TabIndex = 24;
            this.btn_UpdateProfile.Text = "Update Profile";
            this.btn_UpdateProfile.UseVisualStyleBackColor = true;
            this.btn_UpdateProfile.Click += new System.EventHandler(this.btn_UpdateProfile_Click);
            // 
            // btn_ViewOrderHistory
            // 
            this.btn_ViewOrderHistory.Location = new System.Drawing.Point(256, 216);
            this.btn_ViewOrderHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewOrderHistory.Name = "btn_ViewOrderHistory";
            this.btn_ViewOrderHistory.Size = new System.Drawing.Size(214, 32);
            this.btn_ViewOrderHistory.TabIndex = 25;
            this.btn_ViewOrderHistory.Text = "View Order History";
            this.btn_ViewOrderHistory.UseVisualStyleBackColor = true;
            this.btn_ViewOrderHistory.Click += new System.EventHandler(this.btn_ViewOrderHistory_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(256, 274);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(214, 32);
            this.btn_Close.TabIndex = 26;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmMemberMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 338);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_ViewOrderHistory);
            this.Controls.Add(this.btn_UpdateProfile);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_CompanyName);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_MemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMemberMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserMainForm";
            this.Load += new System.EventHandler(this.frmMemberMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Country;
        private TextBox txt_City;
        private TextBox txt_CompanyName;
        private TextBox txt_Password;
        private TextBox txt_Email;
        private TextBox txt_MemberID;
        private Label lb_Country;
        private Label lb_City;
        private Label lb_CompanyName;
        private Label lb_Password;
        private Label lb_Email;
        private Label lb_MemberID;
        private Button btn_UpdateProfile;
        private Button btn_ViewOrderHistory;
        private Button btn_Close;
    }
}