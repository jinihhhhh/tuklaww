using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Curriculum
{
    public partial class galdianofillupform : Form
    {
        public galdianofillupform()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Henifillupform_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox options
            sexcombobox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            civilstatuscombobox.Items.AddRange(new object[] { "Single", "Married", "Divorced", "Widowed" });
            suffixcombobox.Items.AddRange(new object[] { "", "Jr.", "Sr.", "II", "III", "IV" });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event for imagebox if needed
        }

        private void uploadimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagebox.Image = Image.FromFile(openFileDialog.FileName);
                    imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void generatedbutton_Click(object sender, EventArgs e)
        {
            // Validate image upload
            if (imagebox.Image == null)
            {
                MessageBox.Show("Please upload an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for personal information fields
            if (string.IsNullOrWhiteSpace(lastnametextbox.Text))
            {
                MessageBox.Show("Please fill in the Last Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(firstnametextbox.Text))
            {
                MessageBox.Show("Please fill in the First Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in the Middle Initial field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(agetextbox.Text))
            {
                MessageBox.Show("Please fill in the Age field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(addresstextbox.Text))
            {
                MessageBox.Show("Please fill in the Address field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(nationalitytextbox.Text))
            {
                MessageBox.Show("Please fill in the Nationality field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(contacttextbox.Text))
            {
                MessageBox.Show("Please fill in the Contact Number field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(emailtextbox.Text))
            {
                MessageBox.Show("Please fill in the Email Address field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sexcombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Sex from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (civilstatuscombobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Civil Status from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Birthplacetextbox.Text))
            {
                MessageBox.Show("Please fill in the Birthplace field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for educational attainment fields
            if (string.IsNullOrWhiteSpace(collegeschoolnametextbox.Text))
            {
                MessageBox.Show("Please fill in the College School Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(collegecoursetextbox.Text))
            {
                MessageBox.Show("Please fill in the College Course field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(seniorhighschoolyeartextbox.Text))
            {
                MessageBox.Show("Please fill in the Senior High School Year field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBseniorhighschoolnametextboxox6.Text))
            {
                MessageBox.Show("Please fill in the Senior High School Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(seniorhighstrandtextbox.Text))
            {
                MessageBox.Show("Please fill in the Senior High Strand field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(juniorhighschoolyeartextbox.Text))
            {
                MessageBox.Show("Please fill in the Junior High School Year field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(juniorhighschoolnametextbox.Text))
            {
                MessageBox.Show("Please fill in the Junior High School Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(elementaryschoolyeartextbox.Text))
            {
                MessageBox.Show("Please fill in the Elementary School Year field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(elementaryschoolnametextbox.Text))
            {
                MessageBox.Show("Please fill in the Elementary School Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for career objective and skills
            if (string.IsNullOrWhiteSpace(carreerobjectiverichtextbox.Text))
            {
                MessageBox.Show("Please fill in the Career Objective field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(skill1textbox.Text))
            {
                MessageBox.Show("Please fill in the Skill 1 field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(skill2textbox.Text))
            {
                MessageBox.Show("Please fill in the Skill 2 field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(skill3textbox.Text))
            {
                MessageBox.Show("Please fill in the Skill 3 field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(skill4textbox.Text))
            {
                MessageBox.Show("Please fill in the Skill 4 field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for character references
            if (string.IsNullOrWhiteSpace(person1nametextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person1relationshiptextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Relationship field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person1emailtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Email field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person1occupationlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person1contactlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Contact Number field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2nametextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2relationshiptextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Relationship field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2emailtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Email field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2occupationlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2contactlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Contact Number field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3nametextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Name field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3relationshiptextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Relationship field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3emailtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Email field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3occupationlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3contactlabel.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Contact Number field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Age (exactly 2 digits)
            if (!Regex.IsMatch(agetextbox.Text, @"^\d{2}$"))
            {
                MessageBox.Show("Age must be exactly two digits (e.g., 25).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Contact Number (exactly 11 digits)
            if (!Regex.IsMatch(contacttextbox.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Contact Number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Character Reference Contact Numbers (exactly 11 digits)
            if (!Regex.IsMatch(person1contactlabel.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Person 1 Contact Number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person2contactlabel.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Person 2 Contact Number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person3contactlabel.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Person 3 Contact Number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Middle Initial (1 or 2 letters)
            if (!Regex.IsMatch(textBox2.Text, @"^[A-Za-z]{1,2}$"))
            {
                MessageBox.Show("Middle Initial must be one or two letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate School Year format (YYYY-YYYY)
            string schoolYearPattern = @"^\d{4}-\d{4}$";
            if (!Regex.IsMatch(seniorhighschoolyeartextbox.Text, schoolYearPattern))
            {
                MessageBox.Show("Senior High School Year must be in YYYY-YYYY format (e.g., 2016-2018).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(juniorhighschoolyeartextbox.Text, schoolYearPattern))
            {
                MessageBox.Show("Junior High School Year must be in YYYY-YYYY format (e.g., 2012-2016).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(elementaryschoolyeartextbox.Text, schoolYearPattern))
            {
                MessageBox.Show("Elementary School Year must be in YYYY-YYYY format (e.g., 2006-2012).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Format the name as "Lastname, Firstname Suffix MI."
            string fullName = $"{lastnametextbox.Text}, {firstnametextbox.Text}";
            if (!string.IsNullOrWhiteSpace(suffixcombobox.Text))
                fullName += $" {suffixcombobox.Text}";
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                fullName += $" {textBox2.Text}.";

            // Create instance of henigeneratedform and pass all values
            galdianogeneratedform generatedForm = new galdianogeneratedform(
                imagebox.Image,
                fullName,
                agetextbox.Text,
                sexcombobox.SelectedItem.ToString(),
                birthdatepicker.Value.ToString("MM/dd/yyyy"),
                Birthplacetextbox.Text, // Pass Birthplace
                addresstextbox.Text,
                nationalitytextbox.Text,
                civilstatuscombobox.SelectedItem.ToString(),
                contacttextbox.Text,
                emailtextbox.Text,
                collegeschoolyeartextbox.Text,
                collegeschoolnametextbox.Text,
                collegecoursetextbox.Text,
                seniorhighschoolyeartextbox.Text,
                textBseniorhighschoolnametextboxox6.Text,
                seniorhighstrandtextbox.Text,
                juniorhighschoolyeartextbox.Text,
                juniorhighschoolnametextbox.Text,
                elementaryschoolyeartextbox.Text,
                elementaryschoolnametextbox.Text,
                carreerobjectiverichtextbox.Text,
                skill1textbox.Text,
                skill2textbox.Text,
                skill3textbox.Text,
                skill4textbox.Text,
                person1nametextbox.Text,
                person1relationshiptextbox.Text,
                person1emailtextbox.Text,
                person1occupationlabel.Text,
                person1contactlabel.Text,
                person2nametextbox.Text,
                person2relationshiptextbox.Text,
                person2emailtextbox.Text,
                person2occupationlabel.Text,
                person2contactlabel.Text,
                person3nametextbox.Text,
                person3relationshiptextbox.Text,
                person3emailtextbox.Text,
                person3occupationlabel.Text,
                person3contactlabel.Text
            );
            generatedForm.ShowDialog();
        }

private void henifillupform_Load(object sender, EventArgs e)
        {
            
            // Initialize ComboBox options
            sexcombobox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            civilstatuscombobox.Items.AddRange(new object[] { "Single", "Married", "Divorced", "Widowed" });
            suffixcombobox.Items.AddRange(new object[] { "", "Jr.", "Sr.", "II", "III", "IV" });
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CV form1 = new CV();
            form1.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void seniorhighstrandtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBseniorhighschoolnametextboxox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void seniorhighschoolyeartextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}