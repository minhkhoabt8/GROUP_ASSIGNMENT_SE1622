namespace SalesWinApp
{
    partial class frmEditMember
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
            this.cbo_Country = new System.Windows.Forms.ComboBox();
            this.lb_Country = new System.Windows.Forms.Label();
            this.cbo_City = new System.Windows.Forms.ComboBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.txt_MemberPassword = new System.Windows.Forms.TextBox();
            this.lb_MemberPassword = new System.Windows.Forms.Label();
            this.txt_MemberEmail = new System.Windows.Forms.TextBox();
            this.lb_MemberEmail = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_Country
            // 
            this.cbo_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Country.FormattingEnabled = true;
            this.cbo_Country.Items.AddRange(new object[] {
            "Vietnam",
            "USA",
            "Australia",
            "France",
            "UK",
            "China"});
            this.cbo_Country.Location = new System.Drawing.Point(162, 197);
            this.cbo_Country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Country.Name = "cbo_Country";
            this.cbo_Country.Size = new System.Drawing.Size(154, 23);
            this.cbo_Country.TabIndex = 23;
            // 
            // lb_Country
            // 
            this.lb_Country.AutoSize = true;
            this.lb_Country.Location = new System.Drawing.Point(47, 200);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(56, 15);
            this.lb_Country.TabIndex = 22;
            this.lb_Country.Text = "Country :";
            // 
            // cbo_City
            // 
            this.cbo_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_City.FormattingEnabled = true;
            this.cbo_City.Items.AddRange(new object[] {
            "HCM",
            "Hanoi",
            "Los Angeles",
            "Melbourne",
            "Paris",
            "ShangHai",
            "London",
            "Hindenburge"});
            this.cbo_City.Location = new System.Drawing.Point(162, 164);
            this.cbo_City.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_City.Name = "cbo_City";
            this.cbo_City.Size = new System.Drawing.Size(154, 23);
            this.cbo_City.TabIndex = 21;
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(47, 166);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(34, 15);
            this.lb_City.TabIndex = 20;
            this.lb_City.Text = "City :";
            // 
            // txt_MemberPassword
            // 
            this.txt_MemberPassword.Location = new System.Drawing.Point(162, 100);
            this.txt_MemberPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MemberPassword.Name = "txt_MemberPassword";
            this.txt_MemberPassword.Size = new System.Drawing.Size(154, 23);
            this.txt_MemberPassword.TabIndex = 19;
            // 
            // lb_MemberPassword
            // 
            this.lb_MemberPassword.AutoSize = true;
            this.lb_MemberPassword.Location = new System.Drawing.Point(47, 102);
            this.lb_MemberPassword.Name = "lb_MemberPassword";
            this.lb_MemberPassword.Size = new System.Drawing.Size(63, 15);
            this.lb_MemberPassword.TabIndex = 18;
            this.lb_MemberPassword.Text = "Password :";
            // 
            // txt_MemberEmail
            // 
            this.txt_MemberEmail.Location = new System.Drawing.Point(162, 67);
            this.txt_MemberEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MemberEmail.Name = "txt_MemberEmail";
            this.txt_MemberEmail.Size = new System.Drawing.Size(154, 23);
            this.txt_MemberEmail.TabIndex = 17;
            // 
            // lb_MemberEmail
            // 
            this.lb_MemberEmail.AutoSize = true;
            this.lb_MemberEmail.Location = new System.Drawing.Point(47, 69);
            this.lb_MemberEmail.Name = "lb_MemberEmail";
            this.lb_MemberEmail.Size = new System.Drawing.Size(42, 15);
            this.lb_MemberEmail.TabIndex = 16;
            this.lb_MemberEmail.Text = "Email :";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(162, 132);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(154, 23);
            this.txt_CompanyName.TabIndex = 15;
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(47, 132);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(100, 15);
            this.lb_CompanyName.TabIndex = 14;
            this.lb_CompanyName.Text = "Company Name :";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(162, 32);
            this.txt_MemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(154, 23);
            this.txt_MemberID.TabIndex = 13;
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(47, 34);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(69, 15);
            this.lb_MemberID.TabIndex = 12;
            this.lb_MemberID.Text = "MemberID :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(234, 251);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 22);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(47, 251);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 22);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 299);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbo_Country);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.cbo_City);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.txt_MemberPassword);
            this.Controls.Add(this.lb_MemberPassword);
            this.Controls.Add(this.txt_MemberEmail);
            this.Controls.Add(this.lb_MemberEmail);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.lb_CompanyName);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_MemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditMember";
            this.Text = "EditMember";
            this.Load += new System.EventHandler(this.frmEditMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbo_Country;
        private Label lb_Country;
        private ComboBox cbo_City;
        private Label lb_City;
        private TextBox txt_MemberPassword;
        private Label lb_MemberPassword;
        private TextBox txt_MemberEmail;
        private Label lb_MemberEmail;
        private TextBox txt_CompanyName;
        private Label lb_CompanyName;
        private TextBox txt_MemberID;
        private Label lb_MemberID;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}