namespace SalesWinApp
{
    partial class frmAdminMainForm
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
            this.btn_Member_Management = new System.Windows.Forms.Button();
            this.btn_ProductManagement = new System.Windows.Forms.Button();
            this.btn_OrderManagement = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Member_Management
            // 
            this.btn_Member_Management.Location = new System.Drawing.Point(209, 68);
            this.btn_Member_Management.Name = "btn_Member_Management";
            this.btn_Member_Management.Size = new System.Drawing.Size(419, 55);
            this.btn_Member_Management.TabIndex = 0;
            this.btn_Member_Management.Text = "Member Management";
            this.btn_Member_Management.UseVisualStyleBackColor = true;
            this.btn_Member_Management.Click += new System.EventHandler(this.btn_Member_Management_Click);
            // 
            // btn_ProductManagement
            // 
            this.btn_ProductManagement.Location = new System.Drawing.Point(209, 156);
            this.btn_ProductManagement.Name = "btn_ProductManagement";
            this.btn_ProductManagement.Size = new System.Drawing.Size(419, 55);
            this.btn_ProductManagement.TabIndex = 1;
            this.btn_ProductManagement.Text = "Product Management";
            this.btn_ProductManagement.UseVisualStyleBackColor = true;
            this.btn_ProductManagement.Click += new System.EventHandler(this.btn_ProductManagement_Click);
            // 
            // btn_OrderManagement
            // 
            this.btn_OrderManagement.Location = new System.Drawing.Point(209, 241);
            this.btn_OrderManagement.Name = "btn_OrderManagement";
            this.btn_OrderManagement.Size = new System.Drawing.Size(419, 55);
            this.btn_OrderManagement.TabIndex = 2;
            this.btn_OrderManagement.Text = "Order Management";
            this.btn_OrderManagement.UseVisualStyleBackColor = true;
            this.btn_OrderManagement.Click += new System.EventHandler(this.btn_OrderManagement_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(361, 333);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(104, 46);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmAdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_OrderManagement);
            this.Controls.Add(this.btn_ProductManagement);
            this.Controls.Add(this.btn_Member_Management);
            this.Name = "frmAdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMainForm";
            this.Load += new System.EventHandler(this.frmAdminMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Member_Management;
        private Button btn_ProductManagement;
        private Button btn_OrderManagement;
        private Button btn_Close;
    }
}