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
            this.SuspendLayout();
            // 
            // cancelAddQuote
            // 
            this.cancelAddQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAddQuote.Location = new System.Drawing.Point(247, 227);
            this.cancelAddQuote.Name = "cancelAddQuote";
            this.cancelAddQuote.Size = new System.Drawing.Size(75, 23);
            this.cancelAddQuote.TabIndex = 0;
            this.cancelAddQuote.Text = "Cancel";
            this.cancelAddQuote.UseVisualStyleBackColor = true;
            this.cancelAddQuote.Click += new System.EventHandler(this.cancelAddQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelAddQuote;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.cancelAddQuote);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelAddQuote;
    }
}