using System;
using System.Drawing;
using System.Windows.Forms;

namespace Curriculum
{
    public partial class LamsenForm2 : Form
    {
        private Image userPhoto;

        public LamsenForm2()
        {
            InitializeComponent();
        }

        public void DisplayCV(string personalInfo, string careerObjective, string education, string workExperience, string skills, string references)
        {
            rtbPersonalInfo.Text = personalInfo;
            rtbCareerObjective.Text = careerObjective;
            rtbEducation.Text = education;
            rtbWorkExperience.Text = workExperience;
            rtbSkills.Text = skills;
            rtbReferences.Text = references;
        }

        public void SetUserPhoto(Image photo)
        {
            userPhoto = photo;
            if (pictureBoxPhoto != null && userPhoto != null)
            {
                pictureBoxPhoto.Image = userPhoto;
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                MakePictureBoxCircular(pictureBoxPhoto);
            }
        }

        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality would be implemented here.", "Print");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save functionality would be implemented here.", "Save");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LamsenForm1 form1 = new LamsenForm1();
            form1.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}