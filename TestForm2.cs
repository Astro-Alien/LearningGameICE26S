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

namespace LearningGame1
{
    public partial class TestForm2 : Form
    {
        private static string pointSaveQ = @"C:\Users\Charles\Downloads\LearningGameICE26S\SavedScoreQuiz.txt";
        private static string[] valueQ = File.ReadAllLines(pointSaveQ);

        private static string pointSaveQM = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesQuiz.txt";
        private static string[] valueQM = File.ReadAllLines(pointSaveQM);

        private static string pointMistakes = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesQuiz.txt";
        private static string[] valueMistake = File.ReadAllLines(pointMistakes);

        public TestForm2()
        {
            InitializeComponent();


            lblScore.Text = valueQ[0];
            //converting the array value to an integer

            int a = int.Parse(valueQ[0]);

            switch (a)
            {
                //complete this level in the morning an fix the gameover error method in the others forms
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    resetToNewQuestion();
                    break;

                default:
                    MessageBox.Show("It is Done");
                    break;

            }
        }

        private void LevelOne()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\goose.jpg";

        }
        private void LevelTwo()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;

            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\jas.jpg";

        }
        private void LevelThree()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\cat.jpg";

        }
        private void LevelFour()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\Lion.jpg";

        }
        private void LevelFive()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\nest.jpg";

        }
        private void LevelSix()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\star.jpg";

        }
        private void LevelSeven()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\garden.jpg";

        }
        private void LevelEight()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\Pig.jpg";

        }
        private void LevelNine()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\worm.jpg";

        }
        private void LevelTen()
        {
            int a = 0;
            String res1 = a.ToString();
            valueQM[0] = res1;
            File.WriteAllLines(pointSaveQM, valueQM);
            lblMistakes.Text = res1;
            pAnswer.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Quiz images\x.jpg";

        }
        private void MatchUpOne()
        {
            String AnswerOne = "GANS";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpTwo()
        {
            String AnswerOne = "JAS";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpThree()
        {
            String AnswerOne = "KAT";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpFour()
        {
            String AnswerOne = "LEEU";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpFive()
        {
            String AnswerOne = "NES";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpSix()
        {
            String AnswerOne = "STER";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpSeven()
        {
            String AnswerOne = "TUIN";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpEight()
        {
            String AnswerOne = "VARK";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpNine()
        {
            String AnswerOne = "WURM";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }
        private void MatchUpTen()
        {
            String AnswerOne = "XILOFOON";
            //loop through a text file to check if the word is saved in it 
            if (AnswerOne == txtAnswer.Text.ToUpper())
            {

                MessageBox.Show("***YOU ANSWERED CORRECTLY***");
                PointSystemMatches();

            }
            else
            {

                MessageBox.Show("***YOU ANSWERED INCORRECTLY PLEASE TRY AGAIN***");
                PointSystemDoesNotMatch();


            }


        }

        private void PointSystemMatches()
        {


            int a = int.Parse(valueQ[0]);

            switch (a)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    a += 1;
                    String v = a.ToString();
                    valueQ[0] = v;
                    File.WriteAllLines(pointSaveQ, valueQ);
                    lblScore.Text = v;
                    resetToNewQuestion();
                    break;
                default:
                    MessageBox.Show("***Level Done***");
                    break;


            }
        }
        private void PointSystemDoesNotMatch()
        {



            int b = int.Parse(valueQM[0]);

            switch (b)
            {

                case 0:
                case 1:
                    b += 1;
                    String val = b.ToString();
                    valueQM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveQM, valueQM);
                    txtAnswer.Text = "";
                    lblMistakes.Text = val;
                    break;
                case 2:
                    b += 1;
                    String val1 = b.ToString();
                    valueQM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveQM, valueQM);
                    txtAnswer.Text = "";
                    lblMistakes.Text = val1;
                    GameOver();
                    break;
                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }






        }
        private void resetToNewQuestion()
        {


            int a = int.Parse(valueQ[0]);

            switch (a)
            {

                case 0:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelOne();

                    break;
                case 1:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelTwo();

                    break;
                case 2:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelThree();

                    break;
                case 3:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelFour();

                    break;
                case 4:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelFive();

                    break;
                case 5:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelSix();

                    break;
                case 6:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelSeven();

                    break;
                case 7:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelEight();

                    break;
                case 8:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelNine();

                    break;
                case 9:
                    txtAnswer.Text = "";
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelTen();

                    break;
                case 10:

                    MessageBox.Show("***YOU HAVE COMPLETED ALL QUESTIONS CORRECTLY***\n ***YOU CAN NOW RETURN TO GAME SELECTION***");
                    //RESET LBLSCORE TO 0 AND RERUN THE PROGRAM IN A LOOP
                    a = 0;
                    String val = a.ToString();
                    valueQ[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSaveQ, valueQ);
                    lblScore.Text = val;
                    this.Hide();
                    LevelOptionsForm levelsCaller = new LevelOptionsForm();
                    levelsCaller.ShowDialog();
                    this.Close();
                    break;

                default:
                    MessageBox.Show("   NO MORE LEVELS");
                    break;




            }





        }
        private void GameOver()
        {

            valueMistake[0] = "0";
            File.WriteAllLines(pointMistakes, valueMistake);
            MessageBox.Show("                  ***YOU HAVE FAILED THIS QUESTION***\n   ***THE QUESTION WILL RESET WHEN YOU CLICK ON OK***");
            lblMistakes.Text = valueMistake[0];
            resetToNewQuestion();

        }
        private void TestForm2_Load(object sender, EventArgs e)
        {

        }
        private void pAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmission_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(valueQ[0]);

            switch (a)
            {

                case 0:
                    MatchUpOne();
                    break;
                case 1:
                    MatchUpTwo();
                    break;
                case 2:
                    MatchUpThree();
                    break;
                case 3:
                    MatchUpFour();
                    break;
                case 4:
                    MatchUpFive();
                    break;
                case 5:
                    MatchUpSix();
                    break;
                case 6:
                    MatchUpSeven();
                    break;
                case 7:
                    MatchUpEight();
                    break;
                case 8:
                    MatchUpNine();
                    break;
                case 9:
                    MatchUpTen();
                    break;
                default:
                    MessageBox.Show("It is done");
                    break;


            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LevelOptionsForm levelCaller = new LevelOptionsForm();
            levelCaller.ShowDialog();
            this.Close();
        }
    }
}
