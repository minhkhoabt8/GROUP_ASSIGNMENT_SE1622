namespace SalesWinApp
{
    partial class frmEditOrder
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
            this.components = new System.ComponentModel.Container();
            this.txt_ShippedDate = new System.Windows.Forms.TextBox();
            this.txt_RequiredDate = new System.Windows.Forms.TextBox();
            this.txt_OrderDate = new System.Windows.Forms.TextBox();
            this.lb_ShippedDate = new System.Windows.Forms.Label();
            this.lb_RequiredDate = new System.Windows.Forms.Label();
            this.lb_OrderDate = new System.Windows.Forms.Label();
            this.txt_Freight = new System.Windows.Forms.TextBox();
            this.lb_Freight = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lb_OrderID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.errorProviderMemberID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFreight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRequireDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderShippedDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShippedDate)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ShippedDate
            // 
            this.txt_ShippedDate.Location = new System.Drawing.Point(180, 271);
            this.txt_ShippedDate.Name = "txt_ShippedDate";
            this.txt_ShippedDate.Size = new System.Drawing.Size(197, 27);
            this.txt_ShippedDate.TabIndex = 28;
            // 
            // txt_RequiredDate
            // 
            this.txt_RequiredDate.Location = new System.Drawing.Point(180, 227);
            this.txt_RequiredDate.Name = "txt_RequiredDate";
            this.txt_RequiredDate.Size = new System.Drawing.Size(197, 27);
            this.txt_RequiredDate.TabIndex = 27;
            // 
            // txt_OrderDate
            // 
            this.txt_OrderDate.Location = new System.Drawing.Point(180, 184);
            this.txt_OrderDate.Name = "txt_OrderDate";
            this.txt_OrderDate.Size = new System.Drawing.Size(197, 27);
            this.txt_OrderDate.TabIndex = 26;
            // 
            // lb_ShippedDate
            // 
            this.lb_ShippedDate.AutoSize = true;
            this.lb_ShippedDate.Location = new System.Drawing.Point(70, 274);
            this.lb_ShippedDate.Name = "lb_ShippedDate";
            this.lb_ShippedDate.Size = new System.Drawing.Size(107, 20);
            this.lb_ShippedDate.TabIndex = 25;
            this.lb_ShippedDate.Text = "Shipped Date :";
            // 
            // lb_RequiredDate
            // 
            this.lb_RequiredDate.AutoSize = true;
            this.lb_RequiredDate.Location = new System.Drawing.Point(70, 230);
            this.lb_RequiredDate.Name = "lb_RequiredDate";
            this.lb_RequiredDate.Size = new System.Drawing.Size(112, 20);
            this.lb_RequiredDate.TabIndex = 24;
            this.lb_RequiredDate.Text = "Required Date :";
            // 
            // lb_OrderDate
            // 
            this.lb_OrderDate.AutoSize = true;
            this.lb_OrderDate.Location = new System.Drawing.Point(70, 187);
            this.lb_OrderDate.Name = "lb_OrderDate";
            this.lb_OrderDate.Size = new System.Drawing.Size(90, 20);
            this.lb_OrderDate.TabIndex = 23;
            this.lb_OrderDate.Text = "Order Date :";
            // 
            // txt_Freight
            // 
            this.txt_Freight.Location = new System.Drawing.Point(180, 140);
            this.txt_Freight.Name = "txt_Freight";
            this.txt_Freight.Size = new System.Drawing.Size(197, 27);
            this.txt_Freight.TabIndex = 22;
            // 
            // lb_Freight
            // 
            this.lb_Freight.AutoSize = true;
            this.lb_Freight.Location = new System.Drawing.Point(70, 143);
            this.lb_Freight.Name = "lb_Freight";
            this.lb_Freight.Size = new System.Drawing.Size(62, 20);
            this.lb_Freight.TabIndex = 21;
            this.lb_Freight.Text = "Freight :";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(180, 98);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(197, 27);
            this.txt_MemberID.TabIndex = 20;
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(70, 101);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(91, 20);
            this.lb_MemberID.TabIndex = 19;
            this.lb_MemberID.Text = "Member ID :";
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(180, 54);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(197, 27);
            this.txt_OrderID.TabIndex = 18;
            // 
            // lb_OrderID
            // 
            this.lb_OrderID.AutoSize = true;
            this.lb_OrderID.Location = new System.Drawing.Point(70, 57);
            this.lb_OrderID.Name = "lb_OrderID";
            this.lb_OrderID.Size = new System.Drawing.Size(73, 20);
            this.lb_OrderID.TabIndex = 17;
            this.lb_OrderID.Text = "Order ID :";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(70, 353);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(283, 353);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 30;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // errorProviderCategoryID
            // 
            this.errorProviderMemberID.ContainerControl = this;
            // 
            // errorProviderProductName
            // 
            this.errorProviderFreight.ContainerControl = this;
            // 
            // errorProviderWeight
            // 
            this.errorProviderOrderDate.ContainerControl = this;
            // 
            // errorProviderUnitPrice
            // 
            this.errorProviderRequireDate.ContainerControl = this;
            // 
            // errorProviderUnitsInStock
            // 
            this.errorProviderShippedDate.ContainerControl = this;
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_ShippedDate);
            this.Controls.Add(this.txt_RequiredDate);
            this.Controls.Add(this.txt_OrderDate);
            this.Controls.Add(this.lb_ShippedDate);
            this.Controls.Add(this.lb_RequiredDate);
            this.Controls.Add(this.lb_OrderDate);
            this.Controls.Add(this.txt_Freight);
            this.Controls.Add(this.lb_Freight);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_MemberID);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.lb_OrderID);
            this.Name = "frmEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShippedDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_ShippedDate;
        private TextBox txt_RequiredDate;
        private TextBox txt_OrderDate;
        private Label lb_ShippedDate;
        private Label lb_RequiredDate;
        private Label lb_OrderDate;
        private TextBox txt_Freight;
        private Label lb_Freight;
        private TextBox txt_MemberID;
        private Label lb_MemberID;
        private TextBox txt_OrderID;
        private Label lb_OrderID;
        private Button btn_Save;
        private Button btn_Cancel;
        private ErrorProvider errorProviderMemberID;
        private ErrorProvider errorProviderFreight;
        private ErrorProvider errorProviderOrderDate;
        private ErrorProvider errorProviderRequireDate;
        private ErrorProvider errorProviderShippedDate;
    }
}