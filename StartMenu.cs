using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningGame1
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            this.Hide();
            LevelOptionsForm levelOptionCaller = new LevelOptionsForm();
            levelOptionCaller.ShowDialog();
            this.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm helpCaller = new HelpForm();
            helpCaller.ShowDialog();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
