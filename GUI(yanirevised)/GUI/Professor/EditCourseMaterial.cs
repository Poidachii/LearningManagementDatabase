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
    public partial class EditCourseMaterial : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private string MaterialID;
        public EditCourseMaterial()
        {
            InitializeComponent();
        }

        public void SetMaterialID(string id)
        {
            MaterialID = id;
        }

        private void EditCourseMaterial_Load(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
            {
                { "@materialid", MaterialID}
            };

            DataTable dt = SQL_legit.RunCommand("SELECT MaterialName, MaterialLink " +
                                            "FROM CourseMaterials " +
                                            "WHERE MaterialID=@materialid", opt_sql_params: sql_params);

            string MaterialName = dt.Rows[0]["MaterialName"].ToString();
            string MaterialLink = dt.Rows[0]["MaterialLink"].ToString();

            MaterialNameTextBox.Text = MaterialName;
            MaterialLinkTextBox.Text = MaterialLink;
        }

        private void CoursePopupUpdateCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void CoursePopupAddCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void CoursePopupAddPicture1_Click(object sender, EventArgs e)
        {

        }
    }
}
