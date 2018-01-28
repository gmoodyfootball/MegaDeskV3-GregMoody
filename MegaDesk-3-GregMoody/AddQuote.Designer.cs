namespace MegaDesk_3_GregMoody
{
    partial class AddQuote
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
            this.cancelAddQuote = new System.Windows.Forms.Button();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.addQuoteWidthLabel = new System.Windows.Forms.Label();
            this.addQuoteDepthLabel = new System.Windows.Forms.Label();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            this.addQuoteDrawerLabel = new System.Windows.Forms.Label();
            this.numDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.addQuoteSurfaceLabel = new System.Windows.Forms.Label();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.rushDaysComboBox = new System.Windows.Forms.ComboBox();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddQuote
            // 
            this.cancelAddQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cancelAddQuote.Location = new System.Drawing.Point(47, 216);
            this.cancelAddQuote.Name = "cancelAddQuote";
            this.cancelAddQuote.Size = new System.Drawing.Size(120, 43);
            this.cancelAddQuote.TabIndex = 7;
            this.cancelAddQuote.Text = "Cancel";
            this.cancelAddQuote.UseVisualStyleBackColor = true;
            this.cancelAddQuote.Click += new System.EventHandler(this.cancelAddQuote_Click);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.widthUpDown.Location = new System.Drawing.Point(180, 56);
            this.widthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 26);
            this.widthUpDown.TabIndex = 1;
            this.widthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.widthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // addQuoteWidthLabel
            // 
            this.addQuoteWidthLabel.AutoSize = true;
            this.addQuoteWidthLabel.CausesValidation = false;
            this.addQuoteWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addQuoteWidthLabel.Location = new System.Drawing.Point(67, 56);
            this.addQuoteWidthLabel.Name = "addQuoteWidthLabel";
            this.addQuoteWidthLabel.Size = new System.Drawing.Size(98, 20);
            this.addQuoteWidthLabel.TabIndex = 3;
            this.addQuoteWidthLabel.Text = "Table Width";
            // 
            // addQuoteDepthLabel
            // 
            this.addQuoteDepthLabel.AutoSize = true;
            this.addQuoteDepthLabel.CausesValidation = false;
            this.addQuoteDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addQuoteDepthLabel.Location = new System.Drawing.Point(67, 89);
            this.addQuoteDepthLabel.Name = "addQuoteDepthLabel";
            this.addQuoteDepthLabel.Size = new System.Drawing.Size(100, 20);
            this.addQuoteDepthLabel.TabIndex = 4;
            this.addQuoteDepthLabel.Text = "Table Depth";
            // 
            // depthUpDown
            // 
            this.depthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.depthUpDown.Location = new System.Drawing.Point(180, 89);
            this.depthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(120, 26);
            this.depthUpDown.TabIndex = 2;
            this.depthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.depthUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.depthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // addQuoteDrawerLabel
            // 
            this.addQuoteDrawerLabel.AutoSize = true;
            this.addQuoteDrawerLabel.CausesValidation = false;
            this.addQuoteDrawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addQuoteDrawerLabel.Location = new System.Drawing.Point(61, 121);
            this.addQuoteDrawerLabel.Name = "addQuoteDrawerLabel";
            this.addQuoteDrawerLabel.Size = new System.Drawing.Size(106, 20);
            this.addQuoteDrawerLabel.TabIndex = 6;
            this.addQuoteDrawerLabel.Text = "# of Drawers";
            // 
            // numDrawersUpDown
            // 
            this.numDrawersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numDrawersUpDown.Location = new System.Drawing.Point(180, 121);
            this.numDrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawersUpDown.Name = "numDrawersUpDown";
            this.numDrawersUpDown.Size = new System.Drawing.Size(120, 26);
            this.numDrawersUpDown.TabIndex = 3;
            this.numDrawersUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDrawersUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.DisplayMember = "Oak";
            this.surfaceMaterialComboBox.DropDownHeight = 125;
            this.surfaceMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.IntegralHeight = false;
            this.surfaceMaterialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(180, 153);
            this.surfaceMaterialComboBox.MaxDropDownItems = 5;
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(120, 26);
            this.surfaceMaterialComboBox.Sorted = true;
            this.surfaceMaterialComboBox.TabIndex = 4;
            this.surfaceMaterialComboBox.Text = "Pine";
            // 
            // addQuoteSurfaceLabel
            // 
            this.addQuoteSurfaceLabel.AutoSize = true;
            this.addQuoteSurfaceLabel.CausesValidation = false;
            this.addQuoteSurfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addQuoteSurfaceLabel.Location = new System.Drawing.Point(35, 153);
            this.addQuoteSurfaceLabel.Name = "addQuoteSurfaceLabel";
            this.addQuoteSurfaceLabel.Size = new System.Drawing.Size(132, 20);
            this.addQuoteSurfaceLabel.TabIndex = 7;
            this.addQuoteSurfaceLabel.Text = "Surface Material";
            // 
            // rushDaysLabel
            // 
            this.rushDaysLabel.AutoSize = true;
            this.rushDaysLabel.CausesValidation = false;
            this.rushDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rushDaysLabel.Location = new System.Drawing.Point(73, 184);
            this.rushDaysLabel.Name = "rushDaysLabel";
            this.rushDaysLabel.Size = new System.Drawing.Size(92, 20);
            this.rushDaysLabel.TabIndex = 4;
            this.rushDaysLabel.Text = "Rush Days";
            // 
            // rushDaysComboBox
            // 
            this.rushDaysComboBox.DisplayMember = "Oak";
            this.rushDaysComboBox.DropDownHeight = 126;
            this.rushDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rushDaysComboBox.FormattingEnabled = true;
            this.rushDaysComboBox.IntegralHeight = false;
            this.rushDaysComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushDaysComboBox.Location = new System.Drawing.Point(180, 184);
            this.rushDaysComboBox.MaxDropDownItems = 3;
            this.rushDaysComboBox.Name = "rushDaysComboBox";
            this.rushDaysComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rushDaysComboBox.Size = new System.Drawing.Size(120, 26);
            this.rushDaysComboBox.Sorted = true;
            this.rushDaysComboBox.TabIndex = 5;
            this.rushDaysComboBox.Text = "3";
            this.rushDaysComboBox.ValueMember = "3";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.getQuoteButton.Location = new System.Drawing.Point(179, 216);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(120, 43);
            this.getQuoteButton.TabIndex = 6;
            this.getQuoteButton.Text = "Get Quote!";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.customerNameTextBox.Location = new System.Drawing.Point(180, 22);
            this.customerNameTextBox.MaxLength = 50;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(120, 26);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.Text = "John";
            this.customerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.CausesValidation = false;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.customerNameLabel.Location = new System.Drawing.Point(36, 26);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(131, 20);
            this.customerNameLabel.TabIndex = 11;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelAddQuote;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.rushDaysComboBox);
            this.Controls.Add(this.addQuoteSurfaceLabel);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.addQuoteDrawerLabel);
            this.Controls.Add(this.numDrawersUpDown);
            this.Controls.Add(this.addQuoteDepthLabel);
            this.Controls.Add(this.depthUpDown);
            this.Controls.Add(this.addQuoteWidthLabel);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.cancelAddQuote);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddQuote;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Label addQuoteWidthLabel;
        private System.Windows.Forms.Label addQuoteDepthLabel;
        private System.Windows.Forms.NumericUpDown depthUpDown;
        private System.Windows.Forms.Label addQuoteDrawerLabel;
        private System.Windows.Forms.NumericUpDown numDrawersUpDown;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.Label addQuoteSurfaceLabel;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.ComboBox rushDaysComboBox;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
    }
}