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
using System.Media;
namespace LearningGame1
{
    public partial class Numbers : Form
    {
        private static string pointSave = @"C:\Users\Charles\Downloads\LearningGameICE26S\SavedScoreNumbers.txt";
        private string[] value = File.ReadAllLines(pointSave);

        private static string pointSaveM = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesNumbers.txt";
        private string[] valueM = File.ReadAllLines(pointSaveM);

        private static string pointMistakes = @"C:\Users\Charles\Downloads\LearningGameICE26S\Mistakes.txt";
        private string[] valueMistake = File.ReadAllLines(pointMistakes);

        private int a = 0;


        private System.Media.SoundPlayer hint1 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint2 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint3 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint4 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint5 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint6 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint7 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint8 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint9 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint10 = new System.Media.SoundPlayer();

        public Numbers()
        {
            InitializeComponent();
            hint1.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\een.wav";
            hint2.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\twee.wav";
            hint3.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\drie.wav";
            hint4.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\vier.wav";
            hint5.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\vyf.wav";
            hint6.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\ses.wav";
            hint7.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\sewe.wav";
            hint8.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\agt.wav";
            hint9.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\nege.wav";
            hint10.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundNumbers\tien.wav";
        }

        private void Numbers_Load(object sender, EventArgs e)
        {
            lblScore.Text = value[0];
            //converting the array value to an integer
            a = int.Parse(value[0]);

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
                    resetToNewQuestion();
                    break;

                default:
                    MessageBox.Show("It is Done");
                    break;

            }

        }

