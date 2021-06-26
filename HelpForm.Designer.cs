
namespace LearningGame1
{
    partial class HelpForm
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
            this.helpRTBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpRTBox
            // 
            this.helpRTBox.BackColor = System.Drawing.Color.OldLace;
            this.helpRTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpRTBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpRTBox.Location = new System.Drawing.Point(47, 102);
            this.helpRTBox.Name = "helpRTBox";
            this.helpRTBox.Size = new System.Drawing.Size(644, 258);
            this.helpRTBox.TabIndex = 0;
            this.helpRTBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "How to play:";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.OldLace;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goBackBtn.Location = new System.Drawing.Point(263, 410);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(213, 52);
            this.goBackBtn.TabIndex = 2;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpRTBox);
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpRTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackBtn;
    }
}