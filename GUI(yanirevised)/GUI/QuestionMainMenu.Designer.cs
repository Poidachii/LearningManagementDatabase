
namespace GUI
{
    partial class QuestionMainMenu
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
            this.CreateQuestionBtn = new System.Windows.Forms.Button();
            this.EditQuestionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateQuestionBtn
            // 
            this.CreateQuestionBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CreateQuestionBtn.Location = new System.Drawing.Point(109, 124);
            this.CreateQuestionBtn.Name = "CreateQuestionBtn";
            this.CreateQuestionBtn.Size = new System.Drawing.Size(202, 59);
            this.CreateQuestionBtn.TabIndex = 1;
            this.CreateQuestionBtn.Text = "Create Question";
            this.CreateQuestionBtn.UseVisualStyleBackColor = true;
            this.CreateQuestionBtn.Click += new System.EventHandler(this.CreateQuestionBtn_Click);
            // 
            // EditQuestionBtn
            // 
            this.EditQuestionBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EditQuestionBtn.Location = new System.Drawing.Point(109, 189);
            this.EditQuestionBtn.Name = "EditQuestionBtn";
            this.EditQuestionBtn.Size = new System.Drawing.Size(202, 59);
            this.EditQuestionBtn.TabIndex = 2;
            this.EditQuestionBtn.Text = "Edit Question";
            this.EditQuestionBtn.UseVisualStyleBackColor = true;
            this.EditQuestionBtn.Click += new System.EventHandler(this.EditQuestionBtn_Click);
            // 
            // QuestionMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.EditQuestionBtn);
            this.Controls.Add(this.CreateQuestionBtn);
            this.Name = "QuestionMainMenu";
            this.Text = "QuestionMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateQuestionBtn;
        private System.Windows.Forms.Button EditQuestionBtn;
    }
}