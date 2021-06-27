
namespace LearningGame1
{
    partial class Days
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointsLbl = new System.Windows.Forms.Label();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.mistakesLbl = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.guessTheWordsLbl = new System.Windows.Forms.Label();
            this.hintGroupBox = new System.Windows.Forms.GroupBox();
            this.letter9 = new System.Windows.Forms.TextBox();
            this.letter8 = new System.Windows.Forms.TextBox();
            this.letter7 = new System.Windows.Forms.TextBox();
            this.letter6 = new System.Windows.Forms.TextBox();
            this.letter5 = new System.Windows.Forms.TextBox();
            this.letter4 = new System.Windows.Forms.TextBox();
            this.letter3 = new System.Windows.Forms.TextBox();
            this.letter2 = new System.Windows.Forms.TextBox();
            this.answerGroupBox = new System.Windows.Forms.GroupBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMistakes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.hintGroupBox.SuspendLayout();
            this.answerGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(12, 15);
            this.pointsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(124, 45);
            this.pointsLbl.TabIndex = 0;
            this.pointsLbl.Text = "Points: ";
            // 
            // pBox1
            // 
            this.pBox1.Location = new System.Drawing.Point(28, 128);
            this.pBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(514, 426);
            this.pBox1.TabIndex = 1;
            this.pBox1.TabStop = false;
            // 
            // mistakesLbl
            // 
            this.mistakesLbl.AutoSize = true;
            this.mistakesLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mistakesLbl.Location = new System.Drawing.Point(18, 12);
            this.mistakesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mistakesLbl.Name = "mistakesLbl";
            this.mistakesLbl.Size = new System.Drawing.Size(162, 45);
            this.mistakesLbl.TabIndex = 2;
            this.mistakesLbl.Text = "Mistakes: ";
            // 
            // letter1
            // 
            this.letter1.Location = new System.Drawing.Point(8, 50);
            this.letter1.Margin = new System.Windows.Forms.Padding(5);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(65, 38);
            this.letter1.TabIndex = 3;
            this.letter1.TextChanged += new System.EventHandler(this.letter1_TextChanged);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(228, 55);
            this.t4.Margin = new System.Windows.Forms.Padding(5);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(62, 38);
            this.t4.TabIndex = 4;
            // 
            // guessTheWordsLbl
            // 
            this.guessTheWordsLbl.AutoSize = true;
            this.guessTheWordsLbl.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessTheWordsLbl.ForeColor = System.Drawing.Color.Black;
            this.guessTheWordsLbl.Location = new System.Drawing.Point(634, 149);
            this.guessTheWordsLbl.Name = "guessTheWordsLbl";
            this.guessTheWordsLbl.Size = new System.Drawing.Size(598, 38);
            this.guessTheWordsLbl.TabIndex = 5;
            this.guessTheWordsLbl.Text = "Guess the correct letters to complete the word:";
            // 
            // hintGroupBox
            // 
            this.hintGroupBox.BackColor = System.Drawing.Color.LightSalmon;
            this.hintGroupBox.Controls.Add(this.letter9);
            this.hintGroupBox.Controls.Add(this.letter8);
            this.hintGroupBox.Controls.Add(this.letter7);
            this.hintGroupBox.Controls.Add(this.letter6);
            this.hintGroupBox.Controls.Add(this.letter5);
            this.hintGroupBox.Controls.Add(this.letter4);
            this.hintGroupBox.Controls.Add(this.letter3);
            this.hintGroupBox.Controls.Add(this.letter2);
            this.hintGroupBox.Controls.Add(this.letter1);
            this.hintGroupBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hintGroupBox.ForeColor = System.Drawing.Color.Black;
            this.hintGroupBox.Location = new System.Drawing.Point(597, 210);
            this.hintGroupBox.Name = "hintGroupBox";
            this.hintGroupBox.Size = new System.Drawing.Size(691, 131);
            this.hintGroupBox.TabIndex = 6;
            this.hintGroupBox.TabStop = false;
            this.hintGroupBox.Text = "Hint";
            // 
            // letter9
            // 
            this.letter9.Location = new System.Drawing.Point(608, 50);
            this.letter9.Margin = new System.Windows.Forms.Padding(5);
            this.letter9.Name = "letter9";
            this.letter9.Size = new System.Drawing.Size(65, 38);
            this.letter9.TabIndex = 11;
            // 
            // letter8
            // 
            this.letter8.Location = new System.Drawing.Point(533, 50);
            this.letter8.Margin = new System.Windows.Forms.Padding(5);
            this.letter8.Name = "letter8";
            this.letter8.Size = new System.Drawing.Size(65, 38);
            this.letter8.TabIndex = 10;
            // 
            // letter7
            // 
            this.letter7.Location = new System.Drawing.Point(458, 50);
            this.letter7.Margin = new System.Windows.Forms.Padding(5);
            this.letter7.Name = "letter7";
            this.letter7.Size = new System.Drawing.Size(65, 38);
            this.letter7.TabIndex = 9;
            // 
            // letter6
            // 
            this.letter6.Location = new System.Drawing.Point(383, 50);
            this.letter6.Margin = new System.Windows.Forms.Padding(5);
            this.letter6.Name = "letter6";
            this.letter6.Size = new System.Drawing.Size(65, 38);
            this.letter6.TabIndex = 8;
            // 
            // letter5
            // 
            this.letter5.Location = new System.Drawing.Point(308, 50);
            this.letter5.Margin = new System.Windows.Forms.Padding(5);
            this.letter5.Name = "letter5";
            this.letter5.Size = new System.Drawing.Size(65, 38);
            this.letter5.TabIndex = 7;
            // 
            // letter4
            // 
            this.letter4.Location = new System.Drawing.Point(233, 50);
            this.letter4.Margin = new System.Windows.Forms.Padding(5);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(65, 38);
            this.letter4.TabIndex = 6;
            // 
            // letter3
            // 
            this.letter3.Location = new System.Drawing.Point(158, 50);
            this.letter3.Margin = new System.Windows.Forms.Padding(5);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(65, 38);
            this.letter3.TabIndex = 5;
            // 
            // letter2
            // 
            this.letter2.Location = new System.Drawing.Point(83, 50);
            this.letter2.Margin = new System.Windows.Forms.Padding(5);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(65, 38);
            this.letter2.TabIndex = 4;
            // 
            // answerGroupBox
            // 
            this.answerGroupBox.BackColor = System.Drawing.Color.LightSalmon;
            this.answerGroupBox.Controls.Add(this.t6);
            this.answerGroupBox.Controls.Add(this.t5);
            this.answerGroupBox.Controls.Add(this.t3);
            this.answerGroupBox.Controls.Add(this.t4);
            this.answerGroupBox.ForeColor = System.Drawing.Color.Black;
            this.answerGroupBox.Location = new System.Drawing.Point(698, 372);
            this.answerGroupBox.Name = "answerGroupBox";
            this.answerGroupBox.Size = new System.Drawing.Size(497, 125);
            this.answerGroupBox.TabIndex = 7;
            this.answerGroupBox.TabStop = false;
            this.answerGroupBox.Text = "Answer";
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(427, 55);
            this.t6.Margin = new System.Windows.Forms.Padding(5);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(62, 38);
            this.t6.TabIndex = 6;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(333, 55);
            this.t5.Margin = new System.Windows.Forms.Padding(5);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(62, 38);
            this.t5.TabIndex = 5;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(117, 55);
            this.t3.Margin = new System.Windows.Forms.Padding(5);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(65, 38);
            this.t3.TabIndex = 4;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Moccasin;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Location = new System.Drawing.Point(698, 556);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(493, 115);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(121, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 45);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // lblMistakes
            // 
            this.lblMistakes.AutoSize = true;
            this.lblMistakes.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMistakes.Location = new System.Drawing.Point(170, 12);
            this.lblMistakes.Name = "lblMistakes";
            this.lblMistakes.Size = new System.Drawing.Size(38, 45);
            this.lblMistakes.TabIndex = 10;
            this.lblMistakes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "out of 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Days of the week";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Moccasin;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(300, 588);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(272, 83);
            this.playBtn.TabIndex = 13;
            this.playBtn.Text = "Play Hint";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(28, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 83);
            this.button2.TabIndex = 14;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.pointsLbl);
            this.panel1.Location = new System.Drawing.Point(644, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 73);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 73);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.lblMistakes);
            this.panel3.Controls.Add(this.mistakesLbl);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(926, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 73);
            this.panel3.TabIndex = 17;
            // 
            // Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1317, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.guessTheWordsLbl);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.hintGroupBox);
            this.Controls.Add(this.answerGroupBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Days";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mistakes made: 0 out of 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.hintGroupBox.ResumeLayout(false);
            this.hintGroupBox.PerformLayout();
            this.answerGroupBox.ResumeLayout(false);
            this.answerGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label mistakesLbl;
        private System.Windows.Forms.TextBox letter1;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label guessTheWordsLbl;
        private System.Windows.Forms.GroupBox hintGroupBox;
        private System.Windows.Forms.TextBox letter5;
        private System.Windows.Forms.TextBox letter4;
        private System.Windows.Forms.TextBox letter3;
        private System.Windows.Forms.TextBox letter2;
        private System.Windows.Forms.GroupBox answerGroupBox;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMistakes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letter8;
        private System.Windows.Forms.TextBox letter7;
        private System.Windows.Forms.TextBox letter6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox letter9;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

