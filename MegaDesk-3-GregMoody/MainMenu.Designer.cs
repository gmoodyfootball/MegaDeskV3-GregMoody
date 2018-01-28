namespace MegaDesk_3_GregMoody
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.exitApp = new System.Windows.Forms.Button();
            this.searchQuoteButton = new System.Windows.Forms.Button();
            this.addNewQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitApp
            // 
            this.exitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.exitApp.Location = new System.Drawing.Point(12, 201);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(137, 47);
            this.exitApp.TabIndex = 3;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.searchQuoteButton.Location = new System.Drawing.Point(12, 136);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(137, 47);
            this.searchQuoteButton.TabIndex = 2;
            this.searchQuoteButton.Text = "Search Quotes";
            this.searchQuoteButton.UseVisualStyleBackColor = true;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // addNewQuote
            // 
            this.addNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addNewQuote.Location = new System.Drawing.Point(12, 12);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(137, 47);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.viewQuotes.Location = new System.Drawing.Point(12, 74);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(137, 47);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(174, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addNewQuote);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.exitApp);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "MainMenu";
            this.Text = "MegaDesk-Greg Moody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Button searchQuoteButton;
        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

