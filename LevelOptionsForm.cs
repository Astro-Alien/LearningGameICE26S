using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningGame1
{
    public partial class LevelOptionsForm : Form
    {
        public LevelOptionsForm()
        {
            InitializeComponent();
        }

        private void LevelOptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startCaller = new StartMenu();
            startCaller.ShowDialog();
            this.Close();
        }

        private void dBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Days daysCaller = new Days();
            daysCaller.ShowDialog();
            this.Close();
        }

        private void nBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Numbers numbersCaller = new Numbers();
            numbersCaller.ShowDialog();
            this.Close();
        }

        private void aBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alphabet alphabetCaller = new Alphabet();
            alphabetCaller.ShowDialog();
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestForm testCaller = new TestForm();
            testCaller.ShowDialog();
            this.Close();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestForm2 test2Caller = new TestForm2();
            test2Caller.ShowDialog();
            this.Close();
        }
    }
}
