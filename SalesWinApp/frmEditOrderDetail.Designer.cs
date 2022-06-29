namespace SalesWinApp
{
    partial class frmEditOrderDetail
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
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lb_Discount = new System.Windows.Forms.Label();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.lb_UnitPrice = new System.Windows.Forms.Label();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.lb_OrderID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(157, 245);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(219, 27);
            this.txt_Discount.TabIndex = 19;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(157, 196);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(219, 27);
            this.txt_Quantity.TabIndex = 18;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(157, 151);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(219, 27);
            this.txt_UnitPrice.TabIndex = 17;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(157, 99);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(219, 27);
            this.txt_ProductID.TabIndex = 16;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(157, 55);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(219, 27);
            this.txt_OrderID.TabIndex = 15;
            // 
            // lb_Discount
            // 
            this.lb_Discount.AutoSize = true;
            this.lb_Discount.Location = new System.Drawing.Point(69, 248);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(74, 20);
            this.lb_Discount.TabIndex = 14;
            this.lb_Discount.Text = "Discount :";
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Location = new System.Drawing.Point(69, 199);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(72, 20);
            this.lb_Quantity.TabIndex = 13;
            this.lb_Quantity.Text = "Quantity :";
            // 
            // lb_UnitPrice
            // 
            this.lb_UnitPrice.AutoSize = true;
            this.lb_UnitPrice.Location = new System.Drawing.Point(69, 154);
            this.lb_UnitPrice.Name = "lb_UnitPrice";
            this.lb_UnitPrice.Size = new System.Drawing.Size(79, 20);
            this.lb_UnitPrice.TabIndex = 12;
            this.lb_UnitPrice.Text = "Unit Price :";
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(69, 106);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(86, 20);
            this.lb_ProductID.TabIndex = 11;
            this.lb_ProductID.Text = "Product ID :";
            // 
            // lb_OrderID
            // 
            this.lb_OrderID.AutoSize = true;
            this.lb_OrderID.Location = new System.Drawing.Point(69, 58);
            this.lb_OrderID.Name = "lb_OrderID";
            this.lb_OrderID.Size = new System.Drawing.Size(73, 20);
            this.lb_OrderID.TabIndex = 10;
            this.lb_OrderID.Text = "Order ID :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(282, 327);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(69, 327);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEditOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.lb_Discount);
            this.Controls.Add(this.lb_Quantity);
            this.Controls.Add(this.lb_UnitPrice);
            this.Controls.Add(this.lb_ProductID);
            this.Controls.Add(this.lb_OrderID);
            this.Name = "frmEditOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Discount;
        private TextBox txt_Quantity;
        private TextBox txt_UnitPrice;
        private TextBox txt_ProductID;
        private TextBox txt_OrderID;
        private Label lb_Discount;
        private Label lb_Quantity;
        private Label lb_UnitPrice;
        private Label lb_ProductID;
        private Label lb_OrderID;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}