namespace MegaDeskV3_GregMoody
{
    partial class SearchQuotes
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
            this.cancelSearchQuotes = new System.Windows.Forms.Button();
            this.searchQuotesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearchQuotes
            // 
            this.cancelSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelSearchQuotes.Location = new System.Drawing.Point(529, 239);
            this.cancelSearchQuotes.Name = "cancelSearchQuotes";
            this.cancelSearchQuotes.Size = new System.Drawing.Size(100, 26);
            this.cancelSearchQuotes.TabIndex = 0;
            this.cancelSearchQuotes.Tag = "";
            this.cancelSearchQuotes.Text = "Main Menu";
            this.cancelSearchQuotes.UseVisualStyleBackColor = true;
            this.cancelSearchQuotes.Click += new System.EventHandler(this.cancelSearchQuotes_Click);
            // 
            // searchQuotesDataGridView
            // 
            this.searchQuotesDataGridView.AllowUserToAddRows = false;
            this.searchQuotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.searchQuotesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.searchQuotesDataGridView.Name = "searchQuotesDataGridView";
            this.searchQuotesDataGridView.Size = new System.Drawing.Size(847, 209);
            this.searchQuotesDataGridView.TabIndex = 2;
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
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.DisplayMember = "Oak";
            this.surfaceMaterialComboBox.DropDownHeight = 125;
            this.surfaceMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.IntegralHeight = false;
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(270, 239);
            this.surfaceMaterialComboBox.MaxDropDownItems = 5;
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(147, 26);
            this.surfaceMaterialComboBox.Sorted = true;
            this.surfaceMaterialComboBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchButton.Location = new System.Drawing.Point(423, 239);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 26);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelSearchQuotes;
            this.ClientSize = new System.Drawing.Size(869, 288);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.searchQuotesDataGridView);
            this.Controls.Add(this.cancelSearchQuotes);
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuotes;
        private System.Windows.Forms.DataGridView searchQuotesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.Button searchButton;
    }
}