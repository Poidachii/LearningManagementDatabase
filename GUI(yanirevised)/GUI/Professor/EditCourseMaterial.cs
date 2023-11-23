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

        private void EditCourseMaterialButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaterialNameTextBox.Text) || string.IsNullOrWhiteSpace(MaterialLinkTextBox.Text))
            {
                MessageBox.Show("Please add a Course Material(Name or Link)", "No Course Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql_params = new Dictionary<string, object>
            {
                { "@materialid", MaterialID},
                { "@materialname", MaterialNameTextBox.Text},
                { "@materiallink", MaterialLinkTextBox.Text}
            };

            SQL_legit.RunCommand("UPDATE CourseMaterials " +
                                "SET MaterialName=@materialname, MaterialLink=@materiallink " +
                                "WHERE MaterialID=@materialid", opt_sql_params: sql_params);

            MessageBox.Show("Successfully changed the Course Materials.", "Course Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
