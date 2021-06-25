using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningGame1
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            helpRTBox.Text = "This is a game that will help you learn to spell in afrikaans. There is 3 sections to the game. The first section is the Alphabet, the second is Numbers, and the third is the Days of the week. \n\nYou get three chances to get the answer correct. If after three chances you get the answer wrong, the game will automatically reset. \n\nThere is also hints of each word if you need to hear the words out loud, if you press the play button.";
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startCaller = new StartMenu();
            startCaller.ShowDialog();
            this.Close();
        }
    }
}
