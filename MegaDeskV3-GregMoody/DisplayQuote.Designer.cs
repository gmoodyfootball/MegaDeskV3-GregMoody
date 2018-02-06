namespace MegaDeskV3_GregMoody
{
    partial class DisplayQuote
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
            this.DQdoneButton = new System.Windows.Forms.Button();
            this.DQwidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.addQuoteWidthLabel = new System.Windows.Forms.Label();
            this.addQuoteDepthLabel = new System.Windows.Forms.Label();
            this.DQdepthUpDown = new System.Windows.Forms.NumericUpDown();
            this.addQuoteDrawerLabel = new System.Windows.Forms.Label();
            this.DQnumDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.DQsurfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.addQuoteSurfaceLabel = new System.Windows.Forms.Label();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.DQrushDaysComboBox = new System.Windows.Forms.ComboBox();
            this.DQcustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.DQtotalCostLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DQwidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQdepthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQnumDrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DQdoneButton
            // 
            this.DQdoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DQdoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQdoneButton.Location = new System.Drawing.Point(39, 221);
            this.DQdoneButton.Name = "DQdoneButton";
            this.DQdoneButton.Size = new System.Drawing.Size(78, 33);
            this.DQdoneButton.TabIndex = 7;
            this.DQdoneButton.Text = "Ok";
            this.DQdoneButton.UseVisualStyleBackColor = true;
            this.DQdoneButton.Click += new System.EventHandler(this.cancelAddQuote_Click);
            // 
            // DQwidthUpDown
            // 
            this.DQwidthUpDown.Enabled = false;
            this.DQwidthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQwidthUpDown.Location = new System.Drawing.Point(180, 56);
            this.DQwidthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.DQwidthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DQwidthUpDown.Name = "DQwidthUpDown";
            this.DQwidthUpDown.Size = new System.Drawing.Size(120, 26);
            this.DQwidthUpDown.TabIndex = 1;
            this.DQwidthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DQwidthUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.DQwidthUpDown.Value = new decimal(new int[] {
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
            // DQdepthUpDown
            // 
            this.DQdepthUpDown.Enabled = false;
            this.DQdepthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQdepthUpDown.Location = new System.Drawing.Point(180, 89);
            this.DQdepthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DQdepthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DQdepthUpDown.Name = "DQdepthUpDown";
            this.DQdepthUpDown.Size = new System.Drawing.Size(120, 26);
            this.DQdepthUpDown.TabIndex = 2;
            this.DQdepthUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DQdepthUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.DQdepthUpDown.Value = new decimal(new int[] {
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
            // DQnumDrawersUpDown
            // 
            this.DQnumDrawersUpDown.Enabled = false;
            this.DQnumDrawersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQnumDrawersUpDown.Location = new System.Drawing.Point(180, 121);
            this.DQnumDrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DQnumDrawersUpDown.Name = "DQnumDrawersUpDown";
            this.DQnumDrawersUpDown.Size = new System.Drawing.Size(120, 26);
            this.DQnumDrawersUpDown.TabIndex = 3;
            this.DQnumDrawersUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DQnumDrawersUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // DQsurfaceMaterialComboBox
            // 
            this.DQsurfaceMaterialComboBox.DisplayMember = "Oak";
            this.DQsurfaceMaterialComboBox.DropDownHeight = 125;
            this.DQsurfaceMaterialComboBox.Enabled = false;
            this.DQsurfaceMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DQsurfaceMaterialComboBox.FormattingEnabled = true;
            this.DQsurfaceMaterialComboBox.IntegralHeight = false;
            this.DQsurfaceMaterialComboBox.Location = new System.Drawing.Point(180, 153);
            this.DQsurfaceMaterialComboBox.MaxDropDownItems = 5;
            this.DQsurfaceMaterialComboBox.Name = "DQsurfaceMaterialComboBox";
            this.DQsurfaceMaterialComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DQsurfaceMaterialComboBox.Size = new System.Drawing.Size(120, 26);
            this.DQsurfaceMaterialComboBox.Sorted = true;
            this.DQsurfaceMaterialComboBox.TabIndex = 4;
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
            // DQrushDaysComboBox
            // 
            this.DQrushDaysComboBox.DisplayMember = "Oak";
            this.DQrushDaysComboBox.DropDownHeight = 126;
            this.DQrushDaysComboBox.Enabled = false;
            this.DQrushDaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DQrushDaysComboBox.FormattingEnabled = true;
            this.DQrushDaysComboBox.IntegralHeight = false;
            this.DQrushDaysComboBox.Items.AddRange(new object[] {
            "14",
            "3",
            "5",
            "7"});
            this.DQrushDaysComboBox.Location = new System.Drawing.Point(180, 184);
            this.DQrushDaysComboBox.MaxDropDownItems = 3;
            this.DQrushDaysComboBox.Name = "DQrushDaysComboBox";
            this.DQrushDaysComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DQrushDaysComboBox.Size = new System.Drawing.Size(120, 26);
            this.DQrushDaysComboBox.Sorted = true;
            this.DQrushDaysComboBox.TabIndex = 5;
            this.DQrushDaysComboBox.Text = "3";
            this.DQrushDaysComboBox.ValueMember = "3";
            // 
            // DQcustomerNameTextBox
            // 
            this.DQcustomerNameTextBox.Enabled = false;
            this.DQcustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQcustomerNameTextBox.Location = new System.Drawing.Point(180, 22);
            this.DQcustomerNameTextBox.MaxLength = 50;
            this.DQcustomerNameTextBox.Name = "DQcustomerNameTextBox";
            this.DQcustomerNameTextBox.Size = new System.Drawing.Size(120, 26);
            this.DQcustomerNameTextBox.TabIndex = 0;
            this.DQcustomerNameTextBox.Text = "John";
            this.DQcustomerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // DQtotalCostLabel
            // 
            this.DQtotalCostLabel.Enabled = false;
            this.DQtotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DQtotalCostLabel.Location = new System.Drawing.Point(136, 224);
            this.DQtotalCostLabel.MaxLength = 50;
            this.DQtotalCostLabel.Name = "DQtotalCostLabel";
            this.DQtotalCostLabel.Size = new System.Drawing.Size(164, 26);
            this.DQtotalCostLabel.TabIndex = 12;
            this.DQtotalCostLabel.Text = "Total Cost";
            this.DQtotalCostLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DQdoneButton;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.DQtotalCostLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.DQcustomerNameTextBox);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.DQrushDaysComboBox);
            this.Controls.Add(this.addQuoteSurfaceLabel);
            this.Controls.Add(this.DQsurfaceMaterialComboBox);
            this.Controls.Add(this.addQuoteDrawerLabel);
            this.Controls.Add(this.DQnumDrawersUpDown);
            this.Controls.Add(this.addQuoteDepthLabel);
            this.Controls.Add(this.DQdepthUpDown);
            this.Controls.Add(this.addQuoteWidthLabel);
            this.Controls.Add(this.DQwidthUpDown);
            this.Controls.Add(this.DQdoneButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DQwidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQdepthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQnumDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DQdoneButton;
        private System.Windows.Forms.NumericUpDown DQwidthUpDown;
        private System.Windows.Forms.Label addQuoteWidthLabel;
        private System.Windows.Forms.Label addQuoteDepthLabel;
        private System.Windows.Forms.NumericUpDown DQdepthUpDown;
        private System.Windows.Forms.Label addQuoteDrawerLabel;
        private System.Windows.Forms.NumericUpDown DQnumDrawersUpDown;
        private System.Windows.Forms.ComboBox DQsurfaceMaterialComboBox;
        private System.Windows.Forms.Label addQuoteSurfaceLabel;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.ComboBox DQrushDaysComboBox;
        private System.Windows.Forms.TextBox DQcustomerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox DQtotalCostLabel;
    }
}