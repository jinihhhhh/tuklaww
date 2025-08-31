using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Curriculum
{
    public partial class henifillupform : Form
    {
        public henifillupform()
        {
            InitializeComponent();
        }

        private void Henifillupform_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1000);
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
            if (string.IsNullOrWhiteSpace(seniorhighschoolnametextbox.Text))
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
            if (string.IsNullOrWhiteSpace(person1occupationtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 1 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person1contacttextbox.Text))
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
            if (string.IsNullOrWhiteSpace(person2occupationtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 2 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person2contacttextbox.Text))
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
            if (string.IsNullOrWhiteSpace(person3occupationtextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Occupation field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(person3contacttextbox.Text))
            {
                MessageBox.Show("Please fill in the Person 3 Contact Number field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enhanced Email Validation - Must be @gmail.com or @yahoo.com (or any yahoo domain)
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.(com|co\.uk|ca|com\.au|fr|de|it|es|com\.br|com\.mx|co\.jp|co\.in|com\.sg|com\.my|com\.ph))$";
            if (!Regex.IsMatch(emailtextbox.Text.ToLower(), emailPattern))
            {
                MessageBox.Show("Email must be a valid Gmail (@gmail.com) or Yahoo email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enhanced Contact Number Validation - Must start with 09 and have 11 digits total
            if (!Regex.IsMatch(contacttextbox.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Contact Number must start with '09' and be exactly 11 digits (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enhanced Character Reference Email Validation
            if (!Regex.IsMatch(person1emailtextbox.Text.ToLower(), emailPattern))
            {
                MessageBox.Show("Person 1 Email must be a valid Gmail (@gmail.com) or Yahoo email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person2emailtextbox.Text.ToLower(), emailPattern))
            {
                MessageBox.Show("Person 2 Email must be a valid Gmail (@gmail.com) or Yahoo email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person3emailtextbox.Text.ToLower(), emailPattern))
            {
                MessageBox.Show("Person 3 Email must be a valid Gmail (@gmail.com) or Yahoo email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Enhanced Character Reference Contact Number Validation - Must start with 09 and have 11 digits total
            if (!Regex.IsMatch(person1contacttextbox.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Person 1 Contact Number must start with '09' and be exactly 11 digits (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person2contacttextbox.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Person 2 Contact Number must start with '09' and be exactly 11 digits (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(person3contacttextbox.Text, @"^09\d{9}$"))
            {
                MessageBox.Show("Person 3 Contact Number must start with '09' and be exactly 11 digits (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (suffixcombobox.SelectedItem != null && !string.IsNullOrWhiteSpace(suffixcombobox.SelectedItem.ToString()))
                fullName += $" {suffixcombobox.SelectedItem}";
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                fullName += $" {textBox2.Text}.";

            // Create instance of henigeneratedform and pass all values
            henigeneratedform generatedForm = new henigeneratedform(
                imagebox.Image,
                fullName,
                CalculateAge(birthdatepicker.Value).ToString(),
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
                seniorhighschoolnametextbox.Text,
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
                person1occupationtextbox.Text,
                person1contacttextbox.Text,
                person2nametextbox.Text,
                person2relationshiptextbox.Text,
                person2emailtextbox.Text,
                person2occupationtextbox.Text,
                person2contacttextbox.Text,
                person3nametextbox.Text,
                person3relationshiptextbox.Text,
                person3emailtextbox.Text,
                person3occupationtextbox.Text,
                person3contacttextbox.Text
            );

            generatedForm.Show();
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void birthdatepicker_ValueChanged(object sender, EventArgs e)
        {
            // Auto-calculate age when birthdate changes
            int age = CalculateAge(birthdatepicker.Value);
            agetextbox.Text = age.ToString();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CV form1 = new CV();
            form1.Show();
            this.Hide();
        }
    }
}

