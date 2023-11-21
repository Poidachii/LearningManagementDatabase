using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class QuestionCreation
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
            this.ImportQuestion = new System.Windows.Forms.Button();
            this.CheckExist = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QtoMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportQuestion
            // 
            this.ImportQuestion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ImportQuestion.Location = new System.Drawing.Point(178, 282);
            this.ImportQuestion.Name = "ImportQuestion";
            this.ImportQuestion.Size = new System.Drawing.Size(132, 47);
            this.ImportQuestion.TabIndex = 15;
            this.ImportQuestion.Text = "Import to Bank";
            this.ImportQuestion.UseVisualStyleBackColor = true;
            // 
            // CheckExist
            // 
            this.CheckExist.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CheckExist.Location = new System.Drawing.Point(21, 282);
            this.CheckExist.Name = "CheckExist";
            this.CheckExist.Size = new System.Drawing.Size(132, 47);
            this.CheckExist.TabIndex = 14;
            this.CheckExist.Text = "Check Existence";
            this.CheckExist.UseVisualStyleBackColor = true;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.AnswerBox.Location = new System.Drawing.Point(142, 230);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.PasswordChar = '*';
            this.AnswerBox.Size = new System.Drawing.Size(335, 39);
            this.AnswerBox.TabIndex = 13;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.QuestionBox.Location = new System.Drawing.Point(142, 175);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(335, 39);
            this.QuestionBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(21, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Answer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(212, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Question :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question Bank Manager";
            // 
            // QtoMenu
            // 
            this.QtoMenu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.QtoMenu.Location = new System.Drawing.Point(334, 282);
            this.QtoMenu.Name = "QtoMenu";
            this.QtoMenu.Size = new System.Drawing.Size(132, 47);
            this.QtoMenu.TabIndex = 16;
            this.QtoMenu.Text = "Return to Menu";
            this.QtoMenu.UseVisualStyleBackColor = true;
            // 
            // QuestionCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 390);
            this.Controls.Add(this.QtoMenu);
            this.Controls.Add(this.ImportQuestion);
            this.Controls.Add(this.CheckExist);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuestionCreation";
            this.Text = "QuestionCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportQuestion;
        private System.Windows.Forms.Button CheckExist;
        private TextBox AnswerBox;
        private TextBox QuestionBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button QtoMenu;
    }
}