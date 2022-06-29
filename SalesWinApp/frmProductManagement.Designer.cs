﻿namespace SalesWinApp
{
    partial class frmProductManagement
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
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lb_CategoryID = new System.Windows.Forms.Label();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.dgv_OrderList = new System.Windows.Forms.DataGridView();
            this.btn_SearchProductName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_AddNewProduct = new System.Windows.Forms.Button();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.lbSearchProductID = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.btnSearchByFilter = new System.Windows.Forms.Button();
            this.txtSearchUnitPriceTo = new System.Windows.Forms.TextBox();
            this.lbSeparator = new System.Windows.Forms.Label();
            this.txtSearchUnitPriceFrom = new System.Windows.Forms.TextBox();
            this.lbSearchUnitPrice = new System.Windows.Forms.Label();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.lbSearchProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMemberID.Location = new System.Drawing.Point(176, 220);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(205, 27);
            this.txtMemberID.TabIndex = 134;
            // 
            // lb_CategoryID
            // 
            this.lb_CategoryID.AutoSize = true;
            this.lb_CategoryID.Location = new System.Drawing.Point(39, 223);
            this.lb_CategoryID.Name = "lb_CategoryID";
            this.lb_CategoryID.Size = new System.Drawing.Size(95, 20);
            this.lb_CategoryID.TabIndex = 132;
            this.lb_CategoryID.Text = "Category ID :";
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(861, 484);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(207, 50);
            this.btn_DeleteProduct.TabIndex = 131;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Location = new System.Drawing.Point(637, 484);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(207, 50);
            this.btn_UpdateProduct.TabIndex = 130;
            this.btn_UpdateProduct.Text = "Update Product";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // dgv_OrderList
            // 
            this.dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderList.Location = new System.Drawing.Point(406, 151);
            this.dgv_OrderList.Name = "dgv_OrderList";
            this.dgv_OrderList.ReadOnly = true;
            this.dgv_OrderList.RowHeadersWidth = 51;
            this.dgv_OrderList.RowTemplate.Height = 29;
            this.dgv_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderList.Size = new System.Drawing.Size(662, 312);
            this.dgv_OrderList.TabIndex = 127;
            // 
            // btn_SearchProductName
            // 
            this.btn_SearchProductName.Location = new System.Drawing.Point(790, 61);
            this.btn_SearchProductName.Name = "btn_SearchProductName";
            this.btn_SearchProductName.Size = new System.Drawing.Size(190, 29);
            this.btn_SearchProductName.TabIndex = 129;
            this.btn_SearchProductName.Text = "Search Product Name";
            this.btn_SearchProductName.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(39, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 50);
            this.btnClose.TabIndex = 128;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_AddNewProduct
            // 
            this.btn_AddNewProduct.Location = new System.Drawing.Point(406, 484);
            this.btn_AddNewProduct.Name = "btn_AddNewProduct";
            this.btn_AddNewProduct.Size = new System.Drawing.Size(207, 50);
            this.btn_AddNewProduct.TabIndex = 126;
            this.btn_AddNewProduct.Text = "Add New Product";
            this.btn_AddNewProduct.UseVisualStyleBackColor = true;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(176, 170);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(205, 27);
            this.txt_OrderID.TabIndex = 125;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(39, 176);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(78, 25);
            this.lb_ProductID.TabIndex = 124;
            this.lb_ProductID.Text = "Product ID";
            this.lb_ProductID.UseCompatibleTextRendering = true;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(790, 17);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(190, 29);
            this.btnSearchByID.TabIndex = 144;
            this.btnSearchByID.Text = "Search Product ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(540, 19);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(205, 27);
            this.txtSearchProductID.TabIndex = 143;
            // 
            // lbSearchProductID
            // 
            this.lbSearchProductID.AutoSize = true;
            this.lbSearchProductID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchProductID.Location = new System.Drawing.Point(406, 22);
            this.lbSearchProductID.Name = "lbSearchProductID";
            this.lbSearchProductID.Size = new System.Drawing.Size(82, 20);
            this.lbSearchProductID.TabIndex = 142;
            this.lbSearchProductID.Text = "ProductID :";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProductName.Location = new System.Drawing.Point(176, 271);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(205, 27);
            this.txtProductName.TabIndex = 146;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(39, 278);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(111, 20);
            this.lbProductName.TabIndex = 145;
            this.lbProductName.Text = "Product Name :";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnitsInStock.Location = new System.Drawing.Point(176, 428);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.ReadOnly = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(205, 27);
            this.txtUnitsInStock.TabIndex = 152;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnitPrice.Location = new System.Drawing.Point(176, 378);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(205, 27);
            this.txtUnitPrice.TabIndex = 151;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWeight.Location = new System.Drawing.Point(176, 329);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(205, 27);
            this.txtWeight.TabIndex = 150;
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(39, 435);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(105, 20);
            this.lbUnitsInStock.TabIndex = 149;
            this.lbUnitsInStock.Text = "Units In Stock :";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(39, 385);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(79, 20);
            this.lbUnitPrice.TabIndex = 148;
            this.lbUnitPrice.Text = "Unit Price :";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(39, 332);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(63, 20);
            this.lbWeight.TabIndex = 147;
            this.lbWeight.Text = "Weight :";
            // 
            // btnSearchByFilter
            // 
            this.btnSearchByFilter.Location = new System.Drawing.Point(790, 104);
            this.btnSearchByFilter.Name = "btnSearchByFilter";
            this.btnSearchByFilter.Size = new System.Drawing.Size(190, 29);
            this.btnSearchByFilter.TabIndex = 159;
            this.btnSearchByFilter.Text = "Filter";
            this.btnSearchByFilter.UseVisualStyleBackColor = true;
            // 
            // txtSearchUnitPriceTo
            // 
            this.txtSearchUnitPriceTo.Location = new System.Drawing.Point(687, 106);
            this.txtSearchUnitPriceTo.Name = "txtSearchUnitPriceTo";
            this.txtSearchUnitPriceTo.Size = new System.Drawing.Size(58, 27);
            this.txtSearchUnitPriceTo.TabIndex = 158;
            // 
            // lbSeparator
            // 
            this.lbSeparator.AutoSize = true;
            this.lbSeparator.Location = new System.Drawing.Point(656, 109);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(25, 20);
            this.lbSeparator.TabIndex = 157;
            this.lbSeparator.Text = "->";
            // 
            // txtSearchUnitPriceFrom
            // 
            this.txtSearchUnitPriceFrom.Location = new System.Drawing.Point(592, 106);
            this.txtSearchUnitPriceFrom.Name = "txtSearchUnitPriceFrom";
            this.txtSearchUnitPriceFrom.Size = new System.Drawing.Size(58, 27);
            this.txtSearchUnitPriceFrom.TabIndex = 156;
            // 
            // lbSearchUnitPrice
            // 
            this.lbSearchUnitPrice.AutoSize = true;
            this.lbSearchUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchUnitPrice.Location = new System.Drawing.Point(406, 109);
            this.lbSearchUnitPrice.Name = "lbSearchUnitPrice";
            this.lbSearchUnitPrice.Size = new System.Drawing.Size(167, 20);
            this.lbSearchUnitPrice.TabIndex = 155;
            this.lbSearchUnitPrice.Text = "Unit Price (From -> To) :";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(540, 67);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(205, 27);
            this.txtSearchProductName.TabIndex = 154;
            // 
            // lbSearchProductName
            // 
            this.lbSearchProductName.AutoSize = true;
            this.lbSearchProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchProductName.Location = new System.Drawing.Point(406, 70);
            this.lbSearchProductName.Name = "lbSearchProductName";
            this.lbSearchProductName.Size = new System.Drawing.Size(107, 20);
            this.lbSearchProductName.TabIndex = 153;
            this.lbSearchProductName.Text = "ProductName :";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 563);
            this.Controls.Add(this.btnSearchByFilter);
            this.Controls.Add(this.txtSearchUnitPriceTo);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.txtSearchUnitPriceFrom);
            this.Controls.Add(this.lbSearchUnitPrice);
            this.Controls.Add(this.txtSearchProductName);
            this.Controls.Add(this.lbSearchProductName);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.lbSearchProductID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lb_CategoryID);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.dgv_OrderList);
            this.Controls.Add(this.btn_SearchProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_AddNewProduct);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.lb_ProductID);
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMemberID;
        private Label lb_CategoryID;
        private Button btn_DeleteProduct;
        private Button btn_UpdateProduct;
        private DataGridView dgv_OrderList;
        private Button btn_SearchProductName;
        private Button btnClose;
        private Button btn_AddNewProduct;
        private TextBox txt_OrderID;
        private Label lb_ProductID;
        private Button btnSearchByID;
        private TextBox txtSearchProductID;
        private Label lbSearchProductID;
        private TextBox txtProductName;
        private Label lbProductName;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Button btnSearchByFilter;
        private TextBox txtSearchUnitPriceTo;
        private Label lbSeparator;
        private TextBox txtSearchUnitPriceFrom;
        private Label lbSearchUnitPrice;
        private TextBox txtSearchProductName;
        private Label lbSearchProductName;
    }
}