namespace SalesWinApp
{
    partial class frmOrderHistory
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
            this.dgv_OrderHistory = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderHistory
            // 
            this.dgv_OrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderHistory.Location = new System.Drawing.Point(106, 83);
            this.dgv_OrderHistory.Name = "dgv_OrderHistory";
            this.dgv_OrderHistory.ReadOnly = true;
            this.dgv_OrderHistory.RowHeadersWidth = 51;
            this.dgv_OrderHistory.RowTemplate.Height = 29;
            this.dgv_OrderHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderHistory.Size = new System.Drawing.Size(588, 285);
            this.dgv_OrderHistory.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(348, 393);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // frmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_OrderHistory);
            this.Name = "frmOrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_OrderHistory;
        private Button btn_Close;
    }
}