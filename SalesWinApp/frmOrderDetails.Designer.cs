namespace SalesWinApp
{
    partial class frmOrderDetails
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
            this.txt_TotalOrderPrice = new System.Windows.Forms.TextBox();
            this.lb_TotalOrderPrice = new System.Windows.Forms.Label();
            this.txt_CurrentOrderID = new System.Windows.Forms.TextBox();
            this.dgv_OrderDetails = new System.Windows.Forms.DataGridView();
            this.lb_OrderID = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TotalOrderPrice
            // 
            this.txt_TotalOrderPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TotalOrderPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalOrderPrice.Location = new System.Drawing.Point(604, 409);
            this.txt_TotalOrderPrice.Name = "txt_TotalOrderPrice";
            this.txt_TotalOrderPrice.ReadOnly = true;
            this.txt_TotalOrderPrice.Size = new System.Drawing.Size(129, 27);
            this.txt_TotalOrderPrice.TabIndex = 13;
            // 
            // lb_TotalOrderPrice
            // 
            this.lb_TotalOrderPrice.AutoSize = true;
            this.lb_TotalOrderPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TotalOrderPrice.Location = new System.Drawing.Point(466, 412);
            this.lb_TotalOrderPrice.Name = "lb_TotalOrderPrice";
            this.lb_TotalOrderPrice.Size = new System.Drawing.Size(132, 20);
            this.lb_TotalOrderPrice.TabIndex = 12;
            this.lb_TotalOrderPrice.Text = "Total Order Price: ";
            // 
            // txt_CurrentOrderID
            // 
            this.txt_CurrentOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_CurrentOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_CurrentOrderID.Location = new System.Drawing.Point(192, 49);
            this.txt_CurrentOrderID.Name = "txt_CurrentOrderID";
            this.txt_CurrentOrderID.ReadOnly = true;
            this.txt_CurrentOrderID.Size = new System.Drawing.Size(112, 27);
            this.txt_CurrentOrderID.TabIndex = 11;
            // 
            // dgv_OrderDetails
            // 
            this.dgv_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetails.Enabled = false;
            this.dgv_OrderDetails.Location = new System.Drawing.Point(65, 97);
            this.dgv_OrderDetails.Name = "dgv_OrderDetails";
            this.dgv_OrderDetails.ReadOnly = true;
            this.dgv_OrderDetails.RowHeadersWidth = 51;
            this.dgv_OrderDetails.RowTemplate.Height = 29;
            this.dgv_OrderDetails.Size = new System.Drawing.Size(668, 297);
            this.dgv_OrderDetails.TabIndex = 8;
            // 
            // lb_OrderID
            // 
            this.lb_OrderID.AutoSize = true;
            this.lb_OrderID.Location = new System.Drawing.Point(111, 56);
            this.lb_OrderID.Name = "lb_OrderID";
            this.lb_OrderID.Size = new System.Drawing.Size(66, 20);
            this.lb_OrderID.TabIndex = 14;
            this.lb_OrderID.Text = "Order ID";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(350, 455);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_OrderID);
            this.Controls.Add(this.txt_TotalOrderPrice);
            this.Controls.Add(this.lb_TotalOrderPrice);
            this.Controls.Add(this.txt_CurrentOrderID);
            this.Controls.Add(this.dgv_OrderDetails);
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_TotalOrderPrice;
        private Label lb_TotalOrderPrice;
        private TextBox txt_CurrentOrderID;
        private DataGridView dgv_OrderDetails;
        private Label lb_OrderID;
        private Button btn_Close;
    }
}