namespace SalesWinApp
{
    partial class frmOrderDetailManagement
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
            this.btn_DeleteDetail = new System.Windows.Forms.Button();
            this.btn_UpdateDetail = new System.Windows.Forms.Button();
            this.dgv_OrderDetailList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_AddNewDetails = new System.Windows.Forms.Button();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lb_ProductId = new System.Windows.Forms.Label();
            this.lb_UnitPrice = new System.Windows.Forms.Label();
            this.lb_OrderID = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.lb_Quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteDetail
            // 
            this.btn_DeleteDetail.Location = new System.Drawing.Point(875, 417);
            this.btn_DeleteDetail.Name = "btn_DeleteDetail";
            this.btn_DeleteDetail.Size = new System.Drawing.Size(207, 50);
            this.btn_DeleteDetail.TabIndex = 94;
            this.btn_DeleteDetail.Text = "Delete Detail";
            this.btn_DeleteDetail.UseVisualStyleBackColor = true;
            this.btn_DeleteDetail.Click += new System.EventHandler(this.btn_DeleteDetail_Click);
            // 
            // btn_UpdateDetail
            // 
            this.btn_UpdateDetail.Location = new System.Drawing.Point(648, 417);
            this.btn_UpdateDetail.Name = "btn_UpdateDetail";
            this.btn_UpdateDetail.Size = new System.Drawing.Size(207, 50);
            this.btn_UpdateDetail.TabIndex = 93;
            this.btn_UpdateDetail.Text = "Update Detail";
            this.btn_UpdateDetail.UseVisualStyleBackColor = true;
            this.btn_UpdateDetail.Click += new System.EventHandler(this.btn_UpdateDetail_Click);
            // 
            // dgv_OrderDetailList
            // 
            this.dgv_OrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetailList.Location = new System.Drawing.Point(420, 67);
            this.dgv_OrderDetailList.Name = "dgv_OrderDetailList";
            this.dgv_OrderDetailList.ReadOnly = true;
            this.dgv_OrderDetailList.RowHeadersWidth = 51;
            this.dgv_OrderDetailList.RowTemplate.Height = 29;
            this.dgv_OrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderDetailList.Size = new System.Drawing.Size(662, 312);
            this.dgv_OrderDetailList.TabIndex = 89;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(700, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 90;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_AddNewDetails
            // 
            this.btn_AddNewDetails.Location = new System.Drawing.Point(420, 417);
            this.btn_AddNewDetails.Name = "btn_AddNewDetails";
            this.btn_AddNewDetails.Size = new System.Drawing.Size(207, 50);
            this.btn_AddNewDetails.TabIndex = 88;
            this.btn_AddNewDetails.Text = "Add New Detail";
            this.btn_AddNewDetails.UseVisualStyleBackColor = true;
            this.btn_AddNewDetails.Click += new System.EventHandler(this.btn_AddNewDetails_Click);
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(197, 147);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(211, 27);
            this.txt_ProductID.TabIndex = 87;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(197, 212);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(211, 27);
            this.txt_UnitPrice.TabIndex = 83;
            this.txt_UnitPrice.UseSystemPasswordChar = true;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(197, 86);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(205, 27);
            this.txt_OrderID.TabIndex = 82;
            // 
            // lb_ProductId
            // 
            this.lb_ProductId.AutoSize = true;
            this.lb_ProductId.Location = new System.Drawing.Point(60, 154);
            this.lb_ProductId.Name = "lb_ProductId";
            this.lb_ProductId.Size = new System.Drawing.Size(79, 20);
            this.lb_ProductId.TabIndex = 81;
            this.lb_ProductId.Text = "Product ID";
            // 
            // lb_UnitPrice
            // 
            this.lb_UnitPrice.AutoSize = true;
            this.lb_UnitPrice.Location = new System.Drawing.Point(60, 219);
            this.lb_UnitPrice.Name = "lb_UnitPrice";
            this.lb_UnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lb_UnitPrice.TabIndex = 77;
            this.lb_UnitPrice.Text = "Unit Price";
            // 
            // lb_OrderID
            // 
            this.lb_OrderID.AutoSize = true;
            this.lb_OrderID.Location = new System.Drawing.Point(60, 92);
            this.lb_OrderID.Name = "lb_OrderID";
            this.lb_OrderID.Size = new System.Drawing.Size(64, 25);
            this.lb_OrderID.TabIndex = 76;
            this.lb_OrderID.Text = "Order ID";
            this.lb_OrderID.UseCompatibleTextRendering = true;
            // 
            // txt_Discount
            // 
            this.txt_Discount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Discount.Location = new System.Drawing.Point(197, 337);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.ReadOnly = true;
            this.txt_Discount.Size = new System.Drawing.Size(211, 27);
            this.txt_Discount.TabIndex = 98;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Quantity.Location = new System.Drawing.Point(197, 276);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.ReadOnly = true;
            this.txt_Quantity.Size = new System.Drawing.Size(211, 27);
            this.txt_Quantity.TabIndex = 97;
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Location = new System.Drawing.Point(60, 340);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(74, 20);
            this.lb_Discount.TabIndex = 96;
            this.lb_Discount.Text = "Discount :";
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Location = new System.Drawing.Point(60, 279);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(72, 20);
            this.lb_Quantity.TabIndex = 95;
            this.lb_Quantity.Text = "Quantity :";
            // 
            // frmOrderDetailManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 560);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lb_Discount);
            this.Controls.Add(this.lb_Quantity);
            this.Controls.Add(this.btn_DeleteDetail);
            this.Controls.Add(this.btn_UpdateDetail);
            this.Controls.Add(this.dgv_OrderDetailList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_AddNewDetails);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.lb_ProductId);
            this.Controls.Add(this.lb_UnitPrice);
            this.Controls.Add(this.lb_OrderID);
            this.Name = "frmOrderDetailManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetailManagement";
            this.Load += new System.EventHandler(this.frmOrderDetailManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_DeleteDetail;
        private Button btn_UpdateDetail;
        private DataGridView dgv_OrderDetailList;
        private Button btnClose;
        private Button btn_AddNewDetails;
        private TextBox txt_ProductID;
        private TextBox txt_UnitPrice;
        private TextBox txt_OrderID;
        private Label lb_ProductId;
        private Label lb_UnitPrice;
        private Label lb_OrderID;
        private TextBox txt_Discount;
        private TextBox txt_Quantity;
        private Label lb_Discount;
        private Label lb_Quantity;
    }
}