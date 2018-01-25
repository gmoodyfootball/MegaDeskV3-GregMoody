using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_GregMoody
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuote addQuoteViewForm = new ViewQuote();
            addQuoteViewForm.Tag = this;
            addQuoteViewForm.Show(this);
            Hide();
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuotesForm = new SearchQuotes();
            addSearchQuotesForm.Tag = this;
            addSearchQuotesForm.Show(this);
            Hide();
        }
    }
}
