namespace SalesWinApp
{
    partial class frmEditProduct
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
            this.txt_UnitsInStock = new System.Windows.Forms.TextBox();
            this.lb_UnitsInStock = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.lb_UnitPrice = new System.Windows.Forms.Label();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.lb_Weight = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.lb_CategoryID = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_UnitsInStock
            // 
            this.txt_UnitsInStock.Location = new System.Drawing.Point(177, 281);
            this.txt_UnitsInStock.Name = "txt_UnitsInStock";
            this.txt_UnitsInStock.Size = new System.Drawing.Size(190, 27);
            this.txt_UnitsInStock.TabIndex = 23;
            // 
            // lb_UnitsInStock
            // 
            this.lb_UnitsInStock.AutoSize = true;
            this.lb_UnitsInStock.Location = new System.Drawing.Point(60, 284);
            this.lb_UnitsInStock.Name = "lb_UnitsInStock";
            this.lb_UnitsInStock.Size = new System.Drawing.Size(105, 20);
            this.lb_UnitsInStock.TabIndex = 22;
            this.lb_UnitsInStock.Text = "Units In Stock :";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(177, 236);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(190, 27);
            this.txt_UnitPrice.TabIndex = 21;
            // 
            // lb_UnitPrice
            // 
            this.lb_UnitPrice.AutoSize = true;
            this.lb_UnitPrice.Location = new System.Drawing.Point(60, 239);
            this.lb_UnitPrice.Name = "lb_UnitPrice";
            this.lb_UnitPrice.Size = new System.Drawing.Size(79, 20);
            this.lb_UnitPrice.TabIndex = 20;
            this.lb_UnitPrice.Text = "Unit Price :";
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(177, 189);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(190, 27);
            this.txt_Weight.TabIndex = 19;
            // 
            // lb_Weight
            // 
            this.lb_Weight.AutoSize = true;
            this.lb_Weight.Location = new System.Drawing.Point(60, 192);
            this.lb_Weight.Name = "lb_Weight";
            this.lb_Weight.Size = new System.Drawing.Size(63, 20);
            this.lb_Weight.TabIndex = 18;
            this.lb_Weight.Text = "Weight :";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(177, 140);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(190, 27);
            this.txt_ProductName.TabIndex = 17;
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(60, 143);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(111, 20);
            this.lb_ProductName.TabIndex = 16;
            this.lb_ProductName.Text = "Product Name :";
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.Location = new System.Drawing.Point(177, 92);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(190, 27);
            this.txt_CategoryID.TabIndex = 15;
            // 
            // lb_CategoryID
            // 
            this.lb_CategoryID.AutoSize = true;
            this.lb_CategoryID.Location = new System.Drawing.Point(60, 99);
            this.lb_CategoryID.Name = "lb_CategoryID";
            this.lb_CategoryID.Size = new System.Drawing.Size(91, 20);
            this.lb_CategoryID.TabIndex = 14;
            this.lb_CategoryID.Text = "CategoryID :";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(177, 48);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(190, 27);
            this.txt_ProductID.TabIndex = 13;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(60, 51);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(82, 20);
            this.lb_ProductID.TabIndex = 12;
            this.lb_ProductID.Text = "ProductID :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(273, 364);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(60, 364);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_UnitsInStock);
            this.Controls.Add(this.lb_UnitsInStock);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.lb_UnitPrice);
            this.Controls.Add(this.txt_Weight);
            this.Controls.Add(this.lb_Weight);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lb_ProductName);
            this.Controls.Add(this.txt_CategoryID);
            this.Controls.Add(this.lb_CategoryID);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.lb_ProductID);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_UnitsInStock;
        private Label lb_UnitsInStock;
        private TextBox txt_UnitPrice;
        private Label lb_UnitPrice;
        private TextBox txt_Weight;
        private Label lb_Weight;
        private TextBox txt_ProductName;
        private Label lb_ProductName;
        private TextBox txt_CategoryID;
        private Label lb_CategoryID;
        private TextBox txt_ProductID;
        private Label lb_ProductID;
        private Button btn_Cancel;
        private Button btn_Save;
    }
}