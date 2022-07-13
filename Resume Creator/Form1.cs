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
using Newtonsoft.Json;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

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
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleInitial { get; set; }

            public string Profession { get; set; }
            public string ObjectiveTitle { get; set; }
            public string Objective { get; set; }
            public string SkillsTitle { get; set; }
            public string Skills { get; set; }
            public string WorkExperienceTitle { get; set; }
            public string WorkExperience { get; set; }
            public string EducationalBackground { get; set; }
            public string PrimaryEducationTitle { get; set; }
            public string PrimaryEducation { get; set; }
            public string PrimaryEducationYear { get; set; }
            public string SecondaryEducationTitle { get; set; }
            public string SecondaryEducation { get; set; }
            public string SecondaryEducationYear { get; set; }
            public string TertiaryEducationTitle { get; set; }
            public string TertiaryEducation { get; set; }
            public string TertiaryCourse { get; set; }
            public string TertiaryEducationYear { get; set; }
            public string AwardsTitle { get; set; }
            public string Awards { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string CharacterReferenceTitle { get; set; }
            public string CharacterReference { get; set; }
            public string Contact { get; set; }

        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (selectFile.ShowDialog()== DialogResult.OK)
            {
                txtbxSelect.Text = Path.GetFullPath(selectFile.FileName);
            }
            else
            {
                MessageBox.Show("Please Select a JSON File you want to Convert");
            }
        }


        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string jsonFromFile;
            using (var reader = new StreamReader(txtbxSelect.Text))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            var infoFromJSON = JsonConvert.DeserializeObject<Resume>(jsonFromFile);

            string LastName = infoFromJSON.LastName;
            string FirstName = infoFromJSON.FirstName;
            string Middleinitial = infoFromJSON.MiddleInitial;
            string Profession = infoFromJSON.Profession;

            string ObjectiveTitle = infoFromJSON.ObjectiveTitle;
            string Objective = infoFromJSON.Objective;

            string SkillsTitle = infoFromJSON.SkillsTitle;
            string Skills = infoFromJSON.Skills;

            string WorkExperienceTitle = infoFromJSON.WorkExperienceTitle;
            string WorkExperience = infoFromJSON.WorkExperience;

            string EducationalBackground = infoFromJSON.EducationalBackground;
            string PrimaryEducationTitle = infoFromJSON.PrimaryEducationTitle;
            string PrimaryEducation = infoFromJSON.PrimaryEducation;
            string PrimaryEducationYear = infoFromJSON.PrimaryEducationYear;
            string SecondaryEducation = infoFromJSON.SecondaryEducation;
            string SecondaryEducationTitle = infoFromJSON.SecondaryEducationTitle;
            string SecondaryEducationYear = infoFromJSON.SecondaryEducationYear;
            string TertiaryEducationTitle = infoFromJSON.TertiaryEducationTitle;
            string TertiaryEducation = infoFromJSON.TertiaryEducation;
            string TertiaryCourse = infoFromJSON.TertiaryCourse;
            string TertiaryEducationYear = infoFromJSON.TertiaryEducationYear;

            string AwardsTitle = infoFromJSON.AwardsTitle;
            string Awards = infoFromJSON.Awards;

            string Address = infoFromJSON.Address;
            string Email = infoFromJSON.Email;
            string ContactNumber = infoFromJSON.ContactNumber;

            string CharacterReferenceTitle = infoFromJSON.CharacterReferenceTitle;
            string CharacterReference = infoFromJSON.CharacterReference;
            string Contact = infoFromJSON.Contact;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = txtbxSelect.Text;
                sfd.FileName = LastName + "_" + FirstName + ".pdf";
                sfd.Filter = "PDF|*.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = LastName + "_" + FirstName + "_" + "Resume";
                    PdfPage page = pdf.AddPage();
                    
                    // The page
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Font
                    XFont basefont = new XFont("Tahoma", 11);
                    XFont titlefont = new XFont("Tahoma", 22, XFontStyle.Bold);
                    XFont subtitlefont = new XFont("Tahoma", 14, XFontStyle.Bold);

                    // draw the text
                    gfx.DrawString(FirstName.ToString() + " " + Middleinitial.ToString() + " " + LastName.ToString(), titlefont, XBrushes.Blue,
                        new XRect(0, 20, page.Width, page.Height.Point - 50), XStringFormats.TopCenter);

                    gfx.DrawString(Profession.ToString(), subtitlefont, XBrushes.DarkBlue,
                        new XRect(0, 50, page.Width, page.Height.Point - 200), XStringFormats.TopCenter);

                    gfx.DrawString(ObjectiveTitle.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 100, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Objective.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 120, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(SkillsTitle.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 150, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Skills.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 170, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(WorkExperienceTitle.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 200, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(WorkExperience.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 220, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(EducationalBackground.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 250, page.Width, page.Height - 300), XStringFormats.TopLeft);
                    
                    gfx.DrawString(PrimaryEducationTitle.ToString(), subtitlefont, XBrushes.DarkBlue,
                        new XRect(20, 270, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(PrimaryEducation.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 290, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(PrimaryEducationYear.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 310, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(SecondaryEducationTitle.ToString(), subtitlefont, XBrushes.DarkBlue,
                        new XRect(20, 330, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(SecondaryEducation.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 350, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(SecondaryEducationYear.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 370, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(TertiaryEducationTitle.ToString(), subtitlefont, XBrushes.DarkBlue,
                        new XRect(20, 390, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(TertiaryEducation.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 410, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(TertiaryCourse.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 430, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(TertiaryEducationYear.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 450, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(AwardsTitle.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 480, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Awards.ToString(), basefont, XBrushes.Black,
                        new XRect(20, 500, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(CharacterReferenceTitle.ToString(), subtitlefont, XBrushes.Blue,
                        new XRect(20, 530, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(CharacterReference.ToString(), basefont, XBrushes.Black,
                       new XRect(20, 550, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Contact.ToString(), basefont, XBrushes.Black,
                       new XRect(20, 570, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Address.ToString(), subtitlefont, XBrushes.Black,
                       new XRect(20, 600, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(Email.ToString(), subtitlefont, XBrushes.Black,
                        new XRect(20, 615, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    gfx.DrawString(ContactNumber.ToString(), subtitlefont, XBrushes.Black,
                        new XRect(20, 630, page.Width, page.Height - 300), XStringFormats.TopLeft);

                    XPen pen = new XPen(XColors.DarkGoldenrod, 10);

                    gfx.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    //save document
                    pdf.Save(sfd.FileName);
                }
            }

                
            
        }
    }
}
