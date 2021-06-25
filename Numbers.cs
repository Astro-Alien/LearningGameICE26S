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
            hint1.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\een.wav";
            hint2.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\twee.wav";
            hint3.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\drie.wav";
            hint4.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\vier.wav";
            hint5.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\vyf.wav";
            hint6.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\ses.wav";
            hint7.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\sewe.wav";
            hint8.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\agt.wav";
            hint9.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\nege.wav";
            hint10.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundNumbers\tien.wav";
        }

        private void Numbers_Load(object sender, EventArgs e)
        {
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";
            //reading the value in the file to the array
            string[] value = File.ReadAllLines(pointSave);
            lblScore.Text = value[0];
            //converting the array value to an integer

            int a = int.Parse(value[0]);

            switch (a)
            {

                case 0:
                    LevelOne();
                    break;

                case 1:
                    LevelTwo();
                    break;

                case 2:
                    LevelThree();
                    break;
                case 3:
                    LevelFour();
                    break;
                case 4:
                    LevelFive();
                    break;
                case 5:
                    LevelSix();
                    break;
                case 6:
                    LevelSeven();
                    break;
                case 7:
                    LevelEight();
                    break;
                case 8:
                    LevelNine();
                    break;
                case 9:
                    LevelTen();
                    break;
               
                default:
                    MessageBox.Show("It is Done");
                    break;

            }

        }

        //--------------------------------------------------------------Level methods where the position of the textboxes and text values are set
        private void LevelOne()
        {
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\1.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwo() {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res2 = a.ToString();
            value[0] = res2;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\2.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelThree() {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res3 = a.ToString();
            value[0] = res3;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\3.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFour()
        {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res4 = a.ToString();
            value[0] = res4;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\4.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFive()
        {
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res5 = a.ToString();
            value[0] = res5;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\5.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSix()
        {
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res5 = a.ToString();
            value[0] = res5;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\6.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSeven()
        {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res5 = a.ToString();
            value[0] = res5;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\7.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelEight()
        {
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res6 = a.ToString();
            value[0] = res6;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\8.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelNine()
        {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res8 = a.ToString();
            value[0] = res8;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\9.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelTen()
        {

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";
            String[] value = File.ReadAllLines(pointSave);
            int a = 0;
            String res8 = a.ToString();
            value[0] = res8;
            File.WriteAllLines(pointSave, value);
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
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\10.jpg";
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
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";
            
            //reading the value in the file to the array
            String[] value = File.ReadAllLines(pointSave);

            //converting the array value to an integer
            int a = int.Parse(value[0]);
           
            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {

                case 0:
                    a += 1;
                    String val = a.ToString();
                    value[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val;
                    resetToNewQuestion();

                    break;
                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    value[0] = val1;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val1;
                    resetToNewQuestion();

                    break;
                case 2:
                    a += 1;
                    String val2 = a.ToString();
                    value[0] = val2;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val2;
                    resetToNewQuestion();

                    break;
                case 3:
                    a += 1;
                    String val3 = a.ToString();
                    value[0] = val3;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val3;
                    resetToNewQuestion();

                    break;
                case 4:
                    a += 1;
                    String val4 = a.ToString();
                    value[0] = val4;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val4;
                    resetToNewQuestion();

                    break;
                case 5:
                    a += 1;
                    String val5 = a.ToString();
                    value[0] = val5;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val5;
                    resetToNewQuestion();

                    break;
                case 6:
                    a += 1;
                    String val6 = a.ToString();
                    value[0] = val6;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val6;
                    resetToNewQuestion();

                    break;
                case 7:
                    a += 1;
                    String val7 = a.ToString();
                    value[0] = val7;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val7;
                    resetToNewQuestion();

                    break;
                case 8:
                    a += 1;
                    String val8 = a.ToString();
                    value[0] = val8;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val8;
                    resetToNewQuestion();

                    break;
                case 9:
                    a += 1;
                    String val9 = a.ToString();
                    value[0] = val9;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val9;
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
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";

            //reading the value in the file to the array
            String[] valueM = File.ReadAllLines(pointSave);

            //converting the array value to an integer
            int a = int.Parse(valueM[0]);

            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {
                case 0:
                    a += 1;
                    String val = a.ToString();
                    valueM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueM);
                    t3.Text = "";
                    t4.Text = "";
                   
                    lblMistakes.Text = val;
                    break;
                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    
                    lblMistakes.Text = val1;
                    break;

                case 2:
                    a += 1;
                    String val2 = a.ToString();
                    valueM[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueM);
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
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";

            //reading the value in the file to the array
            string[] value = File.ReadAllLines(pointSave);

            //converting the array value to an integer
            int a = int.Parse(value[0]);

            //The switch when called will check the value in the txt file and call the level after that value e.g(a =1 that means call level 2).
            switch (a)
            {

                case 0:
                    t3.Text = "";
                    LevelOne();

                    break;
                case 1:
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwo();
                    
                    break;
                case 2:
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThree();

                    break;
                case 3:
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFour();

                    break;
                case 4:
                    t3.Text = "";
                    LevelFive();

                    break;
                case 5:
                    t3.Text = "";
                    LevelSix();

                    break;
                case 6:
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeven();

                    break;
                case 7:
                    t3.Text = "";
                    LevelEight();

                    break;

                case 8:
                    letter4.Visible = true;
                    t4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelNine();

                    break;
                case 9:
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

            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\MistakesNumbers.txt";

            //RESET LBLSCORE TO 0 AND RERUN THE PROGRAM IN A LOOP
            String[] value = File.ReadAllLines(pointSave); 
            int a = 0;
            String val = a.ToString();
            value[0] = val;
        
            //writing the current score value to the SavedScore text file
            File.WriteAllLines(pointSave, value);
            lblScore.Text = val;
            
            MessageBox.Show("                  ***YOU HAVE FAILED THIS LEVEL***\n   ***THE LEVEL WILL RESET WHEN YOU CLICK ON OK***");
            //---------------------------------------------------------------------------------------------------------------------------------------
            //setting the file path to the text file
            var pointSaveScore = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";
            
            //reading the value in the file to the array
            string[] valueScore = File.ReadAllLines(pointSaveScore);
            
            //converting the array value to an integer
            int b = int.Parse(valueScore[0]);

            switch (b)
            {

                case 0:
                    b = 0;
                    String val1 = b.ToString();
                    valueScore[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val1;
                    resetToNewQuestion();

                    break;
                case 1:
                    b = 0;
                    String val2 = b.ToString();
                    valueScore[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val2;
                    resetToNewQuestion();

                    break;
                case 2:
                    b = 0;
                    String val3 = b.ToString();
                    valueScore[0] = val3;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val3;
                    resetToNewQuestion();

                    break;
                case 3:
                    b = 0;
                    String val4 = b.ToString();
                    valueScore[0] = val4;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val4;
                    resetToNewQuestion();

                    break;
                case 4:
                    b = 0;
                    String val5 = b.ToString();
                    valueScore[0] = val5;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val5;
                    resetToNewQuestion();

                    break;
                case 5:
                    b = 0;
                    String val6 = b.ToString();
                    valueScore[0] = val6;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val6;
                    resetToNewQuestion();

                    break;
                case 6:
                    b = 0;
                    String val7 = b.ToString();
                    valueScore[0] = val7;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val7;
                    resetToNewQuestion();

                    break;
                case 7:
                    b = 0;
                    String val8 = b.ToString();
                    valueScore[0] = val8;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val8;
                    resetToNewQuestion();

                    break;

                case 8:
                    b = 0;
                    String val9 = b.ToString();
                    valueScore[0] = val9;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val9;
                    resetToNewQuestion();

                    break;
                case 9:
                    b = 0;
                    String val10 = b.ToString();
                    valueScore[0] = val10;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val10;
                    resetToNewQuestion();

                    break;
                case 10:
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("It Has been completed!");
                    break;



            }



        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            //setting the file path to the text file
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";

            //reading the value in the file to the array
            string[] value = File.ReadAllLines(pointSave);

            //converting the array value to an integer

            int a = int.Parse(value[0]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var pointSave = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\SavedScoreNumbers.txt";

            //reading the value in the file to the array
            string[] value = File.ReadAllLines(pointSave);

            //converting the array value to an integer

            int a = int.Parse(value[0]);
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
