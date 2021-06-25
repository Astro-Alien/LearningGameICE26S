
namespace LearningGame1
{
    partial class Numbers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointsLbl = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.mistakesLbl = new System.Windows.Forms.Label();
            this.lblMistakes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessTheWordsLbl = new System.Windows.Forms.Label();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.hintGroupBox = new System.Windows.Forms.GroupBox();
            this.letter4 = new System.Windows.Forms.TextBox();
            this.letter3 = new System.Windows.Forms.TextBox();
            this.letter2 = new System.Windows.Forms.TextBox();
            this.letter1 = new System.Windows.Forms.TextBox();
            this.answerGroupBox = new System.Windows.Forms.GroupBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.hintGroupBox.SuspendLayout();
            this.answerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(28, 34);
            this.pointsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(228, 45);
            this.pointsLbl.TabIndex = 1;
            this.pointsLbl.Text = "Points scored: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(264, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 45);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "0";
            // 
            // mistakesLbl
            // 
            this.mistakesLbl.AutoSize = true;
            this.mistakesLbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mistakesLbl.Location = new System.Drawing.Point(1012, 34);
            this.mistakesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mistakesLbl.Name = "mistakesLbl";
            this.mistakesLbl.Size = new System.Drawing.Size(179, 31);
            this.mistakesLbl.TabIndex = 11;
            this.mistakesLbl.Text = "Mistakes made: ";
            // 
            // lblMistakes
            // 
            this.lblMistakes.AutoSize = true;
            this.lblMistakes.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMistakes.Location = new System.Drawing.Point(1189, 34);
            this.lblMistakes.Name = "lblMistakes";
            this.lblMistakes.Size = new System.Drawing.Size(26, 31);
            this.lblMistakes.TabIndex = 12;
            this.lblMistakes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1213, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "out of 3";
            // 
            // guessTheWordsLbl
            // 
            this.guessTheWordsLbl.AutoSize = true;
            this.guessTheWordsLbl.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessTheWordsLbl.Location = new System.Drawing.Point(647, 149);
            this.guessTheWordsLbl.Name = "guessTheWordsLbl";
            this.guessTheWordsLbl.Size = new System.Drawing.Size(598, 38);
            this.guessTheWordsLbl.TabIndex = 14;
            this.guessTheWordsLbl.Text = "Guess the correct letters to complete the word:";
            // 
            // pBox1
            // 
            this.pBox1.Location = new System.Drawing.Point(28, 128);
            this.pBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(509, 500);
            this.pBox1.TabIndex = 15;
            this.pBox1.TabStop = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(698, 522);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(493, 72);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // hintGroupBox
            // 
            this.hintGroupBox.Controls.Add(this.letter4);
            this.hintGroupBox.Controls.Add(this.letter3);
            this.hintGroupBox.Controls.Add(this.letter2);
            this.hintGroupBox.Controls.Add(this.letter1);
            this.hintGroupBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hintGroupBox.Location = new System.Drawing.Point(698, 211);
            this.hintGroupBox.Name = "hintGroupBox";
            this.hintGroupBox.Size = new System.Drawing.Size(497, 131);
            this.hintGroupBox.TabIndex = 19;
            this.hintGroupBox.TabStop = false;
            this.hintGroupBox.Text = "Hint";
            // 
            // letter4
            // 
            this.letter4.Location = new System.Drawing.Point(351, 50);
            this.letter4.Margin = new System.Windows.Forms.Padding(5);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(65, 38);
            this.letter4.TabIndex = 6;
            // 
            // letter3
            // 
            this.letter3.Location = new System.Drawing.Point(264, 50);
            this.letter3.Margin = new System.Windows.Forms.Padding(5);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(65, 38);
            this.letter3.TabIndex = 5;
            // 
            // letter2
            // 
            this.letter2.Location = new System.Drawing.Point(178, 50);
            this.letter2.Margin = new System.Windows.Forms.Padding(5);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(65, 38);
            this.letter2.TabIndex = 4;
            // 
            // letter1
            // 
            this.letter1.Location = new System.Drawing.Point(91, 50);
            this.letter1.Margin = new System.Windows.Forms.Padding(5);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(65, 38);
            this.letter1.TabIndex = 3;
            // 
            // answerGroupBox
            // 
            this.answerGroupBox.Controls.Add(this.t3);
            this.answerGroupBox.Controls.Add(this.t4);
            this.answerGroupBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerGroupBox.Location = new System.Drawing.Point(698, 377);
            this.answerGroupBox.Name = "answerGroupBox";
            this.answerGroupBox.Size = new System.Drawing.Size(497, 125);
            this.answerGroupBox.TabIndex = 16;
            this.answerGroupBox.TabStop = false;
            this.answerGroupBox.Text = "Answer";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(165, 55);
            this.t3.Margin = new System.Windows.Forms.Padding(5);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(65, 38);
            this.t3.TabIndex = 4;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(276, 55);
            this.t4.Margin = new System.Windows.Forms.Padding(5);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(62, 38);
            this.t4.TabIndex = 4;
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playBtn.Location = new System.Drawing.Point(28, 658);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(94, 40);
            this.playBtn.TabIndex = 20;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(905, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(605, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Counting To Ten";
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.answerGroupBox);
            this.Controls.Add(this.hintGroupBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.guessTheWordsLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMistakes);
            this.Controls.Add(this.mistakesLbl);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pointsLbl);
            this.MaximizeBox = false;
            this.Name = "Numbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numbers";
            this.Load += new System.EventHandler(this.Numbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.hintGroupBox.ResumeLayout(false);
            this.hintGroupBox.PerformLayout();
            this.answerGroupBox.ResumeLayout(false);
            this.answerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label mistakesLbl;
        private System.Windows.Forms.Label lblMistakes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guessTheWordsLbl;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox hintGroupBox;
        private System.Windows.Forms.TextBox letter4;
        private System.Windows.Forms.TextBox letter3;
        private System.Windows.Forms.TextBox letter2;
        private System.Windows.Forms.TextBox letter1;
        private System.Windows.Forms.GroupBox answerGroupBox;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}