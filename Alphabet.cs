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
        private static string pointSave = @"C:\Users\Charles\Downloads\LearningGameICE26S\SavedScoreAlphabet.txt";
        private string[] value = File.ReadAllLines(pointSave);

        private static string pointSaveM = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesAlphabet.txt";
        private string[] valueM = File.ReadAllLines(pointSaveM);

        private static string pointMistakes = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesAlphabet.txt";
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

            hint1.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\arm.wav";
            hint2.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\bus.wav";
            hint3.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\coke.wav";
            hint4.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\dam.wav";
            hint5.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\eier.wav";
            hint6.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\fiets.wav";
            hint7.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\gans.wav";
            hint8.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\hond.wav";
            hint9.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\ink.wav";
            hint10.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\jas.wav";
            hint11.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\kat.wav";
            hint12.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\leeu.wav";
            hint13.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\melk.wav";
            hint14.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\nes.wav";
            hint15.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\olie.wav";
            hint16.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\pen.wav";
            hint17.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\queen.wav";
            hint18.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\reen.wav";
            hint19.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\ster.wav";
            hint20.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\tuin.wav";
            hint21.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\uil.wav";
            hint22.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\vark.wav";
            hint23.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\wurm.wav";
            hint24.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\xiolofoon.wav";
            hint25.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\ys.wav";
            hint26.SoundLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\soundAlphabet\zoeloe.wav";

        }

        private void Alphabet_Load(object sender, EventArgs e)
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
                case 10:
                case 11:
                case 12:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
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
            submitBtn.Focus();
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\a.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwo()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\b.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelThree()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\c.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelFour()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\D.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelFive()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\e.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSix()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\f.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSeven()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\g.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelEight()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\h.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelNine()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\i.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\j.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelEleven()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\k.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwelve()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\l.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelThirteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\M.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelFourteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\n.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelFifteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\o.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelSixteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\p.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSeventeen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\q.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelEighteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\r.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelNineteen()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\S.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwenty()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\t.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyone()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\u.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwentytwo()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\V.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentythree()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\W.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyfour()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\x.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;




        }
        private void LevelTwentyfive()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;
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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\y.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelTwentysix()
        {
            a = 0;
            String res = a.ToString();
            valueM[0] = res;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res;

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
            pBox1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\images\z.jpg";
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


            else
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
        private void MatchUpTwentyfour()
        {
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
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
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
                    t3.Text = "";
                    LevelTwo();

                    break;
                case 2:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThree();

                    break;
                case 3:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelFour();

                    break;
                case 4:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFive();

                    break;
                case 5:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSix();

                    break;
                case 6:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeven();

                    break;
                case 7:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelEight();

                    break;
                case 8:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelNine();

                    break;
                case 9:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelTen();

                    break;
                case 10:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelEleven();

                    break;
                case 11:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwelve();

                    break;
                case 12:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelThirteen();

                    break;
                case 13:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelFourteen();

                    break;
                case 14:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelFifteen();

                    break;
                case 15:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelSixteen();

                    break;
                case 16:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    letter5.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelSeventeen();

                    break;
                case 17:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelEighteen();
                    break;
                case 18:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelNineteen();
                    break;
                case 19:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwenty();
                    break;
                case 20:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelTwentyone();

                    break;
                case 21:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwentytwo();
                    break;
                case 22:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t4.Visible = true;
                    letter4.Visible = true;
                    t3.Text = "";
                    t4.Text = "";
                    LevelTwentythree();
                    break;
                case 23:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
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
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    t3.Text = "";
                    LevelTwentyfive();

                    break;
                case 25:
                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
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

        private void playBtn_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelOptionsForm levelsCaller = new LevelOptionsForm();
            levelsCaller.ShowDialog();
            this.Close();
        }
    }
}
