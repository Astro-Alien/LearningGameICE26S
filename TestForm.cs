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
    public partial class TestForm : Form
    {
        private static string pointSave = @"C:\Users\Charles\Downloads\LearningGameICE26S\SavedScoreTest.txt";
        private static string[] value = File.ReadAllLines(pointSave);

        private static string pointSaveM = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesTest.txt";
        private static string[] valueM = File.ReadAllLines(pointSaveM);

        private static string pointMistakes = @"C:\Users\Charles\Downloads\LearningGameICE26S\MistakesTest.txt";
        private static string[] valueMistake = File.ReadAllLines(pointMistakes);
        public TestForm()
        {

            InitializeComponent();


            lblScore.Text = value[0];
            //converting the array value to an integer

            int a = int.Parse(value[0]);

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
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;
            btnBack.Focus();
            lblWord.Text = "APPEL";
            lblWord.Location = new Point(410, 100);
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\apples.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\orange.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\grapes.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelTwo()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "PEN";
            lblWord.Location = new Point(424, 106);
            btnAnswerOne.Location = new Point(672, 434);
            btnAnswerOne.Text = "C";
            btnAnswerThree.Location = new Point(73, 434);
            btnAnswerThree.Text = "A";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\pencil.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\marker.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\pen.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelThree()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "BUS";
            lblWord.Location = new Point(424, 106);
            btnAnswerOne.Location = new Point(378, 434);
            btnAnswerOne.Text = "B";
            btnAnswerTwo.Location = new Point(73, 434);
            btnAnswerTwo.Text = "A";
            btnAnswerThree.Location = new Point(672, 434);
            btnAnswerThree.Text = "C";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\car.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\bus.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\bike.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFour()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "HOND";
            lblWord.Location = new Point(403, 105);
            btnAnswerOne.Location = new Point(73, 434);
            btnAnswerOne.Text = "A";
            btnAnswerTwo.Location = new Point(378, 434);
            btnAnswerTwo.Text = "B";
            btnAnswerThree.Location = new Point(672, 434);
            btnAnswerThree.Text = "C";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\dog.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\rabbit.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\cat.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFive()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "YS";
            lblWord.Location = new Point(442, 103);
            btnAnswerOne.Location = new Point(672, 434);
            btnAnswerOne.Text = "C";
            btnAnswerTwo.Location = new Point(378, 434);
            btnAnswerTwo.Text = "B";
            btnAnswerThree.Location = new Point(73, 434);
            btnAnswerThree.Text = "A";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\glass.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\crystal.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\ice.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelSix()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "MELK";
            lblWord.Location = new Point(412, 100);
            btnAnswerOne.Location = new Point(672, 434);
            btnAnswerOne.Text = "C";
            btnAnswerTwo.Location = new Point(378, 434);
            btnAnswerTwo.Text = "B";
            btnAnswerThree.Location = new Point(73, 434);
            btnAnswerThree.Text = "A";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\water.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\juice.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\milk.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelSeven()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "UIL";
            lblWord.Location = new Point(424, 106);
            btnAnswerOne.Location = new Point(378, 434);
            btnAnswerOne.Text = "B";
            btnAnswerTwo.Location = new Point(672, 434);
            btnAnswerTwo.Text = "A";
            btnAnswerThree.Location = new Point(73, 434);
            btnAnswerThree.Text = "C";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\pigeon.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\owl.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\eagle.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelEight()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "DAM";
            lblWord.Location = new Point(424, 106);
            btnAnswerOne.Location = new Point(672, 434);
            btnAnswerOne.Text = "C";
            btnAnswerTwo.Location = new Point(378, 434);
            btnAnswerTwo.Text = "B";
            btnAnswerThree.Location = new Point(73, 434);
            btnAnswerThree.Text = "A";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\river.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\ocean.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\Dam.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelNine()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "EIER";
            lblWord.Location = new Point(421, 101);
            btnAnswerOne.Location = new Point(378, 434);
            btnAnswerOne.Text = "B";
            btnAnswerTwo.Location = new Point(73, 434);
            btnAnswerTwo.Text = "A";
            btnAnswerThree.Location = new Point(672, 434);
            btnAnswerThree.Text = "C";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\golf.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\egg.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\ball.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelTen()
        {
            int a = 0;
            String res1 = a.ToString();
            valueM[0] = res1;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res1;

            btnBack.Focus();
            lblWord.Text = "FIETS";
            lblWord.Location = new Point(415, 101);
            btnAnswerOne.Location = new Point(73, 434);
            btnAnswerOne.Text = "A";
            btnAnswerTwo.Location = new Point(378, 434);
            btnAnswerTwo.Text = "B";
            btnAnswerThree.Location = new Point(672, 434);
            btnAnswerThree.Text = "C";
            p1.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\bicycle.jpg";
            p1.SizeMode = PictureBoxSizeMode.CenterImage;
            p2.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\skateboard.jpg";
            p2.SizeMode = PictureBoxSizeMode.CenterImage;
            p3.ImageLocation = @"C:\Users\Charles\Downloads\LearningGameICE26S\Fruit Images\rollerblade.jpg";
            p3.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void resetToNewQuestion()
        {
            //converting the array value to an integer

            int a = int.Parse(value[0]);
            //The switch when called will check the value in the txt file and call the level after that value e.g(a =1 that means call level 2).
            switch (a)
            {

                case 0:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelOne();

                    break;
                case 1:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelTwo();

                    break;
                case 2:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelThree();

                    break;
                case 3:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelFour();

                    break;
                case 4:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelFive();

                    break;
                case 5:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelSix();

                    break;
                case 6:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelSeven();

                    break;
                case 7:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelEight();

                    break;
                case 8:

                    valueMistake[0] = "0";
                    File.WriteAllLines(pointMistakes, valueMistake);
                    lblMistakes.Text = valueMistake[0];
                    LevelNine();

                    break;
                case 9:

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswerOne_Click_1(object sender, EventArgs e)
        {
            //incrementation and level change comes in here

            lblScore.Text = value[0];
            //converting the array value to an integer

            int a = int.Parse(value[0]);
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
                    MessageBox.Show("CORRECT ANSWER");
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("   ***YOU HAVE FINISHED THE TEST***");
                    break;
            }
        }

        private void btnAnswerTwo_Click_1(object sender, EventArgs e)
        {


            //converting the array value to an integer
            int b = int.Parse(valueM[0]);
            switch (b)
            {

                case 0:
                    b += 1;
                    String val = b.ToString();
                    valueM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    MessageBox.Show("   INCORRECT ANSWER");
                    lblMistakes.Text = val;
                    break;
                case 1:
                    b += 1;
                    String val1 = b.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    lblMistakes.Text = val1;
                    MessageBox.Show("   INCORRECT ANSWER");
                    GameOver();
                    break;



                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }
        }

        private void btnAnswerThree_Click_1(object sender, EventArgs e)
        {


            //converting the array value to an integer
            int b = int.Parse(valueM[0]);
            switch (b)
            {
                case 0:
                    b += 1;
                    String val = b.ToString();
                    valueM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    MessageBox.Show("   INCORRECT ANSWER");
                    lblMistakes.Text = val;
                    break;
                case 1:
                    b += 1;
                    String val1 = b.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    MessageBox.Show("   INCORRECT ANSWER");
                    lblMistakes.Text = val1;
                    GameOver();
                    break;




                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelOptionsForm levelCaller = new LevelOptionsForm();
            levelCaller.ShowDialog();
            this.Close();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
