using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2_GregMoody
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote(this);
        //    addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show();
            Hide();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuote quotesViewForm = new ViewQuote(this);
            //addQuoteViewForm.Tag = this;
            quotesViewForm.Show();
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
