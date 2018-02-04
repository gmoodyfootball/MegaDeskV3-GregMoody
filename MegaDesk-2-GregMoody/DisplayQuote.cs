﻿using System;
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
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        private DeskQuote deskQuote;
        public DisplayQuote(Form mainMenu, DeskQuote newDeskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu; //Give me access to the form that called this one
            var materials = new List<Desk.Surface>(); //making a list of surface materials generated by the Surface enum
            materials = Enum.GetValues(typeof(Desk.Surface)).Cast<Desk.Surface>().ToList();
            DQsurfaceMaterialComboBox.DataSource = materials;
            DQsurfaceMaterialComboBox.SelectedIndex = 0;

            //Going to use these values to populate the form values
            deskQuote = newDeskQuote;
            DQcustomerNameTextBox.Text = deskQuote.custName;
            DQdepthUpDown.Value = deskQuote.desk.depth;
            DQwidthUpDown.Value = deskQuote.desk.width;
            DQnumDrawersUpDown.Value = deskQuote.desk.numDrawers;
            DQrushDaysComboBox.Text = deskQuote.rushDays.ToString(); //convert that bad boy to a string!
            DQsurfaceMaterialComboBox.Text = deskQuote.desk.surfaceMaterial.ToString();
            int totalCost = newDeskQuote.getQuote();
            string formattedQuote = String.Format("${0}.00", totalCost.ToString());
            DQtotalCostLabel.Text = formattedQuote;
        }

        private void cancelAddQuote_Click(object sender, EventArgs e)
        {
            //var mainMenu = (MainMenu)Tag;
            _mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var mainMenu = (MainMenu)Tag;
            _mainMenu.Show();
            //Close(); --Don't need this because the form "Close()" 
            //has already been called with the push of the red x button
        }
    }
}