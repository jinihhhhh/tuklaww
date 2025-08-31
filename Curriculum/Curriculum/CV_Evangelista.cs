using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum
{
    public partial class CV_Evangelista : Form
    {
        internal string name;
        internal string objectives;
        PictureBox pictureBox;
        internal string date;
        internal string address;
        internal string ages;
        internal string sexes;
        internal string email;
        internal string civil;
        internal string placebirth;
        internal string religion;
        internal string phone;
        internal string national;
        internal string univ;
        internal string univyear;
        internal string univaddress;
        internal string seniorname;
        internal string senioraddress;
        internal string senioryear;
        internal string highname;
        internal string highaddress;
        internal string highyear;
        internal string primaryname;
        internal string primaryaddress;
        internal string primaryyear;
        internal string skill1;
        internal string skill2;
        internal string skill3;
        internal string skill4;
        internal string personname1;
        internal string relationship1;
        internal string contact1;
        internal string personname2;
        internal string relationship2;
        internal string contact2;
        internal string personname3;
        internal string relationship3;
        internal string contact3;

        public CV_Evangelista()
        {
            InitializeComponent();
            pictureBox1 = new PictureBox();
        }

        public CV_Evangelista(string name, string objectives, Image image, string date, string address, string ages, string sexes,
            string email, string civil, string placebirth, string religion, string phone, string national, string univ, string univyear,
            string univaddress, string seniorname, string senioraddress, string senioryear, string highname, string highaddress, string highyear,
            string primaryname, string primaryaddress, string primaryyear, string skill1, string skill2, string skill3, string skill4,
            string personname1, string relationship1, string contact1, string personname2, string relationship2, string contact2,
            string personname3, string relationship3, string contact3)
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            pictureBox1.Region = new Region(path);

            pictureBox1.Paint += new PaintEventHandler(PictureBox1_Paint);

            lblname.Text = name;
            lblobjectives.Text = objectives;
            pictureBox1.Image = image;
            lblbirth.Text = date;
            lbladdress.Text = address;
            lblages.Text = ages;
            lblsexs.Text = sexes;
            lblemail.Text = email;
            lblcvs.Text = civil;
            lblplace.Text = placebirth;
            lblrel.Text = religion;
            lblcontactno.Text = phone;
            lblnation.Text = national;

            // Only set tertiary education fields if they are not empty
            if (!string.IsNullOrWhiteSpace(univ)) lbluniv.Text = univ;
            else lbluniv.Text = "";
            if (!string.IsNullOrWhiteSpace(univyear)) lblcollegeyear.Text = univyear;
            else lblcollegeyear.Text = "";
            if (!string.IsNullOrWhiteSpace(univaddress)) lblcollegeadress.Text = univaddress;
            else lblcollegeadress.Text = "";

            // Only set senior high school fields if they are not empty
            if (!string.IsNullOrWhiteSpace(seniorname)) lblseniorname.Text = seniorname;
            else lblseniorname.Text = "";
            if (!string.IsNullOrWhiteSpace(senioraddress)) lblsenioraddress.Text = senioraddress;
            else lblsenioraddress.Text = "";
            if (!string.IsNullOrWhiteSpace(senioryear)) lblsenioryear.Text = senioryear;
            else lblsenioryear.Text = "";

            // Only set high school fields if they are not empty
            if (!string.IsNullOrWhiteSpace(highname)) lblhighname.Text = highname;
            else lblhighname.Text = "";
            if (!string.IsNullOrWhiteSpace(highaddress)) lblhighaddress.Text = highaddress;
            else lblhighaddress.Text = "";
            if (!string.IsNullOrWhiteSpace(highyear)) lblhighyear.Text = highyear;
            else lblhighyear.Text = "";

            // Only set primary school fields if they are not empty
            if (!string.IsNullOrWhiteSpace(primaryname)) lblelemname.Text = primaryname;
            else lblelemname.Text = "";
            if (!string.IsNullOrWhiteSpace(primaryaddress)) lblelemaddress.Text = primaryaddress;
            else lblelemaddress.Text = "";
            if (!string.IsNullOrWhiteSpace(primaryyear)) lblelemyear.Text = primaryyear;
            else lblelemyear.Text = "";

            // Only set skills if they are not empty
            if (!string.IsNullOrWhiteSpace(skill1)) lblskil1.Text = skill1;
            else lblskil1.Text = "";
            if (!string.IsNullOrWhiteSpace(skill2)) lblskill2.Text = skill2;
            else lblskill2.Text = "";
            if (!string.IsNullOrWhiteSpace(skill3)) lblskill3.Text = skill3;
            else lblskill3.Text = "";
            if (!string.IsNullOrWhiteSpace(skill4)) lblskill4.Text = skill4;
            else lblskill4.Text = "";

            // Only set reference fields if they are not empty
            if (!string.IsNullOrWhiteSpace(personname1)) lblpersonname1.Text = personname1;
            else lblpersonname1.Text = "";
            if (!string.IsNullOrWhiteSpace(relationship1)) lblrelationship1.Text = relationship1;
            else lblrelationship1.Text = "";
            if (!string.IsNullOrWhiteSpace(contact1)) lblcontact1.Text = contact1;
            else lblcontact1.Text = "";

            if (!string.IsNullOrWhiteSpace(personname2)) lblpersoname2.Text = personname2;
            else lblpersoname2.Text = "";
            if (!string.IsNullOrWhiteSpace(relationship2)) lblrelationship2.Text = relationship2;
            else lblrelationship2.Text = "";
            if (!string.IsNullOrWhiteSpace(contact2)) lblcontact2.Text = contact2;
            else lblcontact2.Text = "";

            if (!string.IsNullOrWhiteSpace(personname3)) lblpersonname3.Text = personname3;
            else lblpersonname3.Text = "";
            if (!string.IsNullOrWhiteSpace(relationship3)) lblrelationship3.Text = relationship3;
            else lblrelationship3.Text = "";
            if (!string.IsNullOrWhiteSpace(contact3)) lblcontact3.Text = contact3;
            else lblcontact3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 450);

            Panel contentPanel = new Panel
            {
                Location = new Point(10, pictureBox1.Bottom + 10),
                Size = new Size(this.ClientSize.Width - 30, 700),
            };
            this.Controls.Add(contentPanel);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 3))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(pen, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            }
        }

        private void lblobjectives_Click(object sender, EventArgs e)
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Fillup_Evangelista marc = new Fillup_Evangelista();
            marc.Show();
            this.Hide();
        }

        private void lblpersonname3_Click(object sender, EventArgs e)
        {
        }
    }
}