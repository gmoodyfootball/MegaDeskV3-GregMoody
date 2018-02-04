namespace MegaDesk_2_GregMoody
{
    partial class ViewQuote
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
            this.cancelViewQuote = new System.Windows.Forms.Button();
            this.viewQuotesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelViewQuote
            // 
            this.cancelViewQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelViewQuote.Location = new System.Drawing.Point(422, 227);
            this.cancelViewQuote.Name = "cancelViewQuote";
            this.cancelViewQuote.Size = new System.Drawing.Size(75, 23);
            this.cancelViewQuote.TabIndex = 0;
            this.cancelViewQuote.Text = "Cancel";
            this.cancelViewQuote.UseVisualStyleBackColor = true;
            this.cancelViewQuote.Click += new System.EventHandler(this.cancelViewQuote_Click);
            // 
            // viewQuotesDataGridView
            // 
            this.viewQuotesDataGridView.AllowUserToAddRows = false;
            this.viewQuotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.viewQuotesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.viewQuotesDataGridView.Name = "viewQuotesDataGridView";
            this.viewQuotesDataGridView.Size = new System.Drawing.Size(847, 209);
            this.viewQuotesDataGridView.TabIndex = 1;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Customer Name";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surface Material";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Width";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Depth";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Drawers";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rush Days";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Price";
            this.Column7.Name = "Column7";
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelViewQuote;
            this.ClientSize = new System.Drawing.Size(871, 262);
            this.Controls.Add(this.viewQuotesDataGridView);
            this.Controls.Add(this.cancelViewQuote);
            this.MaximizeBox = false;
            this.Name = "ViewQuote";
            this.Text = "View Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewQuote_FormClosed);
            this.Load += new System.EventHandler(this.ViewQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewQuote;
        private System.Windows.Forms.DataGridView viewQuotesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}