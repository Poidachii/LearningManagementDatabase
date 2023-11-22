
namespace GUI
{
    partial class Form1
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentCourseDropdown = new System.Windows.Forms.ComboBox();
            this.CourseListLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.StudentCourseDropdown, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.CourseListLabel, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(345, 238);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(863, 55);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // StudentCourseDropdown
            // 
            this.StudentCourseDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.StudentCourseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentCourseDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCourseDropdown.FormattingEnabled = true;
            this.StudentCourseDropdown.Location = new System.Drawing.Point(3, 28);
            this.StudentCourseDropdown.Name = "StudentCourseDropdown";
            this.StudentCourseDropdown.Size = new System.Drawing.Size(857, 24);
            this.StudentCourseDropdown.TabIndex = 21;
            // 
            // CourseListLabel
            // 
            this.CourseListLabel.AutoSize = true;
            this.CourseListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseListLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CourseListLabel.Location = new System.Drawing.Point(3, 0);
            this.CourseListLabel.Name = "CourseListLabel";
            this.CourseListLabel.Size = new System.Drawing.Size(107, 25);
            this.CourseListLabel.TabIndex = 20;
            this.CourseListLabel.Text = "COURSE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox StudentCourseDropdown;
        private System.Windows.Forms.Label CourseListLabel;
    }
}