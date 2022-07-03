namespace SalesWinApp
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
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lb_CategoryID = new System.Windows.Forms.Label();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.btn_SearchProductName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_AddNewProduct = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCategoryID.Location = new System.Drawing.Point(154, 165);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(180, 23);
            this.txtCategoryID.TabIndex = 134;
            // 
            // lb_CategoryID
            // 
            this.lb_CategoryID.AutoSize = true;
            this.lb_CategoryID.Location = new System.Drawing.Point(34, 167);
            this.lb_CategoryID.Name = "lb_CategoryID";
            this.lb_CategoryID.Size = new System.Drawing.Size(75, 15);
            this.lb_CategoryID.TabIndex = 132;
            this.lb_CategoryID.Text = "Category ID :";
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(753, 363);
            this.btn_DeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(181, 38);
            this.btn_DeleteProduct.TabIndex = 131;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Location = new System.Drawing.Point(557, 363);
            this.btn_UpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(181, 38);
            this.btn_UpdateProduct.TabIndex = 130;
            this.btn_UpdateProduct.Text = "Update Product";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(355, 113);
            this.dgv_ProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 29;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(579, 234);
            this.dgv_ProductList.TabIndex = 127;
            // 
            // btn_SearchProductName
            // 
            this.btn_SearchProductName.Location = new System.Drawing.Point(691, 46);
            this.btn_SearchProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SearchProductName.Name = "btn_SearchProductName";
            this.btn_SearchProductName.Size = new System.Drawing.Size(166, 22);
            this.btn_SearchProductName.TabIndex = 129;
            this.btn_SearchProductName.Text = "Search Product Name";
            this.btn_SearchProductName.UseVisualStyleBackColor = true;
            this.btn_SearchProductName.Click += new System.EventHandler(this.btn_SearchProductName_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(34, 363);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 38);
            this.btnClose.TabIndex = 128;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_AddNewProduct
            // 
            this.btn_AddNewProduct.Location = new System.Drawing.Point(355, 363);
            this.btn_AddNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNewProduct.Name = "btn_AddNewProduct";
            this.btn_AddNewProduct.Size = new System.Drawing.Size(181, 38);
            this.btn_AddNewProduct.TabIndex = 126;
            this.btn_AddNewProduct.Text = "Add New Product";
            this.btn_AddNewProduct.UseVisualStyleBackColor = true;
            this.btn_AddNewProduct.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(154, 128);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(180, 23);
            this.txtProductID.TabIndex = 125;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(34, 132);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(62, 21);
            this.lb_ProductID.TabIndex = 124;
            this.lb_ProductID.Text = "Product ID";
            this.lb_ProductID.UseCompatibleTextRendering = true;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(691, 13);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(166, 22);
            this.btnSearchByID.TabIndex = 144;
            this.btnSearchByID.Text = "Search Product ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(472, 14);
            this.txtSearchProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(180, 23);
            this.txtSearchProductID.TabIndex = 143;
            // 
            // lbSearchProductID
            // 
            this.lbSearchProductID.AutoSize = true;
            this.lbSearchProductID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchProductID.Location = new System.Drawing.Point(355, 16);
            this.lbSearchProductID.Name = "lbSearchProductID";
            this.lbSearchProductID.Size = new System.Drawing.Size(66, 15);
            this.lbSearchProductID.TabIndex = 142;
            this.lbSearchProductID.Text = "ProductID :";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProductName.Location = new System.Drawing.Point(154, 203);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(180, 23);
            this.txtProductName.TabIndex = 146;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(34, 208);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(90, 15);
            this.lbProductName.TabIndex = 145;
            this.lbProductName.Text = "Product Name :";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnitsInStock.Location = new System.Drawing.Point(154, 321);
            this.txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.ReadOnly = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(180, 23);
            this.txtUnitsInStock.TabIndex = 152;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnitPrice.Location = new System.Drawing.Point(154, 284);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(180, 23);
            this.txtUnitPrice.TabIndex = 151;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWeight.Location = new System.Drawing.Point(154, 247);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(180, 23);
            this.txtWeight.TabIndex = 150;
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Location = new System.Drawing.Point(34, 326);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(85, 15);
            this.lbUnitsInStock.TabIndex = 149;
            this.lbUnitsInStock.Text = "Units In Stock :";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(34, 289);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(64, 15);
            this.lbUnitPrice.TabIndex = 148;
            this.lbUnitPrice.Text = "Unit Price :";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(34, 249);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(51, 15);
            this.lbWeight.TabIndex = 147;
            this.lbWeight.Text = "Weight :";
            // 
            // btnSearchByFilter
            // 
            this.btnSearchByFilter.Location = new System.Drawing.Point(691, 78);
            this.btnSearchByFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByFilter.Name = "btnSearchByFilter";
            this.btnSearchByFilter.Size = new System.Drawing.Size(166, 22);
            this.btnSearchByFilter.TabIndex = 159;
            this.btnSearchByFilter.Text = "Filter";
            this.btnSearchByFilter.UseVisualStyleBackColor = true;
            this.btnSearchByFilter.Click += new System.EventHandler(this.btnSearchByFilter_Click);
            // 
            // txtSearchUnitPriceTo
            // 
            this.txtSearchUnitPriceTo.Location = new System.Drawing.Point(601, 80);
            this.txtSearchUnitPriceTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchUnitPriceTo.Name = "txtSearchUnitPriceTo";
            this.txtSearchUnitPriceTo.Size = new System.Drawing.Size(51, 23);
            this.txtSearchUnitPriceTo.TabIndex = 158;
            // 
            // lbSeparator
            // 
            this.lbSeparator.AutoSize = true;
            this.lbSeparator.Location = new System.Drawing.Point(574, 82);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(20, 15);
            this.lbSeparator.TabIndex = 157;
            this.lbSeparator.Text = "->";
            // 
            // txtSearchUnitPriceFrom
            // 
            this.txtSearchUnitPriceFrom.Location = new System.Drawing.Point(518, 80);
            this.txtSearchUnitPriceFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchUnitPriceFrom.Name = "txtSearchUnitPriceFrom";
            this.txtSearchUnitPriceFrom.Size = new System.Drawing.Size(51, 23);
            this.txtSearchUnitPriceFrom.TabIndex = 156;
            // 
            // lbSearchUnitPrice
            // 
            this.lbSearchUnitPrice.AutoSize = true;
            this.lbSearchUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchUnitPrice.Location = new System.Drawing.Point(355, 82);
            this.lbSearchUnitPrice.Name = "lbSearchUnitPrice";
            this.lbSearchUnitPrice.Size = new System.Drawing.Size(134, 15);
            this.lbSearchUnitPrice.TabIndex = 155;
            this.lbSearchUnitPrice.Text = "Unit Price (From -> To) :";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(472, 50);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(180, 23);
            this.txtSearchProductName.TabIndex = 154;
            // 
            // lbSearchProductName
            // 
            this.lbSearchProductName.AutoSize = true;
            this.lbSearchProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchProductName.Location = new System.Drawing.Point(355, 52);
            this.lbSearchProductName.Name = "lbSearchProductName";
            this.lbSearchProductName.Size = new System.Drawing.Size(87, 15);
            this.lbSearchProductName.TabIndex = 153;
            this.lbSearchProductName.Text = "ProductName :";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 422);
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
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.lb_CategoryID);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.btn_SearchProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_AddNewProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lb_ProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCategoryID;
        private Label lb_CategoryID;
        private Button btn_DeleteProduct;
        private Button btn_UpdateProduct;
        private DataGridView dgv_ProductList;
        private Button btn_SearchProductName;
        private Button btnClose;
        private Button btn_AddNewProduct;
        private TextBox txtProductID;
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