namespace MegaDesk_3_GregMoody
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
            this.SuspendLayout();
            // 
            // cancelSearchQuotes
            // 
            this.cancelSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSearchQuotes.Location = new System.Drawing.Point(247, 227);
            this.cancelSearchQuotes.Name = "cancelSearchQuotes";
            this.cancelSearchQuotes.Size = new System.Drawing.Size(75, 23);
            this.cancelSearchQuotes.TabIndex = 0;
            this.cancelSearchQuotes.Text = "Cancel";
            this.cancelSearchQuotes.UseVisualStyleBackColor = true;
            this.cancelSearchQuotes.Click += new System.EventHandler(this.cancelSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelSearchQuotes;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.cancelSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuotes;
    }
}