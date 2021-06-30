
namespace LearningGame1
{
    partial class TestForm2
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
            this.label4 = new System.Windows.Forms.Label();
            this.pAnswer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmission = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pAnswer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(9, 11);
            this.pointsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(124, 45);
            this.pointsLbl.TabIndex = 9;
            this.pointsLbl.Text = "Points: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(123, 11);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 45);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "0";
            // 
            // mistakesLbl
            // 
            this.mistakesLbl.AutoSize = true;
            this.mistakesLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mistakesLbl.Location = new System.Drawing.Point(18, 16);
            this.mistakesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mistakesLbl.Name = "mistakesLbl";
            this.mistakesLbl.Size = new System.Drawing.Size(162, 45);
            this.mistakesLbl.TabIndex = 13;
            this.mistakesLbl.Text = "Mistakes: ";
            // 
            // lblMistakes
            // 
            this.lblMistakes.AutoSize = true;
            this.lblMistakes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMistakes.Location = new System.Drawing.Point(170, 16);
            this.lblMistakes.Name = "lblMistakes";
            this.lblMistakes.Size = new System.Drawing.Size(38, 45);
            this.lblMistakes.TabIndex = 14;
            this.lblMistakes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(205, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 45);
            this.label4.TabIndex = 15;
            this.label4.Text = "out of 3";
            // 
            // pAnswer
            // 
            this.pAnswer.Location = new System.Drawing.Point(255, 165);
            this.pAnswer.Name = "pAnswer";
            this.pAnswer.Size = new System.Drawing.Size(275, 206);
            this.pAnswer.TabIndex = 17;
            this.pAnswer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "WRITE THE NAME OF THE OBJECT IN THE IMAGE";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnswer.Location = new System.Drawing.Point(255, 450);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(275, 38);
            this.txtAnswer.TabIndex = 19;
            // 
            // btnSubmission
            // 
            this.btnSubmission.BackColor = System.Drawing.Color.OldLace;
            this.btnSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmission.Location = new System.Drawing.Point(255, 525);
            this.btnSubmission.Name = "btnSubmission";
            this.btnSubmission.Size = new System.Drawing.Size(275, 77);
            this.btnSubmission.TabIndex = 20;
            this.btnSubmission.Text = "Submit";
            this.btnSubmission.UseVisualStyleBackColor = false;
            this.btnSubmission.Click += new System.EventHandler(this.btnSubmission_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.OldLace;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 612);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 60);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.pointsLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 73);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.lblMistakes);
            this.panel2.Controls.Add(this.mistakesLbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(482, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 73);
            this.panel2.TabIndex = 23;
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(849, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmission);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pAnswer);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm2";
            this.Load += new System.EventHandler(this.TestForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAnswer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label mistakesLbl;
        private System.Windows.Forms.Label lblMistakes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmission;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}