using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskV3_GregMoody
{
    public partial class ViewQuote : Form
    {
        private Form _mainMenu;

        public ViewQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void cancelViewQuote_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
            //Pushing the red button acts as the "Close()" function
        }

        private void ViewQuote_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("quotes.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        viewQuotesDataGridView.Rows.Add(
                            quotes[0],
                            quotes[1],
                            quotes[2],
                            quotes[3],
                            quotes[4],
                            quotes[5],
                            quotes[6],
                            quotes[7]
                            );
                    }
                }
            }
            catch
            {
                //You don messed up
            }
        }
    }
}
