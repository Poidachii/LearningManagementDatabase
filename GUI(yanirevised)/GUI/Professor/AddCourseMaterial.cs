using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddCourseMaterial : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private string CourseID;
        public AddCourseMaterial()
        {
            InitializeComponent();
        }

        public void SetCourseID(string id)
        {
            CourseID = id;
        }

        private void AddCourseMaterialButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(MaterialNameTextBox.Text) || string.IsNullOrWhiteSpace(MaterialLinkTextBox.Text))
            {
                MessageBox.Show("Please add a Course Material(Name or Link)", "No Course Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckMaterialLinkExists(MaterialLinkTextBox.Text))
            {
                MessageBox.Show("Material Link exists. Please add a different link.", "Material Link Exists.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            sql_params = new Dictionary<string, object>
            {
                { "@courseid", CourseID},
                { "@materialname", MaterialNameTextBox.Text},
                { "@materiallink", MaterialLinkTextBox.Text}
            };

            SQL_legit.RunCommand("INSERT INTO CourseMaterials " +
                                "VALUES(@courseid, @materialname, @materiallink)");
        }

        private bool CheckMaterialLinkExists(string MaterialLink)
        {
            sql_params = new Dictionary<string, object>
            {
                { "@courseid", CourseID},
                { "@materiallink", MaterialLink}
            };

            DataTable dt = SQL_legit.RunCommand("SELECT MaterialLink " +
                                            "FROM CourseMaterials " +
                                            "WHERE CourseID=@courseid AND MaterialLink=@materiallink", opt_sql_params: sql_params);

            if (dt?.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
