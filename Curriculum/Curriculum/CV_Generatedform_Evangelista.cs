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
    public partial class Fillup_Evangelista : Form
    {
        private bool isDateSet = false;
        private const string ContactNumberPlaceholder = "Contact Number";
        private const string ContactPrefix = "+63";

        public Fillup_Evangelista()
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            pictureBox2.Region = new Region(path);

            pictureBox2.Paint += new PaintEventHandler(PictureBox2_Paint);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Value = new DateTime(2025, 1, 1);
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            txtage.ReadOnly = true;

            btngenerate.Enabled = true;

            txtname.Text = "First Name, MI (Optional), Surname, Suffix (Optional)";
            txtname.ForeColor = Color.Gray;
            txtname.Enter += new EventHandler(TextBox_Enter);
            txtname.Leave += new EventHandler(TextBox_Leave);

            txtaddress.Text = "Address";
            txtaddress.ForeColor = Color.Gray;
            txtaddress.Enter += new EventHandler(TextBox_Enter);
            txtaddress.Leave += new EventHandler(TextBox_Leave);

            txtemail.Text = "Email (e.g., example@gmail.com)";
            txtemail.ForeColor = Color.Gray;
            txtemail.Enter += new EventHandler(TextBox_Enter);
            txtemail.Leave += new EventHandler(TextBox_Leave);

            txtplace.Text = "Place of Birth";
            txtplace.ForeColor = Color.Gray;
            txtplace.Enter += new EventHandler(TextBox_Enter);
            txtplace.Leave += new EventHandler(TextBox_Leave);

            txtreligion.Text = "Religion";
            txtreligion.ForeColor = Color.Gray;
            txtreligion.Enter += new EventHandler(TextBox_Enter);
            txtreligion.Leave += new EventHandler(TextBox_Leave);

            txtcontactno.Text = ContactNumberPlaceholder;
            txtcontactno.ForeColor = Color.Gray;
            txtcontactno.Enter += new EventHandler(TextBox_Enter);
            txtcontactno.Leave += new EventHandler(TextBox_Leave);
            txtcontactno.KeyPress += new KeyPressEventHandler(txtcontactno_KeyPress);

            txtnation.Text = "Nationality";
            txtnation.ForeColor = Color.Gray;
            txtnation.Enter += new EventHandler(TextBox_Enter);
            txtnation.Leave += new EventHandler(TextBox_Leave);

            txttertiaryname.Text = "Tertiary School Name";
            txttertiaryname.ForeColor = Color.Gray;
            txttertiaryname.Enter += new EventHandler(TextBox_Enter);
            txttertiaryname.Leave += new EventHandler(TextBox_Leave);

            txttertiaryyear.Text = "Tertiary Year";
            txttertiaryyear.ForeColor = Color.Gray;
            txttertiaryyear.Enter += new EventHandler(TextBox_Enter);
            txttertiaryyear.Leave += new EventHandler(TextBox_Leave);

            txttertiaryaddress.Text = "Tertiary Address";
            txttertiaryaddress.ForeColor = Color.Gray;
            txttertiaryaddress.Enter += new EventHandler(TextBox_Enter);
            txttertiaryaddress.Leave += new EventHandler(TextBox_Leave);

            txtseniorname.Text = "Senior High School Name";
            txtseniorname.ForeColor = Color.Gray;
            txtseniorname.Enter += new EventHandler(TextBox_Enter);
            txtseniorname.Leave += new EventHandler(TextBox_Leave);

            txtsenioraddress.Text = "Senior High School Address";
            txtsenioraddress.ForeColor = Color.Gray;
            txtsenioraddress.Enter += new EventHandler(TextBox_Enter);
            txtsenioraddress.Leave += new EventHandler(TextBox_Leave);

            txtsenioryear.Text = "Senior High School Year";
            txtsenioryear.ForeColor = Color.Gray;
            txtsenioryear.Enter += new EventHandler(TextBox_Enter);
            txtsenioryear.Leave += new EventHandler(TextBox_Leave);

            txthighname.Text = "High School Name";
            txthighname.ForeColor = Color.Gray;
            txthighname.Enter += new EventHandler(TextBox_Enter);
            txthighname.Leave += new EventHandler(TextBox_Leave);

            txthighaddress.Text = "High School Address";
            txthighaddress.ForeColor = Color.Gray;
            txthighaddress.Enter += new EventHandler(TextBox_Enter);
            txthighaddress.Leave += new EventHandler(TextBox_Leave);

            txthighyear.Text = "High School Year";
            txthighyear.ForeColor = Color.Gray;
            txthighyear.Enter += new EventHandler(TextBox_Enter);
            txthighyear.Leave += new EventHandler(TextBox_Leave);

            txtprimaryname.Text = "Primary School Name";
            txtprimaryname.ForeColor = Color.Gray;
            txtprimaryname.Enter += new EventHandler(TextBox_Enter);
            txtprimaryname.Leave += new EventHandler(TextBox_Leave);

            txtprimaryaddress.Text = "Primary School Address";
            txtprimaryaddress.ForeColor = Color.Gray;
            txtprimaryaddress.Enter += new EventHandler(TextBox_Enter);
            txtprimaryaddress.Leave += new EventHandler(TextBox_Leave);

            txtprimaryyear.Text = "Primary School Year";
            txtprimaryyear.ForeColor = Color.Gray;
            txtprimaryyear.Enter += new EventHandler(TextBox_Enter);
            txtprimaryyear.Leave += new EventHandler(TextBox_Leave);

            txtskill1.Text = "Skill 1";
            txtskill1.ForeColor = Color.Gray;
            txtskill1.Enter += new EventHandler(TextBox_Enter);
            txtskill1.Leave += new EventHandler(TextBox_Leave);

            txtskill2.Text = "Skill 2";
            txtskill2.ForeColor = Color.Gray;
            txtskill2.Enter += new EventHandler(TextBox_Enter);
            txtskill2.Leave += new EventHandler(TextBox_Leave);

            txtskill3.Text = "Skill 3";
            txtskill3.ForeColor = Color.Gray;
            txtskill3.Enter += new EventHandler(TextBox_Enter);
            txtskill3.Leave += new EventHandler(TextBox_Leave);

            txtskill4.Text = "Skill 4";
            txtskill4.ForeColor = Color.Gray;
            txtskill4.Enter += new EventHandler(TextBox_Enter);
            txtskill4.Leave += new EventHandler(TextBox_Leave);

            txtpersonname1.Text = "Reference 1 Name";
            txtpersonname1.ForeColor = Color.Gray;
            txtpersonname1.Enter += new EventHandler(TextBox_Enter);
            txtpersonname1.Leave += new EventHandler(TextBox_Leave);

            txtrelationship1.Text = "Reference 1 Relationship";
            txtrelationship1.ForeColor = Color.Gray;
            txtrelationship1.Enter += new EventHandler(TextBox_Enter);
            txtrelationship1.Leave += new EventHandler(TextBox_Leave);

            txtcontact1.Text = "Reference 1 Contact";
            txtcontact1.ForeColor = Color.Gray;
            txtcontact1.Enter += new EventHandler(TextBox_Enter);
            txtcontact1.Leave += new EventHandler(TextBox_Leave);

            txtpersonname2.Text = "Reference 2 Name";
            txtpersonname2.ForeColor = Color.Gray;
            txtpersonname2.Enter += new EventHandler(TextBox_Enter);
            txtpersonname2.Leave += new EventHandler(TextBox_Leave);

            txtrelationship2.Text = "Reference 2 Relationship";
            txtrelationship2.ForeColor = Color.Gray;
            txtrelationship2.Enter += new EventHandler(TextBox_Enter);
            txtrelationship2.Leave += new EventHandler(TextBox_Leave);

            txtcontact2.Text = "Reference 2 Contact";
            txtcontact2.ForeColor = Color.Gray;
            txtcontact2.Enter += new EventHandler(TextBox_Enter);
            txtcontact2.Leave += new EventHandler(TextBox_Leave);

            txtpersonname3.Text = "Reference 3 Name";
            txtpersonname3.ForeColor = Color.Gray;
            txtpersonname3.Enter += new EventHandler(TextBox_Enter);
            txtpersonname3.Leave += new EventHandler(TextBox_Leave);

            txtrelationship3.Text = "Reference 3 Relationship";
            txtrelationship3.ForeColor = Color.Gray;
            txtrelationship3.Enter += new EventHandler(TextBox_Enter);
            txtrelationship3.Leave += new EventHandler(TextBox_Leave);

            txtcontact3.Text = "Reference 3 Contact";
            txtcontact3.ForeColor = Color.Gray;
            txtcontact3.Enter += new EventHandler(TextBox_Enter);
            txtcontact3.Leave += new EventHandler(TextBox_Leave);

            richTextBox1.Text = "Objective";
            richTextBox1.ForeColor = Color.Gray;
            richTextBox1.Enter += new EventHandler(RichTextBox_Enter);
            richTextBox1.Leave += new EventHandler(RichTextBox_Leave);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1000);

            Panel contentPanel = new Panel
            {
                Location = new Point(10, pictureBox2.Bottom + 10),
                Size = new Size(this.ClientSize.Width - 30, 700),
            };
            this.Controls.Add(contentPanel);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Value = new DateTime(2025, 1, 1);
            isDateSet = false;
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 3))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(pen, 0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isDateSet = true;
            dateTimePicker1.CustomFormat = "MMMM d, yyyy";
            UpdateAge();
        }

        private void UpdateAge()
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = dateTimePicker1.Value;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--;

            txtage.Text = age.ToString();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.ForeColor == Color.Gray)
            {
                if (tb == txtcontactno)
                {
                    tb.Text = ContactPrefix;
                    tb.ForeColor = Color.Black;
                    tb.SelectionStart = tb.Text.Length;
                }
                else
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == txtcontactno)
                {
                    tb.Text = ContactNumberPlaceholder;
                    tb.ForeColor = Color.Gray;
                }
                else
                {
                    if (tb == txtname) tb.Text = "First Name, MI (Optional), Surname, Suffix (Optional)";
                    else if (tb == txtaddress) tb.Text = "Address";
                    else if (tb == txtemail) tb.Text = "Email (e.g., example@gmail.com)";
                    else if (tb == txtplace) tb.Text = "Place of Birth";
                    else if (tb == txtreligion) tb.Text = "Religion";
                    else if (tb == txtnation) tb.Text = "Nationality";
                    else if (tb == txttertiaryname) tb.Text = "Tertiary School Name";
                    else if (tb == txttertiaryyear) tb.Text = "Tertiary Year";
                    else if (tb == txttertiaryaddress) tb.Text = "Tertiary Address";
                    else if (tb == txtseniorname) tb.Text = "Senior High School Name";
                    else if (tb == txtsenioraddress) tb.Text = "Senior High School Address";
                    else if (tb == txtsenioryear) tb.Text = "Senior High School Year";
                    else if (tb == txthighname) tb.Text = "High School Name";
                    else if (tb == txthighaddress) tb.Text = "High School Address";
                    else if (tb == txthighyear) tb.Text = "High School Year";
                    else if (tb == txtprimaryname) tb.Text = "Primary School Name";
                    else if (tb == txtprimaryaddress) tb.Text = "Primary School Address";
                    else if (tb == txtprimaryyear) tb.Text = "Primary School Year";
                    else if (tb == txtskill1) tb.Text = "Skill 1";
                    else if (tb == txtskill2) tb.Text = "Skill 2";
                    else if (tb == txtskill3) tb.Text = "Skill 3";
                    else if (tb == txtskill4) tb.Text = "Skill 4";
                    else if (tb == txtpersonname1) tb.Text = "Reference 1 Name";
                    else if (tb == txtrelationship1) tb.Text = "Reference 1 Relationship";
                    else if (tb == txtcontact1) tb.Text = "Reference 1 Contact";
                    else if (tb == txtpersonname2) tb.Text = "Reference 2 Name";
                    else if (tb == txtrelationship2) tb.Text = "Reference 2 Relationship";
                    else if (tb == txtcontact2) tb.Text = "Reference 2 Contact";
                    else if (tb == txtpersonname3) tb.Text = "Reference 3 Name";
                    else if (tb == txtrelationship3) tb.Text = "Reference 3 Relationship";
                    else if (tb == txtcontact3) tb.Text = "Reference 3 Contact";
                    tb.ForeColor = Color.Gray;
                }
            }
            else if (tb == txtcontactno && tb.Text == ContactPrefix)
            {
                tb.Text = ContactNumberPlaceholder;
                tb.ForeColor = Color.Gray;
            }
        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar))
            {
                TextBox tb = sender as TextBox;
                if (tb.SelectionStart < ContactPrefix.Length && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == (char)Keys.Back && tb.SelectionStart <= ContactPrefix.Length && tb.SelectionLength == 0)
                {
                    e.Handled = true;
                    return;
                }
                if (tb.Text.Length >= 13 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RichTextBox_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb != null && rtb.ForeColor == Color.Gray)
            {
                rtb.Text = "";
                rtb.ForeColor = Color.Black;
            }
        }

        private void RichTextBox_Leave(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb != null && string.IsNullOrWhiteSpace(rtb.Text))
            {
                rtb.Text = "Objective";
                rtb.ForeColor = Color.Gray;
            }
        }

        private bool ValidateInputs(out string errorMessage)
        {
            StringBuilder errors = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtname.Text) || txtname.Text == "First Name, MI (Optional), Surname, Suffix (Optional)")
            {
                errors.AppendLine("Name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtaddress.Text) || txtaddress.Text == "Address")
            {
                errors.AppendLine("Address is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtemail.Text) || txtemail.Text == "Email (e.g., example@gmail.com)")
            {
                errors.AppendLine("Email is required.");
                isValid = false;
            }
            else if (!txtemail.Text.ToLower().EndsWith("@gmail.com"))
            {
                errors.AppendLine("Email must be a valid Gmail address (ends with @gmail.com).");
                isValid = false;
            }
            if (!int.TryParse(txtage.Text, out int age) || age < 15 || age > 80)
            {
                errors.AppendLine("Age must be between 15 and 80.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(cmbsex.Text))
            {
                errors.AppendLine("Sex is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(cmbcivil.Text))
            {
                errors.AppendLine("Civil status is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtplace.Text) || txtplace.Text == "Place of Birth")
            {
                errors.AppendLine("Place of birth is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtreligion.Text) || txtreligion.Text == "Religion")
            {
                errors.AppendLine("Religion is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtcontactno.Text) || txtcontactno.Text == ContactNumberPlaceholder)
            {
                errors.AppendLine("Contact number is required.");
                isValid = false;
            }
            else if (!txtcontactno.Text.StartsWith(ContactPrefix) || txtcontactno.Text.Length != 13 || !txtcontactno.Text.Substring(3).All(char.IsDigit))
            {
                errors.AppendLine("Contact number must start with +63 and be followed by exactly 10 digits (e.g., +639123456789).");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtnation.Text) || txtnation.Text == "Nationality")
            {
                errors.AppendLine("Nationality is required.");
                isValid = false;
            }
            if (!isDateSet)
            {
                errors.AppendLine("Date of birth is required.");
                isValid = false;
            }
            if (pictureBox2.Image == null)
            {
                errors.AppendLine("Profile picture is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(richTextBox1.Text) || richTextBox1.Text == "Objective")
            {
                errors.AppendLine("Objective is required.");
                isValid = false;
            }

            errorMessage = errors.ToString();
            return isValid;
        }

        private string GetTextOrEmpty(TextBox tb, string placeholder)
        {
            return (tb.Text == placeholder || string.IsNullOrWhiteSpace(tb.Text)) ? "" : tb.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to generate the form?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult agreementResult = MessageBox.Show(
                    "By clicking 'Yes', you agree to the terms and conditions of this application.\n\n" +
                    "Terms: The information provided will be used to generate your CV and may be stored for record-keeping.\n" +
                    "Do you agree?",
                    "Agreement",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (agreementResult == DialogResult.Yes)
                {
                    if (ValidateInputs(out string errorMessage))
                    {
                        CV_Evangelista generatedForm = new CV_Evangelista(
                            txtname.Text,
                            richTextBox1.Text,
                            pictureBox2.Image,
                            dateTimePicker1.Text,
                            txtaddress.Text,
                            txtage.Text,
                            cmbsex.Text,
                            txtemail.Text,
                            cmbcivil.Text,
                            txtplace.Text,
                            txtreligion.Text,
                            txtcontactno.Text,
                            txtnation.Text,
                            GetTextOrEmpty(txttertiaryname, "Tertiary School Name"),
                            GetTextOrEmpty(txttertiaryyear, "Tertiary Year"),
                            GetTextOrEmpty(txttertiaryaddress, "Tertiary Address"),
                            GetTextOrEmpty(txtseniorname, "Senior High School Name"),
                            GetTextOrEmpty(txtsenioraddress, "Senior High School Address"),
                            GetTextOrEmpty(txtsenioryear, "Senior High School Year"),
                            GetTextOrEmpty(txthighname, "High School Name"),
                            GetTextOrEmpty(txthighaddress, "High School Address"),
                            GetTextOrEmpty(txthighyear, "High School Year"),
                            GetTextOrEmpty(txtprimaryname, "Primary School Name"),
                            GetTextOrEmpty(txtprimaryaddress, "Primary School Address"),
                            GetTextOrEmpty(txtprimaryyear, "Primary School Year"),
                            GetTextOrEmpty(txtskill1, "Skill 1"),
                            GetTextOrEmpty(txtskill2, "Skill 2"),
                            GetTextOrEmpty(txtskill3, "Skill 3"),
                            GetTextOrEmpty(txtskill4, "Skill 4"),
                            GetTextOrEmpty(txtpersonname1, "Reference 1 Name"),
                            GetTextOrEmpty(txtrelationship1, "Reference 1 Relationship"),
                            GetTextOrEmpty(txtcontact1, "Reference 1 Contact"),
                            GetTextOrEmpty(txtpersonname2, "Reference 2 Name"),
                            GetTextOrEmpty(txtrelationship2, "Reference 2 Relationship"),
                            GetTextOrEmpty(txtcontact2, "Reference 2 Contact"),
                            GetTextOrEmpty(txtpersonname3, "Reference 3 Name"),
                            GetTextOrEmpty(txtrelationship3, "Reference 3 Relationship"),
                            GetTextOrEmpty(txtcontact3, "Reference 3 Contact")
                        );
                        generatedForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CV generatedForm = new CV();
            generatedForm.Show();
            this.Hide();
        }

        private void txttertiaryname_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}