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
    public partial class Alphabet : Form
    {
        private static string pointSave = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\SavedScoreAlphabet.txt";
        private string[] value = File.ReadAllLines(pointSave);
        
        private static string pointSaveM = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\MistakesAlphabet.txt";
        private string[] valueM = File.ReadAllLines(pointSaveM);
        
        private static string pointSaveScore = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\SavedScoreAlphabet.txt";

        private string[] valueScore = File.ReadAllLines(pointSaveScore);
        
        private int a = 0;
        private int b = 0;

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
        private System.Media.SoundPlayer hint11 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint12 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint13 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint14 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint15 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint16 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint17 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint18 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint19 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint20 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint21 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint22 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint23 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint24 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint25 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint26 = new System.Media.SoundPlayer();

        public Alphabet()
        {
            InitializeComponent();

            hint1.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\arm.wav";
            hint2.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\bus.wav";
            hint3.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\coke.wav";
            hint4.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\dam.wav";
            hint5.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\eier.wav";
            hint6.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\fiets.wav";
            hint7.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\gans.wav";
            hint8.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\hond.wav";
            hint9.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\ink.wav";
            hint10.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\jas.wav";
            hint11.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\kat.wav";
            hint12.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\leeu.wav";
            hint13.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\melk.wav";
            hint14.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\nes.wav";
            hint15.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\olie.wav";
            hint16.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\pen.wav";
            hint17.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\queen.wav";
            hint18.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\reen.wav";
            hint19.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\ster.wav";
            hint20.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\tuin.wav";
            hint21.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\uil.wav";
            hint22.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\vark.wav";
            hint23.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\wurm.wav";
            hint24.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\xiolofoon.wav";
            hint25.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\ys.wav";
            hint26.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundAlphabet\zoeloe.wav";

        }

        private void Alphabet_Load(object sender, EventArgs e)
        {
            lblScore.Text = value[0];
            //converting the array value to an integer
            a = int.Parse(value[0]);
            
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
                case 10:
                    LevelEleven();
                    break;
                case 11:
                    LevelTwelve();
                    break;
                case 12:
                    LevelThirteen();
                    break;
                case 13:
                    LevelFourteen();
                    break;
                case 14:
                    LevelFifteen();
                    break;
                case 15:
                    LevelSixteen();
                    break;
                case 16:
                    LevelSeventeen();
                    break;
                case 17:
                    LevelEighteen();
                    break;
                case 18:
                    LevelNineteen();
                    break;
                case 19:
                    LevelTwenty();
                    break;
                case 20:
                    LevelTwentyone();
                    break;
                case 21:
                    LevelTwentytwo();
                    break;
                case 22:
                    LevelTwentythree();
                    break;
                case 23:
                    LevelTwentyfour();
                    break;
                case 24:
                    LevelTwentyfive();
                    break;
                case 25:
                    LevelTwentysix();
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
            letter1.Text = "A";
            letter2.Text = "R";
            letter2.ForeColor = Color.White;
            letter3.Text = "M";
           
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;
           

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\a.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwo()
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
            letter1.Text = "B";
            letter2.Text = "U";
            letter2.ForeColor = Color.White;
            letter3.Text = "S";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\b.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelThree()
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
            letter1.Text = "C";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "K";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;
           
            t5.Visible = false;
            t6.Visible = false;
            
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\c.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelFour()
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
            letter1.Text = "D";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "M";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\D.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelFive()
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
            letter1.Text = "E";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "R";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\e.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSix()
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

            letter1.Location = new Point(59, 50);
            letter2.Location = new Point(134, 50);
            letter3.Location = new Point(209, 50);
            letter4.Location = new Point(284, 50);
            letter5.Location = new Point(359, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "F";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "T";
            letter4.ForeColor = Color.White;
            letter5.Text = "S";
            
            t5.Visible = false;
            t6.Visible = false;

            
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\f.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSeven()
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
            letter1.Text = "G";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Text = "S";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\g.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelEight()
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
            letter1.Text = "H";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Text = "D";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\h.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelNine()
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
            letter1.Text = "I";
            letter2.Text = "N";
            letter2.ForeColor = Color.White;
            letter3.Text = "K";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\i.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTen()
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
            letter1.Text = "J";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "S";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\j.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelEleven()
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
            letter1.Text = "K";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "T";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\k.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwelve()
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
            letter1.Text = "L";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "U";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\l.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelThirteen()
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
            letter1.Text = "M";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "L";
            letter4.Text = "K";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\M.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelFourteen()
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
            letter1.Text = "N";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "S";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\n.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelFifteen()
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
            letter1.Text = "O";
            letter2.Text = "L";
            letter2.ForeColor = Color.White;
            letter3.Text = "I";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\o.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSixteen()
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
            letter1.Text = "P";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\p.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSeventeen()
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

            letter1.Location = new Point(59, 50);
            letter2.Location = new Point(134, 50);
            letter3.Location = new Point(209, 50);
            letter4.Location = new Point(284, 50);
            letter5.Location = new Point(359, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "Q";
            letter2.Text = "U";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;
            letter5.Text = "N";

            t5.Visible = false;
            t6.Visible = false;


            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\q.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelEighteen()
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
            letter1.Text = "R";
            letter2.Text = "E";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "N";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\r.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelNineteen()
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
            letter1.Text = "S";
            letter2.Text = "T";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "R";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\S.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwenty()
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
            letter2.Text = "U";
            letter2.ForeColor = Color.White;
            letter3.Text = "I";
            letter4.Text = "N";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\t.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyone()
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
            letter1.Text = "U";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "L";

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\u.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwentytwo()
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
            letter1.Text = "V";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "R";
            letter4.Text = "K";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\V.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentythree()
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
            letter1.Text = "W";
            letter2.Text = "U";
            letter2.ForeColor = Color.White;
            letter3.Text = "R";
            letter4.Text = "M";
            letter4.ForeColor = Color.White;

            t5.Visible = false;
            t6.Visible = false;

            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\W.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyfour()
        {
            a = 0;
            String res2 = a.ToString();
            valueM[0] = res2;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res2;

            //adjusting the size and position of the group boxes, textboxes
            hintGroupBox.Size = new Size(617, 131);
            hintGroupBox.Location = new Point(646, 208);
            answerGroupBox.Size = new Size(497, 125);
            t3.Location = new Point(125, 55);
            t4.Location = new Point(200, 55);
            t5.Location = new Point(272, 55);
            t6.Location = new Point(344, 55);

            letter1.Location = new Point(14, 50);
            letter2.Location = new Point(89, 50);
            letter3.Location = new Point(164, 50);
            letter4.Location = new Point(239, 50);
            letter5.Location = new Point(314, 50);
            letter6.Location = new Point(389, 50);
            letter7.Location = new Point(464, 50);
            letter8.Location = new Point(539, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;
            letter8.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;
            t6.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "X";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "L";
            letter4.Text = "O";
            letter4.ForeColor = Color.White;
            letter5.Text = "F";
            letter6.Text = "O";
            letter6.ForeColor = Color.White;
            letter7.Text = "O";
            letter8.Text = "N";
            letter8.ForeColor = Color.White;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\x.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyfive()
        {
            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(497, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(228, 55);

            letter1.Location = new Point(162, 50);
            letter2.Location = new Point(237, 50);
            

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "Y";
            letter2.Text = "S";
            letter2.ForeColor = Color.White;
            

            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            letter3.Visible = false;
            letter4.Visible = false;
            letter5.Visible = false;
            letter6.Visible = false;
            letter7.Visible = false;
            letter8.Visible = false;


            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\y.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwentysix()
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

            t3.Location = new Point(117, 55);
            t4.Location = new Point(228, 55);
            t5.Location = new Point(333, 55);

            letter1.Location = new Point(30, 50);
            letter2.Location = new Point(105, 50);
            letter3.Location = new Point(180, 50);
            letter4.Location = new Point(255, 50);
            letter5.Location = new Point(330, 50);
            letter6.Location = new Point(405, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "Z";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "L";
            letter4.ForeColor = Color.White;
            letter5.Text = "O";
            letter6.Text = "E";
            letter6.ForeColor = Color.White;
            t6.Visible = false;

            letter7.Visible = false;
            letter8.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\z.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        //--------------------------------------------------------------MatchUp methods responsible for checking whether the placeholders match the letters entered by the user
        private void MatchUpOne()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***ARM***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***BUS***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpThree()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***COKE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***DAM***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpFive()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***EIER***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpSix()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***FIETS***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpSeven()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***GANS***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***HOND***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpNine()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***INK***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***JAS***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpEleven()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***KAT***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTwelve()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***LEEU***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpThirteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***MELK***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpFourteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***NES***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpFifteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***OLIE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpSixteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***PEN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpSeventeen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***QUEEN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpEighteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***REEN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpNineteen()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***STER***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpTwenty()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***TUIN***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpTwentyone()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***UIL***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTwentytwo()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***VARK***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpTwentythree()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper())
            {
                MessageBox.Show("                            ***WURM***\n     ***YOU HAVE ANSWERED CORRECTLY***");
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
        private void MatchUpTwentyfour() {
            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("                          ***XILOFOON***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }




        }
        private void MatchUpTwentyfive()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper())
            {
                MessageBox.Show("                            ***YS***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER TRY AGAIN***");
                PointSystemDoesNotMatch();
            }

        }
        private void MatchUpTwentysix()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("                            ***ZOELOE***\n     ***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {

                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

        }

        private void PointSystemMatches()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

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
                case 10:
                    a += 1;
                    String val10 = a.ToString();
                    value[0] = val10;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val10;
                    resetToNewQuestion();

                    break;
                case 11:
                    a += 1;
                    String val11 = a.ToString();
                    value[0] = val11;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val11;
                    resetToNewQuestion();

                    break;
                case 12:
                    a += 1;
                    String val12 = a.ToString();
                    value[0] = val12;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val12;
                    resetToNewQuestion();

                    break;
                case 13:
                    a += 1;
                    String val13 = a.ToString();
                    value[0] = val13;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val13;
                    resetToNewQuestion();

                    break;
                case 14:
                    a += 1;
                    String val14 = a.ToString();
                    value[0] = val14;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val14;
                    resetToNewQuestion();

                    break;
                case 15:
                    a += 1;
                    String val15 = a.ToString();
                    value[0] = val15;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val15;
                    resetToNewQuestion();

                    break;
                case 16:
                    a += 1;
                    String val16 = a.ToString();
                    value[0] = val16;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val16;
                    resetToNewQuestion();

                    break;
                case 17:
                    a += 1;
                    String val17 = a.ToString();
                    value[0] = val17;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val17;
                    resetToNewQuestion();

                    break;
                case 18:
                    a += 1;
                    String val18 = a.ToString();
                    value[0] = val18;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val18;
                    resetToNewQuestion();

                    break;
                case 19:
                    a += 1;
                    String val19 = a.ToString();
                    value[0] = val19;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val19;
                    resetToNewQuestion();

                    break;
                case 20:
                    a += 1;
                    String val20 = a.ToString();
                    value[0] = val20;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val20;
                    resetToNewQuestion();

                    break;
                case 21:
                    a += 1;
                    String val21 = a.ToString();
                    value[0] = val21;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val21;
                    resetToNewQuestion();

                    break;
                case 22:
                    a += 1;
                    String val22 = a.ToString();
                    value[0] = val22;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val22;
                    resetToNewQuestion();

                    break;
                case 23:
                    a += 1;
                    String val23 = a.ToString();
                    value[0] = val23;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val23;
                    resetToNewQuestion();

                    break;
                case 24:
                    a += 1;
                    String val24 = a.ToString();
                    value[0] = val24;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val24;
                    resetToNewQuestion();

                    break;
                case 25:
                    a += 1;
                    String val25 = a.ToString();
                    value[0] = val25;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val25;
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("Program Failed");
                    break;
            }

        }

        private void PointSystemDoesNotMatch()
        {
            //converting the array value to an integer
            a = int.Parse(valueM[0]);

            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {
                case 0:
                    a += 1;
                    String val = a.ToString();
                    valueM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";
                    lblMistakes.Text = val;
                    break;
                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";
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
                    t5.Text = "";
                    t6.Text = "";
                    lblMistakes.Text = val2;
                    GameOver();
                    break;

                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }

        }

        private void resetToNewQuestion()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

            //The switch when called will check the value in the txt file and call the level after that value e.g(a =1 that means call level 2).
            switch (a)
            {

                case 0:
                    t3.Text = "";
                    LevelOne();

                    break;
                case 1:
                    t3.Text = "";
                    LevelTwo();

                    break;
                case 2:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThree();

                    break;
                case 3:
                    t3.Text = "";
                    LevelFour();

                    break;
                case 4:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFive();

                    break;
                case 5:
                    t4.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSix();

                    break;
                case 6:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeven();

                    break;
                case 7:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelEight();

                    break;
                case 8:
                    t3.Text = "";
                    LevelNine();

                    break;
                case 9:
                    t3.Text = "";
                    LevelTen();

                    break;
                case 10:
                    t3.Text = "";
                    LevelEleven();

                    break;
                case 11:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwelve();

                    break;
                case 12:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThirteen();

                    break;
                case 13:
                    t3.Text = "";
                    LevelFourteen();

                    break;
                case 14:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFifteen();

                    break;
                case 15:
                    t3.Text = "";
                    LevelSixteen();

                    break;
                case 16:
                    t4.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeventeen();

                    break;
                case 17:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelEighteen();
                    break;
                case 18:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelNineteen();
                    break;
                case 19:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwenty();
                    break;
                case 20:
                    t3.Text = "";
                    LevelTwentyone();

                    break;
                case 21:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwentytwo();
                    break;
                case 22:
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwentythree();
                    break;
                case 23:
                    t4.Visible = true;
                    t5.Visible = true;
                    t6.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    letter6.Visible = true;
                    letter7.Visible = true;
                    letter8.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwentyfour();
                    break;
                case 24:
                    t3.Text = "";
                    LevelTwentyfive();

                    break;
                case 25:
                    letter3.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    letter6.Visible = true;
                    t4.Visible = true;
                    t5.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    LevelTwentysix();
                    break;
                case 26:

                    MessageBox.Show("***YOU HAVE COMPLETED ALL LEVELS RETURN TO GAME SELECTION***");
                    //RESET LBLSCORE TO 0 AND RERUN THE PROGRAM IN A LOOP
                    a = 0;
                    String vals = a.ToString();
                    value[0] = vals;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = vals;

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
            a = 0;
            String val = a.ToString();
            value[0] = val;

            //writing the current score value to the SavedScore text file
            File.WriteAllLines(pointSave, value);
            lblScore.Text = val;

            MessageBox.Show("                  ***YOU HAVE FAILED THIS LEVEL***\n   ***THE LEVEL WILL RESET WHEN YOU CLICK ON OK***");
            //---------------------------------------------------------------------------------------------------------------------------------------

            //converting the array value to an integer
            b = int.Parse(valueScore[0]);

            switch (b)
            {

                case 0:
                    b = 0;
                    String val0 = b.ToString();
                    valueScore[0] = val0;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val0;
                    resetToNewQuestion();

                    break;
                case 1:
                    b = 0;
                    String val1 = b.ToString();
                    valueScore[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val1;
                    resetToNewQuestion();

                    break;
                case 2:
                    b = 0;
                    String val2 = b.ToString();
                    valueScore[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSave, valueScore);
                    lblMistakes.Text = val2;
                    resetToNewQuestion();

                    break;
                case 3:
                    b = 0;
                    String val3 = b.ToString();
                    valueScore[0] = val3;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val3;
                    resetToNewQuestion();

                    break;
                case 4:
                    b = 0;
                    String val4 = b.ToString();
                    valueScore[0] = val4;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val4;
                    resetToNewQuestion();

                    break;
                case 5:
                    b = 0;
                    String val5 = b.ToString();
                    valueScore[0] = val5;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val5;
                    resetToNewQuestion();

                    break;
                case 6:
                    b = 0;
                    String val6 = b.ToString();
                    valueScore[0] = val6;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val6;
                    resetToNewQuestion();

                    break;
                case 7:
                    b = 0;
                    String val7 = b.ToString();
                    valueScore[0] = val7;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val7;
                    resetToNewQuestion();

                    break;

                case 8:
                    b = 0;
                    String val8 = b.ToString();
                    valueScore[0] = val8;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val8;
                    resetToNewQuestion();

                    break;
                case 9:
                    b = 0;
                    String val9 = b.ToString();
                    valueScore[0] = val9;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val9;
                    resetToNewQuestion();

                    break;
                case 10:
                    b = 0;
                    String val10 = b.ToString();
                    valueScore[0] = val10;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val10;
                    resetToNewQuestion();

                    break;
                case 11:
                    b = 0;
                    String val11 = b.ToString();
                    valueScore[0] = val11;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val11;
                    resetToNewQuestion();

                    break;
                case 12:
                    b = 0;
                    String val12 = b.ToString();
                    valueScore[0] = val12;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val12;
                    resetToNewQuestion();

                    break;
                case 13:
                    b = 0;
                    String val13 = b.ToString();
                    valueScore[0] = val13;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val13;
                    resetToNewQuestion();

                    break;
                case 14:
                    b = 0;
                    String val14 = b.ToString();
                    valueScore[0] = val14;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val14;
                    resetToNewQuestion();

                    break;
                case 15:
                    b = 0;
                    String val15 = b.ToString();
                    valueScore[0] = val15;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val15;
                    resetToNewQuestion();

                    break;
                case 16:
                    b = 0;
                    String val16 = b.ToString();
                    valueScore[0] = val16;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val16;
                    resetToNewQuestion();

                    break;
                case 17:
                    b = 0;
                    String val17 = b.ToString();
                    valueScore[0] = val17;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val17;
                    resetToNewQuestion();

                    break;
                case 18:
                    b = 0;
                    String val18 = b.ToString();
                    valueScore[0] = val18;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val18;
                    resetToNewQuestion();

                    break;
                case 19:
                    b = 0;
                    String val19 = b.ToString();
                    valueScore[0] = val19;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val19;
                    resetToNewQuestion();

                    break;
                case 20:
                    b = 0;
                    String val20 = b.ToString();
                    valueScore[0] = val20;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val20;
                    resetToNewQuestion();

                    break;
                case 21:
                    b = 0;
                    String val21 = b.ToString();
                    valueScore[0] = val21;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val21;
                    resetToNewQuestion();

                    break;
                case 22:
                    b = 0;
                    String val22 = b.ToString();
                    valueScore[0] = val22;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val22;
                    resetToNewQuestion();

                    break;
                case 23:
                    b = 0;
                    String val23 = b.ToString();
                    valueScore[0] = val23;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val23;
                    resetToNewQuestion();

                    break;
                case 24:
                    b = 0;
                    String val24 = b.ToString();
                    valueScore[0] = val24;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val24;
                    resetToNewQuestion();

                    break;
                case 25:
                    b = 0;
                    String val25 = b.ToString();
                    valueScore[0] = val25;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val25;
                    resetToNewQuestion();

                    break;
                case 26:
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("It Has been completed!");
                    break;



            }



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
                case 10:
                    MatchUpEleven();
                    break;
                case 11:
                    MatchUpTwelve();
                    break;
                case 12:
                    MatchUpThirteen();
                    break;
                case 13:
                    MatchUpFourteen();
                    break;
                case 14:
                    MatchUpFifteen();
                    break;
                case 15:
                    MatchUpSixteen();
                    break;
                case 16:
                    MatchUpSeventeen();
                    break;
                case 17:
                    MatchUpEighteen();
                    break;
                case 18:
                    MatchUpNineteen();
                    break;
                case 19:
                    MatchUpTwenty();
                    break;
                case 20:
                    MatchUpTwentyone();
                    break;
                case 21:
                    MatchUpTwentytwo();
                    break;
                case 22:
                    MatchUpTwentythree();
                    break;
                case 23:
                    MatchUpTwentyfour();
                    break;
                case 24:
                    MatchUpTwentyfive();
                    break;
                case 25:
                    MatchUpTwentysix();
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
            a = int.Parse(value[0]);

            switch (a) {
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
                case 10:
                    hint11.Play();
                    break;
                case 11:
                    hint12.Play();
                    break;
                case 12:
                    hint13.Play();
                    break;
                case 13:
                    hint14.Play();
                    break;
                case 14:
                    hint15.Play();
                    break;
                case 15:
                    hint16.Play();
                    break;
                case 16:
                    hint17.Play();
                    break;
                case 17:
                    hint18.Play();
                    break;
                case 18:
                    hint19.Play();
                    break;
                case 19:
                    hint20.Play();
                    break;
                case 20:
                    hint21.Play();
                    break;
                case 21:
                    hint22.Play();
                    break;
                case 22:
                    hint23.Play();
                    break;
                case 23:
                    hint24.Play();
                    break;
                case 24:
                    hint25.Play();
                    break;
                case 25:
                    hint26.Play();
                    break;
                default:
                    MessageBox.Show("It is done");
                    break;
            }
        }
    }
}
