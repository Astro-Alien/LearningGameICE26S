
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
            this.label1 = new System.Windows.Forms.Label();
            this.pAnswer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmission = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(14, 9);
            this.pointsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(228, 45);
            this.pointsLbl.TabIndex = 9;
            this.pointsLbl.Text = "Points scored: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(223, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 45);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "0";
            // 
            // mistakesLbl
            // 
            this.mistakesLbl.AutoSize = true;
            this.mistakesLbl.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mistakesLbl.Location = new System.Drawing.Point(637, 9);
            this.mistakesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mistakesLbl.Name = "mistakesLbl";
            this.mistakesLbl.Size = new System.Drawing.Size(215, 38);
            this.mistakesLbl.TabIndex = 13;
            this.mistakesLbl.Text = "Mistakes made: ";
            // 
            // lblMistakes
            // 
            this.lblMistakes.AutoSize = true;
            this.lblMistakes.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMistakes.Location = new System.Drawing.Point(836, 9);
            this.lblMistakes.Name = "lblMistakes";
            this.lblMistakes.Size = new System.Drawing.Size(32, 38);
            this.lblMistakes.TabIndex = 14;
            this.lblMistakes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(860, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "out of 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "PLACE HOLDER";
            // 
            // pAnswer
            // 
            this.pAnswer.Location = new System.Drawing.Point(336, 108);
            this.pAnswer.Name = "pAnswer";
            this.pAnswer.Size = new System.Drawing.Size(275, 206);
            this.pAnswer.TabIndex = 17;
            this.pAnswer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(259, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "WRITE THE NAME OF THE OBJECT IN THE IMAGE";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnswer.Location = new System.Drawing.Point(336, 381);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(275, 38);
            this.txtAnswer.TabIndex = 19;
            // 
            // btnSubmission
            // 
            this.btnSubmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmission.Location = new System.Drawing.Point(421, 437);
            this.btnSubmission.Name = "btnSubmission";
            this.btnSubmission.Size = new System.Drawing.Size(94, 44);
            this.btnSubmission.TabIndex = 20;
            this.btnSubmission.Text = "Submit";
            this.btnSubmission.UseVisualStyleBackColor = true;
            this.btnSubmission.Click += new System.EventHandler(this.btnSubmission_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(415, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 51);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 592);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmission);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMistakes);
            this.Controls.Add(this.mistakesLbl);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pointsLbl);
            this.Name = "TestForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm2";
            this.Load += new System.EventHandler(this.TestForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label mistakesLbl;
        private System.Windows.Forms.Label lblMistakes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmission;
        private System.Windows.Forms.Button btnBack;
    }
}