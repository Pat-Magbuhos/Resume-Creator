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
    }
}
