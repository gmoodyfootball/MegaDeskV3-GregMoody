namespace MegaDesk_3_GregMoody
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
            this.SuspendLayout();
            // 
            // cancelViewQuote
            // 
            this.cancelViewQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelViewQuote.Location = new System.Drawing.Point(247, 227);
            this.cancelViewQuote.Name = "cancelViewQuote";
            this.cancelViewQuote.Size = new System.Drawing.Size(75, 23);
            this.cancelViewQuote.TabIndex = 0;
            this.cancelViewQuote.Text = "Cancel";
            this.cancelViewQuote.UseVisualStyleBackColor = true;
            this.cancelViewQuote.Click += new System.EventHandler(this.cancelViewQuote_Click);
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelViewQuote;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.cancelViewQuote);
            this.Name = "ViewQuote";
            this.Text = "View Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewQuote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelViewQuote;
    }
}