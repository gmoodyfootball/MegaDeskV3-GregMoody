﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2_GregMoody
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void cancelSearchQuotes_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            //Populate the combo box
            //making a list of surface materials generated by the Surface enum
            var materials = new List<Desk.Surface>();
            materials = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            surfaceMaterialComboBox.DataSource = materials;
            surfaceMaterialComboBox.SelectedIndex = 0;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchQuotesDataGridView.Rows.Clear();
            try
            {
                using (StreamReader sr = new StreamReader("quotes.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] quotes = sr.ReadLine().Split(',');
                        if (quotes.Contains(surfaceMaterialComboBox.Text))
                        {
                            searchQuotesDataGridView.Rows.Add(
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
            }
            catch
            {
                //You don messed up
            }
        }
    }
}