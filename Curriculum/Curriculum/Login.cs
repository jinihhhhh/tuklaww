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
    public partial class Login : Form
    {
        private int loginAttempts = 0;
        private bool isLocked = false;
        private DateTime lockoutEndTime;
        private const int MAX_ATTEMPTS = 3;
        private const int LOCKOUT_SECONDS = 30;

        // Dictionary to store username-password pairs
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "Evangelista", "pass123" },
            { "Galdiano", "pass456" },
            { "Lamsen", "pass789" },
            { "Tabios", "pass101" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbsurname.Items.AddRange(new string[] {"Evangelista", "Galdiano", "Lamsen", "Tabios" });

            
            Timer lockoutTimer = new Timer();
            lockoutTimer.Interval = 1000; // Check every second
            lockoutTimer.Tick += LockoutTimer_Tick;
            lockoutTimer.Start();
        }

        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            if (isLocked && DateTime.Now >= lockoutEndTime)
            {
                // Unlock after 30 seconds
                isLocked = false;
                loginAttempts = 0;
                btnLogin.Enabled = true;
                lblStatus.Text = "Please login.";
                lblStatus.ForeColor = Color.Black;
            }
            else if (isLocked)
            {
                // Update status with remaining time
                int secondsLeft = (int)(lockoutEndTime - DateTime.Now).TotalSeconds;
                lblStatus.Text = $"Too many failed attempts. Try again in {secondsLeft} seconds.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void cmbsurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear status message when username changes
            lblStatus.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            // Clear status message when password changes
            lblStatus.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLocked)
            {
                lblStatus.Text = $"Too many failed attempts. Try again in {(int)(lockoutEndTime - DateTime.Now).TotalSeconds} seconds.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            string selectedUser = cmbsurname.SelectedItem?.ToString();
            string enteredPassword = txtpassword.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(selectedUser) || string.IsNullOrEmpty(enteredPassword))
            {
                lblStatus.Text = "Please select a username and enter a password.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            // Check credentials
            if (users.ContainsKey(selectedUser) && users[selectedUser] == enteredPassword)
            {
                // Successful login
                loginAttempts = 0;
                lblStatus.Text = "Login successful!";
                lblStatus.ForeColor = Color.Green;

                // Open MainForm and close Login form
                CV marc = new CV();
                marc.Show();
                this.Hide();
            }
            else
            {
                // Failed login
                loginAttempts++;
                int remainingAttempts = MAX_ATTEMPTS - loginAttempts;

                if (loginAttempts >= MAX_ATTEMPTS)
                {
                    isLocked = true;
                    lockoutEndTime = DateTime.Now.AddSeconds(LOCKOUT_SECONDS);
                    btnLogin.Enabled = false;
                    lblStatus.Text = $"Too many failed attempts. Try again in {LOCKOUT_SECONDS} seconds.";
                    lblStatus.ForeColor = Color.Red;
                }
                else
                {
                    lblStatus.Text = $"Incorrect username or password. {remainingAttempts} attempts remaining.";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            }
    }
}