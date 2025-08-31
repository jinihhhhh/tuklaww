using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum
{
    public partial class LamsenForm1 : Form
    {
        // Keep track of added work experience entries
        private int workExperienceEntryCount = 0;
        private int skillEntryCount = 0;
        private int certificationEntryCount = 0;

        public LamsenForm1()
        {
            InitializeComponent();
            // Attach event handlers for buttons, textboxes, and checkboxes
            this.UploadPhoto.Click += new System.EventHandler(this.button1_Click);
            this.AddWorkBtn.Click += new System.EventHandler(this.AddWorkBtn_Click);
            this.AddEducBtn.Click += new System.EventHandler(this.AddEducBtn_Click);
            this.AddSkillBtn.Click += new System.EventHandler(this.AddSkillBtn_Click);
            this.AddRefBtn.Click += new System.EventHandler(this.AddRefBtn_Click);
            this.Declaration.CheckedChanged += new System.EventHandler(this.Declaration_CheckedChanged);
            this.button2.Click += new System.EventHandler(this.AddCertificationBtn_Click); // Assuming button2 is for Certifications
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click); // Generate CV button

            // Initialize panels for dynamic content
            WorkExperience.AutoScroll = true;
            Skills.AutoScroll = true;
            panel17.AutoScroll = true; // Assuming panel17 is the Certifications panel

            // Set initial placeholder text and attach focus/leave events
            SetPlaceholder(FirstName, "First Name");
            SetPlaceholder(MiddleInitial, "M.I.");
            SetPlaceholder(LastName, "Last Name");
            SetPlaceholder(Suffix, "Suffix");
            SetPlaceholder(Age, "Age");
            SetPlaceholder(BirthPlace, "Birth Place");
            SetPlaceholder(Weight, "Weight");
            SetPlaceholder(Height, "Height");
            SetPlaceholder(Email, "Email");
            SetPlaceholder(ContactNumber, "Contact Number");
            SetPlaceholder(JobTitle, "Job Title");
            SetPlaceholder(textBox3, "Employer"); // Assuming textBox3 is Employer
            SetPlaceholder(Description, "Description");
            SetPlaceholder(School, "Primary School");
            SetPlaceholder(PrimCity, "City");
            SetPlaceholder(PrimAttainment, "Attainment");
            SetPlaceholder(JunSchool, "Junior High School");
            SetPlaceholder(JunCity, "City");
            SetPlaceholder(JunAttainment, "Attainment");
            SetPlaceholder(SenSchool, "Senior High School");
            SetPlaceholder(SenCity, "City");
            SetPlaceholder(SenAttainment, "Attainment");
            SetPlaceholder(University, "University");
            SetPlaceholder(SecAttainment, "Attainment");
            SetPlaceholder(SecCity, "City");
            SetPlaceholder(AddSkilltxt, "Add Skill");
            SetPlaceholder(RefName, "Reference Name");
            SetPlaceholder(RefContact, "Contact");
            SetPlaceholder(RefWork, "Work/Position");
            SetPlaceholder(RefEmail, "Email");
            SetPlaceholder(textBox2, "Add Certification");
        }

        private void LamsenForm1_Load(object sender, EventArgs e)
        {
            // Initialize ComboBoxes with some sample data
            MaritalStatus.Items.AddRange(new string[] { "Single", "Married", "Divorced", "Widowed" });
            Sex.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        // Helper method for placeholder behavior
        private void SetPlaceholder(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = SystemColors.GrayText;
                textBox.GotFocus += (s, e) => { if (textBox.Text == placeholderText) { textBox.Text = ""; textBox.ForeColor = SystemColors.WindowText; } };
                textBox.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(textBox.Text)) { textBox.Text = placeholderText; textBox.ForeColor = SystemColors.GrayText; } };
            }
            else if (control is RichTextBox richTextBox)
            {
                richTextBox.Text = placeholderText;
                richTextBox.ForeColor = SystemColors.GrayText;
                richTextBox.GotFocus += (s, e) => { if (richTextBox.Text == placeholderText) { richTextBox.Text = ""; richTextBox.ForeColor = SystemColors.WindowText; } };
                richTextBox.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(richTextBox.Text)) { richTextBox.Text = placeholderText; richTextBox.ForeColor = SystemColors.GrayText; } };
            }
        }

        // Event handler for button1 (Upload Picture)
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image to fit

                    // Make the picture circular
                    MakePictureBoxCircular(pictureBox1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to make PictureBox circular
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            Region rg = new Region(gp);
            pictureBox.Region = rg;
        }

        // Event handler for AddWorkBtn - Dynamic Work Experience
        private void AddWorkBtn_Click(object sender, EventArgs e)
        {
            int newControlHeight = 120; // Height for a complete work experience entry
            int currentBottom = GetBottomOfLastControl(WorkExperience);

            // Create a new set of controls for work experience
            Label jobTitleLabel = new Label();
            jobTitleLabel.Text = "Job Title:";
            jobTitleLabel.Location = new Point(10, currentBottom + 10);
            jobTitleLabel.AutoSize = true;
            WorkExperience.Controls.Add(jobTitleLabel);

            TextBox newJobTitle = new TextBox();
            newJobTitle.Name = "newJobTitle" + workExperienceEntryCount;
            newJobTitle.Width = 200;
            newJobTitle.Location = new Point(100, currentBottom + 10);
            SetPlaceholder(newJobTitle, "Job Title");
            WorkExperience.Controls.Add(newJobTitle);

            Label employerLabel = new Label();
            employerLabel.Text = "Employer:";
            employerLabel.Location = new Point(10, currentBottom + 40);
            employerLabel.AutoSize = true;
            WorkExperience.Controls.Add(employerLabel);

            TextBox newEmployer = new TextBox();
            newEmployer.Name = "newEmployer" + workExperienceEntryCount;
            newEmployer.Width = 200;
            newEmployer.Location = new Point(100, currentBottom + 40);
            SetPlaceholder(newEmployer, "Employer");
            WorkExperience.Controls.Add(newEmployer);

            Label startDateLabel = new Label();
            startDateLabel.Text = "Start Date:";
            startDateLabel.Location = new Point(10, currentBottom + 70);
            startDateLabel.AutoSize = true;
            WorkExperience.Controls.Add(startDateLabel);

            DateTimePicker newStartDate = new DateTimePicker();
            newStartDate.Name = "newStartDate" + workExperienceEntryCount;
            newStartDate.Width = 120;
            newStartDate.Location = new Point(100, currentBottom + 70);
            WorkExperience.Controls.Add(newStartDate);

            Label endDateLabel = new Label();
            endDateLabel.Text = "End Date:";
            endDateLabel.Location = new Point(230, currentBottom + 70);
            endDateLabel.AutoSize = true;
            WorkExperience.Controls.Add(endDateLabel);

            DateTimePicker newEndDate = new DateTimePicker();
            newEndDate.Name = "newEndDate" + workExperienceEntryCount;
            newEndDate.Width = 120;
            newEndDate.Location = new Point(300, currentBottom + 70);
            WorkExperience.Controls.Add(newEndDate);

            workExperienceEntryCount++;

            // Expand the panel to accommodate new controls
            WorkExperience.Height += newControlHeight;

            // Adjust the layout of subsequent panels
            AdjustSubsequentPanels(WorkExperience, newControlHeight);

            MessageBox.Show("Work experience entry added!", "Work Experience");
        }

        // Event handler for AddEducBtn
        private void AddEducBtn_Click(object sender, EventArgs e)
        {
            string educationInfo = "";
            educationInfo += "Primary School: " + School.Text + "\n";
            educationInfo += "Primary City: " + PrimCity.Text + "\n";
            educationInfo += "Primary Attainment: " + PrimAttainment.Text + "\n";
            educationInfo += "Junior High School: " + JunSchool.Text + "\n";
            educationInfo += "Junior High City: " + JunCity.Text + "\n";
            educationInfo += "Junior High Attainment: " + JunAttainment.Text + "\n";
            educationInfo += "Senior High School: " + SenSchool.Text + "\n";
            educationInfo += "Senior High City: " + SenCity.Text + "\n";
            educationInfo += "Senior High Attainment: " + SenAttainment.Text + "\n";
            educationInfo += "University: " + University.Text + "\n";
            educationInfo += "College Attainment: " + SecAttainment.Text + "\n";
            educationInfo += "College City: " + SecCity.Text + "\n";

            MessageBox.Show(educationInfo, "Education Added");
            // Clear fields after adding
            School.Text = "Primary School";
            PrimCity.Text = "City";
            PrimAttainment.Text = "Attainment";
            JunSchool.Text = "Junior High School";
            JunCity.Text = "City";
            JunAttainment.Text = "Attainment";
            SenSchool.Text = "Senior High School";
            SenCity.Text = "City";
            SenAttainment.Text = "Attainment";
            University.Text = "University";
            SecAttainment.Text = "Attainment";
            SecCity.Text = "City";
        }

        // Event handler for AddSkillBtn - Dynamic Skills
        private void AddSkillBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddSkilltxt.Text) && AddSkilltxt.Text != "Add Skill")
            {
                int newControlHeight = 25; // Height of each new skill label

                Label newSkillLabel = new Label();
                newSkillLabel.Text = "• " + AddSkilltxt.Text;
                newSkillLabel.AutoSize = true;
                newSkillLabel.Location = new Point(10, GetBottomOfLastControl(Skills) + 5);
                Skills.Controls.Add(newSkillLabel);

                skillEntryCount++;
                Skills.Height += newControlHeight; // Increase panel height

                // Adjust the layout of subsequent panels
                AdjustSubsequentPanels(Skills, newControlHeight);

                MessageBox.Show("Skill Added: " + AddSkilltxt.Text, "Skill Management");
                AddSkilltxt.Text = "Add Skill"; // Reset placeholder
                AddSkilltxt.ForeColor = SystemColors.GrayText;
            }
            else
            {
                MessageBox.Show("Please enter a skill.", "Input Error");
            }
        }

        // Event handler for AddRefBtn
        private void AddRefBtn_Click(object sender, EventArgs e)
        {
            string referenceInfo = "";
            referenceInfo += "Name: " + RefName.Text + "\n";
            referenceInfo += "Contact: " + RefContact.Text + "\n";
            referenceInfo += "Work: " + RefWork.Text + "\n";
            referenceInfo += "Email: " + RefEmail.Text + "\n";

            MessageBox.Show(referenceInfo, "Character Reference Added");
            // Clear fields after adding
            RefName.Text = "Reference Name";
            RefContact.Text = "Contact";
            RefWork.Text = "Work/Position";
            RefEmail.Text = "Email";
        }

        // Event handler for Declaration CheckBox
        private void Declaration_CheckedChanged(object sender, EventArgs e)
        {
            if (Declaration.Checked)
            {
                DeclarationTxt.Text = "I hereby declare that the information provided is true and correct.";
                MessageBox.Show("Declaration Accepted!", "Declaration Status");
            }
            else
            {
                DeclarationTxt.Text = "";
                MessageBox.Show("Declaration Unchecked.", "Declaration Status");
            }
        }

        // Event handler for AddCertificationBtn (button2) - Dynamic Certifications
        private void AddCertificationBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text != "Add Certification")
            {
                int newControlHeight = 25; // Height of each new certification label

                Label newCertLabel = new Label();
                newCertLabel.Text = "• " + textBox2.Text;
                newCertLabel.AutoSize = true;
                newCertLabel.Location = new Point(10, GetBottomOfLastControl(panel17) + 5);
                panel17.Controls.Add(newCertLabel);

                certificationEntryCount++;
                panel17.Height += newControlHeight; // Increase panel height

                // Adjust the layout of subsequent panels
                AdjustSubsequentPanels(panel17, newControlHeight);

                MessageBox.Show("Certification Added: " + textBox2.Text, "Certification Management");
                textBox2.Text = "Add Certification"; // Reset placeholder
                textBox2.ForeColor = SystemColors.GrayText;
            }
            else
            {
                MessageBox.Show("Please enter a certification.", "Input Error");
            }
        }

        // Helper method to get the bottom position of the last control in a panel
        private int GetBottomOfLastControl(Panel panel)
        {
            int maxBottom = 0;
            foreach (Control control in panel.Controls)
            {
                int controlBottom = control.Location.Y + control.Height;
                if (controlBottom > maxBottom)
                {
                    maxBottom = controlBottom;
                }
            }
            return maxBottom;
        }

        // Method to adjust positions of panels that come after the expanding panel
        private void AdjustSubsequentPanels(Panel expandingPanel, int heightIncrease)
        {
            // Get the Y position of the expanding panel
            int expandingPanelBottom = expandingPanel.Location.Y + expandingPanel.Height;

            // List of main panels in order (you may need to adjust this based on your actual layout)
            Panel[] mainPanels = { CareerObjectives, WorkExperience, Education, Skills, panel17, CharacterReference };

            bool foundExpandingPanel = false;
            foreach (Panel panel in mainPanels)
            {
                if (panel == expandingPanel)
                {
                    foundExpandingPanel = true;
                    continue;
                }

                // Move all panels that come after the expanding panel
                if (foundExpandingPanel)
                {
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + heightIncrease);
                }
            }

            // Adjust the form's AutoScrollMinSize to ensure scrollbars appear if content overflows
            this.AutoScrollMinSize = new Size(this.AutoScrollMinSize.Width, this.AutoScrollMinSize.Height + heightIncrease);
        }

        // Generic TextChanged event handler for TextBoxes
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Example: You can add validation or real-time updates here
                // Console.WriteLine($"TextBox \'{textBox.Name}\' text changed to: {textBox.Text}");
            }
        }

        // Generic SelectedIndexChanged event handler for ComboBoxes
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                // Example: You can perform actions based on selected item
                // Console.WriteLine($"ComboBox \'{comboBox.Name}\' selected item: {comboBox.SelectedItem.ToString()}");
            }
        }

        // ValueChanged event handler for Birthdate DateTimePicker
        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {
            // Example: Calculate age automatically
            DateTime today = DateTime.Today;
            int age = today.Year - Birthdate.Value.Year;
            if (Birthdate.Value.Date > today.AddYears(-age))
            {
                age--;
            }
            Age.Text = age.ToString();
        }

        // Existing methods from the original Form1.cs
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (!ValidateRequiredFields())
            {
                return; // Stop execution if validation fails
            }

            // Collect data from LamsenForm1 fields
            string firstName = GetTextValue(FirstName, "First Name");
            string middleInitial = GetTextValue(MiddleInitial, "M.I.");
            string lastName = GetTextValue(LastName, "Last Name");
            string suffix = GetTextValue(Suffix, "Suffix");
            string fullName = $"{firstName} {middleInitial} {lastName} {suffix}".Trim();

            string age = GetTextValue(Age, "Age");
            string birthdate = Birthdate.Value.ToShortDateString();
            string birthplace = GetTextValue(BirthPlace, "Birth Place");
            string maritalStatus = MaritalStatus.SelectedItem?.ToString() ?? "";
            string sex = Sex.SelectedItem?.ToString() ?? "";
            string weight = GetTextValue(Weight, "Weight");
            string height = GetTextValue(Height, "Height");
            string address = GetTextValue(Address, "Address");
            string email = GetTextValue(Email, "Email");
            string contactNumber = GetTextValue(ContactNumber, "Contact Number");

            string careerObjective = GetTextValue(CareerObj, "Career Objective");

            // Personal Information
            StringBuilder personalInfoBuilder = new StringBuilder();
            personalInfoBuilder.AppendLine($"Name: {fullName}");
            personalInfoBuilder.AppendLine($"Contact: {contactNumber} | {email} | {address}");
            personalInfoBuilder.AppendLine($"Age: {age}");
            personalInfoBuilder.AppendLine($"Birthdate: {birthdate}");
            personalInfoBuilder.AppendLine($"Birthplace: {birthplace}");
            personalInfoBuilder.AppendLine($"Marital Status: {maritalStatus}");
            personalInfoBuilder.AppendLine($"Sex: {sex}");
            personalInfoBuilder.AppendLine($"Weight: {weight}");
            personalInfoBuilder.AppendLine($"Height: {height}");

            // Work Experience (collect dynamically added entries)
            StringBuilder workExperienceBuilder = new StringBuilder();
            foreach (Control control in WorkExperience.Controls)
            {
                if (control is TextBox textBox && textBox.Name.StartsWith("newJobTitle"))
                {
                    int index = int.Parse(textBox.Name.Replace("newJobTitle", ""));
                    TextBox employerTextBox = WorkExperience.Controls.Find($"newEmployer{index}", true).FirstOrDefault() as TextBox;
                    DateTimePicker startDatePicker = WorkExperience.Controls.Find($"newStartDate{index}", true).FirstOrDefault() as DateTimePicker;
                    DateTimePicker endDatePicker = WorkExperience.Controls.Find($"newEndDate{index}", true).FirstOrDefault() as DateTimePicker;

                    if (employerTextBox != null && startDatePicker != null && endDatePicker != null)
                    {
                        workExperienceBuilder.AppendLine($"Job Title: {GetTextValue(textBox, "Job Title")}");
                        workExperienceBuilder.AppendLine($"Employer: {GetTextValue(employerTextBox, "Employer")}");
                        workExperienceBuilder.AppendLine($"Duration: {startDatePicker.Value.ToShortDateString()} - {endDatePicker.Value.ToShortDateString()}");
                        workExperienceBuilder.AppendLine();
                    }
                }
            }

            // Education
            StringBuilder educationBuilder = new StringBuilder();
            educationBuilder.AppendLine($"Primary School: {GetTextValue(School, "Primary School")}, {GetTextValue(PrimCity, "City")} - {GetTextValue(PrimAttainment, "Attainment")}");
            educationBuilder.AppendLine($"Junior High School: {GetTextValue(JunSchool, "Junior High School")}, {GetTextValue(JunCity, "City")} - {GetTextValue(JunAttainment, "Attainment")}");
            educationBuilder.AppendLine($"Senior High School: {GetTextValue(SenSchool, "Senior High School")}, {GetTextValue(SenCity, "City")} - {GetTextValue(SenAttainment, "Attainment")}");
            educationBuilder.AppendLine($"University: {GetTextValue(University, "University")}, {GetTextValue(SecCity, "City")} - {GetTextValue(SecAttainment, "Attainment")}");

            // Skills (collect dynamically added entries)
            StringBuilder skillsBuilder = new StringBuilder();
            foreach (Control control in Skills.Controls)
            {
                if (control is Label label && label.Text.StartsWith("• "))
                {
                    skillsBuilder.AppendLine(label.Text);
                }
            }

            // Certifications (collect dynamically added entries)
            StringBuilder certificationsBuilder = new StringBuilder();
            foreach (Control control in panel17.Controls)
            {
                if (control is Label label && label.Text.StartsWith("• "))
                {
                    certificationsBuilder.AppendLine(label.Text);
                }
            }

            // Character References
            string refName = GetTextValue(RefName, "Reference Name");
            string refContact = GetTextValue(RefContact, "Contact");
            string refWork = GetTextValue(RefWork, "Work/Position");
            string refEmail = GetTextValue(RefEmail, "Email");
            string characterReference = $"Name: {refName}\nContact: {refContact}\nWork/Position: {refWork}\nEmail: {refEmail}";

            // Display CV in LamsenForm2
            LamsenForm2 cvForm = new LamsenForm2();

            // Pass the uploaded photo to LamsenForm2 if available
            if (pictureBox1.Image != null)
            {
                cvForm.SetUserPhoto(pictureBox1.Image);
            }

            // Pass individual sections to DisplayCV
            cvForm.DisplayCV(
                personalInfoBuilder.ToString(),
                careerObjective,
                educationBuilder.ToString(),
                workExperienceBuilder.ToString(),
                skillsBuilder.ToString() + "\n" + certificationsBuilder.ToString(), // Combine skills and certifications
                characterReference
            );

            this.Hide(); // Hide LamsenForm1
            cvForm.Show();
            cvForm.FormClosed += (s, args) => this.Show(); // Show LamsenForm1 when LamsenForm2 is closed
        }

        // Helper method to validate required fields
        private bool ValidateRequiredFields()
        {
            List<string> missingFields = new List<string>();

            // Check required personal information fields
            if (IsPlaceholderText(FirstName, "First Name")) missingFields.Add("First Name");
            if (IsPlaceholderText(LastName, "Last Name")) missingFields.Add("Last Name");
            if (IsPlaceholderText(Age, "Age")) missingFields.Add("Age");
            if (IsPlaceholderText(BirthPlace, "Birth Place")) missingFields.Add("Birth Place");
            if (IsPlaceholderText(Email, "Email")) missingFields.Add("Email");
            if (IsPlaceholderText(ContactNumber, "Contact Number")) missingFields.Add("Contact Number");
            if (IsPlaceholderText(Address, "Address")) missingFields.Add("Address");

            // Check ComboBox selections
            if (MaritalStatus.SelectedItem == null) missingFields.Add("Marital Status");
            if (Sex.SelectedItem == null) missingFields.Add("Sex");

            // Check Career Objective
            if (IsPlaceholderText(CareerObj, "Career Objective")) missingFields.Add("Career Objective");

            // Validate email format if provided
            if (!IsPlaceholderText(Email, "Email") && !IsValidEmail(Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Email.Focus();
                return false;
            }

            // Validate age is numeric if provided
            if (!IsPlaceholderText(Age, "Age") && !int.TryParse(Age.Text, out int ageValue))
            {
                MessageBox.Show("Please enter a valid age (numeric value).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Age.Focus();
                return false;
            }

            // Check if Declaration is checked
            if (!Declaration.Checked)
            {
                missingFields.Add("Declaration (must be checked)");
            }

            if (missingFields.Count > 0)
            {
                string message = "Please fill in the following required fields:\n\n" + string.Join("\n", missingFields);
                MessageBox.Show(message, "Required Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Helper method to check if text is placeholder text
        private bool IsPlaceholderText(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                return string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholderText;
            }
            else if (control is RichTextBox richTextBox)
            {
                return string.IsNullOrWhiteSpace(richTextBox.Text) || richTextBox.Text == placeholderText;
            }
            return true;
        }

        // Helper method to get actual text value (not placeholder)
        private string GetTextValue(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                return (textBox.Text == placeholderText || string.IsNullOrWhiteSpace(textBox.Text)) ? "" : textBox.Text;
            }
            else if (control is RichTextBox richTextBox)
            {
                return (richTextBox.Text == placeholderText || string.IsNullOrWhiteSpace(richTextBox.Text)) ? "" : richTextBox.Text;
            }
            return "";
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
                CV form1 = new CV();
                form1.Show();
                this.Hide();
        }
    }
}