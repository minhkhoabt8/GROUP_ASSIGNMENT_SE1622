namespace SalesWinApp
{
    partial class frmOrderManagement
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
            this.btn_DeleteOrder = new System.Windows.Forms.Button();
            this.btn_UpdateOrder = new System.Windows.Forms.Button();
            this.dgv_OrderList = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_AddNewOrder = new System.Windows.Forms.Button();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lb_OrderID = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteOrder
            // 
            this.btn_DeleteOrder.Location = new System.Drawing.Point(885, 423);
            this.btn_DeleteOrder.Name = "btn_DeleteOrder";
            this.btn_DeleteOrder.Size = new System.Drawing.Size(207, 50);
            this.btn_DeleteOrder.TabIndex = 111;
            this.btn_DeleteOrder.Text = "Delete Order";
            this.btn_DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateOrder
            // 
            this.btn_UpdateOrder.Location = new System.Drawing.Point(658, 423);
            this.btn_UpdateOrder.Name = "btn_UpdateOrder";
            this.btn_UpdateOrder.Size = new System.Drawing.Size(207, 50);
            this.btn_UpdateOrder.TabIndex = 110;
            this.btn_UpdateOrder.Text = "Update Order";
            this.btn_UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // dgv_OrderList
            // 
            this.dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderList.Location = new System.Drawing.Point(430, 73);
            this.dgv_OrderList.Name = "dgv_OrderList";
            this.dgv_OrderList.ReadOnly = true;
            this.dgv_OrderList.RowHeadersWidth = 51;
            this.dgv_OrderList.RowTemplate.Height = 29;
            this.dgv_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderList.Size = new System.Drawing.Size(662, 312);
            this.dgv_OrderList.TabIndex = 106;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(962, 31);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 29);
            this.btn_Search.TabIndex = 109;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_SearchValue
            // 
            this.txt_SearchValue.Location = new System.Drawing.Point(516, 31);
            this.txt_SearchValue.Name = "txt_SearchValue";
            this.txt_SearchValue.Size = new System.Drawing.Size(427, 27);
            this.txt_SearchValue.TabIndex = 108;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(710, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn_AddNewOrder
            // 
            this.btn_AddNewOrder.Location = new System.Drawing.Point(430, 423);
            this.btn_AddNewOrder.Name = "btn_AddNewOrder";
            this.btn_AddNewOrder.Size = new System.Drawing.Size(207, 50);
            this.btn_AddNewOrder.TabIndex = 105;
            this.btn_AddNewOrder.Text = "Add New Order";
            this.btn_AddNewOrder.UseVisualStyleBackColor = true;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(207, 92);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(205, 27);
            this.txt_OrderID.TabIndex = 102;
            // 
            // lb_OrderID
            // 
            this.lb_OrderID.AutoSize = true;
            this.lb_OrderID.Location = new System.Drawing.Point(70, 98);
            this.lb_OrderID.Name = "lb_OrderID";
            this.lb_OrderID.Size = new System.Drawing.Size(64, 25);
            this.lb_OrderID.TabIndex = 99;
            this.lb_OrderID.Text = "Order ID";
            this.lb_OrderID.UseCompatibleTextRendering = true;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtShippedDate.Location = new System.Drawing.Point(207, 345);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(205, 27);
            this.txtShippedDate.TabIndex = 123;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(70, 352);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(107, 20);
            this.lbShippedDate.TabIndex = 122;
            this.lbShippedDate.Text = "Shipped Date :";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRequiredDate.Location = new System.Drawing.Point(207, 296);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(205, 27);
            this.txtRequiredDate.TabIndex = 121;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(70, 303);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(112, 20);
            this.lbRequiredDate.TabIndex = 120;
            this.lbRequiredDate.Text = "Required Date :";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOrderDate.Location = new System.Drawing.Point(207, 243);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(205, 27);
            this.txtOrderDate.TabIndex = 119;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(70, 250);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(90, 20);
            this.lbOrderDate.TabIndex = 118;
            this.lbOrderDate.Text = "Order Date :";
            // 
            // txtFreight
            // 
            this.txtFreight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFreight.Location = new System.Drawing.Point(207, 192);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(205, 27);
            this.txtFreight.TabIndex = 117;
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMemberID.Location = new System.Drawing.Point(207, 142);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(205, 27);
            this.txtMemberID.TabIndex = 116;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(70, 199);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(62, 20);
            this.lbFreight.TabIndex = 114;
            this.lbFreight.Text = "Freight :";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(70, 145);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(91, 20);
            this.lbMemberID.TabIndex = 113;
            this.lbMemberID.Text = "Member ID :";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 573);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.btn_DeleteOrder);
            this.Controls.Add(this.btn_UpdateOrder);
            this.Controls.Add(this.dgv_OrderList);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_AddNewOrder);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.lb_OrderID);
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_DeleteOrder;
        private Button btn_UpdateOrder;
        private DataGridView dgv_OrderList;
        private Button btn_Search;
        private TextBox txt_SearchValue;
        private Button btnClose;
        private Button btn_AddNewOrder;
        private TextBox txt_OrderID;
        private Label lb_OrderID;
        private TextBox txtShippedDate;
        private Label lbShippedDate;
        private TextBox txtRequiredDate;
        private Label lbRequiredDate;
        private TextBox txtOrderDate;
        private Label lbOrderDate;
        private TextBox txtFreight;
        private TextBox txtMemberID;
        private Label lbFreight;
        private Label lbMemberID;
    }
}