        //--------------------------------------------------------------Level methods where the position of the textboxes and text values are set
        private void LevelOne()
        {
            a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(228, 55);

            letter1.Location = new Point(117, 55);
            letter2.Location = new Point(228, 55);
            letter3.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "E";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Visible = false;
            t4.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\1.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwo()
        {
            a = 0;
            String res2 = a.ToString();
            valueM[0] = res2;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res2;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "T";
            letter2.Text = "W";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\2.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelThree()
        {
            a = 0;
            String res3 = a.ToString();
            valueM[0] = res3;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res3;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "D";
            letter2.Text = "R";
            letter2.ForeColor = Color.White;
            letter3.Text = "I";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\3.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFour()
        {
            a = 0;
            String res4 = a.ToString();
            valueM[0] = res4;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res4;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "V";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "R";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\4.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFive()
        {
            a = 0;
            String res5 = a.ToString();
            valueM[0] = res5;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res5;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(228, 55);

            letter1.Location = new Point(117, 55);
            letter2.Location = new Point(228, 55);
            letter3.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "V";
            letter2.Text = "Y";
            letter2.ForeColor = Color.White;
            letter3.Text = "F";
            letter4.Visible = false;
            t4.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\5.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSix()
        {
            a = 0;
            String res5 = a.ToString();
            valueM[0] = res5;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res5;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(228, 55);

            letter1.Location = new Point(117, 55);
            letter2.Location = new Point(228, 55);
            letter3.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "S";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "S";
            letter4.Visible = false;
            t4.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\6.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSeven()
        {
            a = 0;
            String res5 = a.ToString();
            valueM[0] = res5;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res5;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "S";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "W";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\7.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelEight()
        {
            a = 0;
            String res6 = a.ToString();
            valueM[0] = res6;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res6;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(228, 55);

            letter1.Location = new Point(117, 55);
            letter2.Location = new Point(228, 55);
            letter3.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "A";
            letter2.Text = "G";
            letter2.ForeColor = Color.White;
            letter3.Text = "T";
            letter4.Visible = false;
            t4.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\8.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelNine()
        {
            a = 0;
            String res8 = a.ToString();
            valueM[0] = res8;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res8;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "N";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "G";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\9.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelTen()
        {
            a = 0;
            String res8 = a.ToString();
            valueM[0] = res8;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res8;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(165, 55);
            t4.Location = new Point(276, 55);

            letter1.Location = new Point(91, 50);
            letter2.Location = new Point(178, 50);
            letter3.Location = new Point(264, 50);
            letter4.Location = new Point(351, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "T";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "N";
            letter4.ForeColor = Color.White;



            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\10.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        //--------------------------------------------------------------MatchUp methods responsible for checking whether the placeholders match the letters entered by the user
        private void MatchUpOne()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***EEN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTwo()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***TWEE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpThree()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***DRIE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpFour()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***VIER***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpFive()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***VYF***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpSix()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***SES***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpSeven()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***SEWE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpEight()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***AGT***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpNine()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***NEGE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***TIEN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper())
            {
                MessageBox.Show("  ***YOU ALMOST GOT THE ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        //------------------------------------------------------------------------------------------------------------PointSystemMatch() checks the current point in the text file and increments it by 1
        private void PointSystemMatches()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

            //incrementing by one and saving the new value to the file for later use
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
                    String val = a.ToString();
                    value[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val;
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("Program Failed");
                    break;
            }

        }
        //------------------------------------------------------------------------------------------------------------PointSystemDoesNotMatch() checks the current  lose point in the text file and increments it by 1
        private void PointSystemDoesNotMatch()
        {
            //converting the array value to an integer
            a = int.Parse(valueM[0]);

            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {
                case 0:
                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    lblMistakes.Text = val1;
                    break;

                case 2:
                    a += 1;
                    String val2 = a.ToString();
                    valueM[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";

                    lblMistakes.Text = val2;
                    GameOver();
                    break;
                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }

        }
        //------------------------------------------------------------------------------------------------------------ResetToNewQuestion() check the current score and calls the next level according to the current score value
        private void resetToNewQuestion()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

            //The switch when called will check the value in the txt file and call the level after that value e.g(a =1 that means call level 2).
            switch (a)
            {
                case 0:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelOne();

                    break;
                case 1:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwo();

                    break;
                case 2:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThree();

                    break;
                case 3:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFour();

                    break;
                case 4:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelFive();

                    break;
                case 5:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelSix();

                    break;
                case 6:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeven();

                    break;
                case 7:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelEight();

                    break;

                case 8:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelNine();

                    break;
                case 9:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTen();

                    break;
                case 10:
                    MessageBox.Show("***YOU HAVE COMPLETED ALL LEVELS RETURN TO GAME SELECTION***");
                    //RESET LBLSCORE TO 0 AND RERUN THE PROGRAM IN A LOOP
                    a = 0;
                    String val = a.ToString();
                    value[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val;
                    this.Hide();
                    LevelOptionsForm levelsCaller = new LevelOptionsForm();
                    levelsCaller.ShowDialog();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("It Has been completed!");
                    break;



            }


        }
        private void GameOver()
        {
            valueMistake[0] = "0";
            File.WriteAllLines(pointMistakes, valueMistake);
            MessageBox.Show("                    ***YOU HAVE FAILED THIS LEVEL***\n      ***THE LEVEL WILL RESET WHEN YOU CLICK ON OK***");
            lblMistakes.Text = valueMistake[0];
            resetToNewQuestion();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelOptionsForm levelsCaller = new LevelOptionsForm();
            levelsCaller.ShowDialog();
            this.Close();

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

            switch (a)
            {

                case 0:
                    hint1.Play();
                    break;
                case 1:
                    hint2.Play();
                    break;
                case 2:
                    hint3.Play();
                    break;
                case 3:
                    hint4.Play();
                    break;
                case 4:
                    hint5.Play();
                    break;
                case 5:
                    hint6.Play();
                    break;
                case 6:
                    hint7.Play();
                    break;
                case 7:
                    hint8.Play();
                    break;
                case 8:
                    hint9.Play();
                    break;
                case 9:
                    hint10.Play();
                    break;
                default:
                    MessageBox.Show("It is done");
                    break;
            }
        }
    }
}
