using System;
using System.Drawing;
using System.Windows.Forms;

namespace Curriculum
{
    public partial class galdianogeneratedform : Form
    {
        public galdianogeneratedform(
            Image image = null, string name = "", string age = "", string sex = "",
            string birthdate = "", string birthplace = "", string address = "", string nationality = "",
            string civilStatus = "", string contact = "", string email = "",
            string collegeSchoolYear = "", string collegeSchoolName = "", string collegeCourse = "",
            string seniorHighSchoolYear = "", string seniorHighSchoolName = "", string seniorHighStrand = "",
            string juniorHighSchoolYear = "", string juniorHighSchoolName = "",
            string elementarySchoolYear = "", string elementarySchoolName = "",
            string careerObjective = "", string skill1 = "", string skill2 = "", string skill3 = "", string skill4 = "",
            string person1Name = "", string person1Relationship = "", string person1Email = "", string person1Occupation = "", string person1Contact = "",
            string person2Name = "", string person2Relationship = "", string person2Email = "", string person2Occupation = "", string person2Contact = "",
            string person3Name = "", string person3Relationship = "", string person3Email = "", string person3Occupation = "", string person3Contact = "")
        {
            InitializeComponent();
            if (image != null)
            {
                imagebox.Image = image;
                imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            namelabel.Text = name;
            agelabel.Text = $"Age: {age}";
            sexlabel.Text = $"Sex: {sex}";
            birthdatelabel.Text = $"Birthdate: {birthdate}";
            birthplacelabel.Text = $"Birthplace: {birthplace}";
            addresslabel.Text = $"Address: {address}";
            nationalitylabel.Text = $"Nationality: {nationality}";
            civilstatuslabel.Text = $"Civil Status: {civilStatus}";
            contactlabel.Text = $"Contact No.: {contact}";
            emaillabel.Text = $"Email: {email}";
            collegeschoolyearlabel.Text = $"School Year: {collegeSchoolYear}";
            collegeschoolnamelabel.Text = $"School Name: {collegeSchoolName}";
            collegecourselabel.Text = $"Course: {collegeCourse}";
            seniorhighschoolyearlabel.Text = $"School Year: {seniorHighSchoolYear}";
            seniorhighschoolnamelabel.Text = $"School Name: {seniorHighSchoolName}";
            seniorhighstrandlabel.Text = $"Strand: {seniorHighStrand}";
            juniorhighschoolyearlabel.Text = $"School Year: {juniorHighSchoolYear}";
            juniorhighschoolnamelabel.Text = $"School Name: {juniorHighSchoolName}";
            elementaryschoolyearlabel.Text = $"School Year: {elementarySchoolYear}";
            elementaryschoolnamelabel.Text = $"School Name: {elementarySchoolName}";
            carreerrichtextbox.Text = careerObjective;
            skill1label.Text = skill1;
            skill2label.Text = skill2;
            skill3label.Text = skill3;
            skill4label.Text = skill4;
            person1namelabel.Text = person1Name;
            person1relationshiplabel.Text = person1Relationship;
            person1emaillabel.Text = person1Email;
            person1occupationlabel.Text = person1Occupation;
            person1contactlabel.Text = person1Contact;
            person2namelabel.Text = person2Name;
            person2relationshiplabel.Text = person2Relationship;
            person2emaillabel.Text = person2Email;
            person2occupationlabel.Text = person2Occupation;
            person2contactlabel.Text = person2Contact;
            person3namelabel.Text = person3Name;
            person3relationshiplabel.Text = person3Relationship;
            person3emaillabel.Text = person3Email;
            person3occupationlabel.Text = person3Occupation;
            person3contactlabel.Text = person3Contact;
        }

        private void imagebox_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event for imagebox if needed
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            // Create a new instance of henifillupform and show it
            galdianofillupform fillupForm = new galdianofillupform();
            fillupForm.Show();
            // Close the current henigeneratedform
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            galdianofillupform form1 = new galdianofillupform();
            form1.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void henigeneratedform_Load(object sender, EventArgs e)
        {
            AutoScrollMinSize = new Size(0, 500);
            AutoScroll = true;
        }
    }
}