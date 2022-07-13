using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Resume_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Resume
        {
            public string Name { get; set; }
            public string Profession { get; set; }
            public string Objective { get; set; }
            public string Skills { get; set; }
            public string WorkExperience { get; set; }
            public string EducationalBackground { get; set; }
            public string PrimaryEducation { get; set; }
            public string PrimaryEducationYear { get; set; }
            public string SecondaryEducation { get; set; }
            public string SecondaryEducationYear { get; set; }
            public string TertiaryEducation { get; set; }
            public string TertiaryCourse { get; set; }
            public string TertiaryEducationYear { get; set; }
            public string Awards { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string CharacterReference { get; set; }
            public string Contact { get; set; }

        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (selectFile.ShowDialog()== DialogResult.OK)
            {
                txtbxSelect.Text = Path.GetFileName(selectFile.FileName);
            }
            else
            {
                MessageBox.Show("Please Select a JSON File you want to Convert");
            }
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            saveFilePath.ShowDialog();
            txtbxFilePath.Text = saveFilePath.SelectedPath.ToString();
        }
    }
}
