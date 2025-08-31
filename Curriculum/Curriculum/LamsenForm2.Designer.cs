using System;

namespace Curriculum
{
    public partial class LamsenForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbPersonalInfo = new System.Windows.Forms.RichTextBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbCareerObjective = new System.Windows.Forms.RichTextBox();
            this.lblCareerObjective = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbEducation = new System.Windows.Forms.RichTextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbWorkExperience = new System.Windows.Forms.RichTextBox();
            this.lblWorkExperience = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtbSkills = new System.Windows.Forms.RichTextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtbReferences = new System.Windows.Forms.RichTextBox();
            this.lblReferences = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.pictureBoxPhoto);
            this.panel1.Controls.Add(this.lblContactInfo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(700, 10);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 2;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.ForeColor = System.Drawing.Color.White;
            this.lblContactInfo.Location = new System.Drawing.Point(25, 60);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(83, 17);
            this.lblContactInfo.TabIndex = 1;
            this.lblContactInfo.Text = "Contact Info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbPersonalInfo);
            this.panel2.Controls.Add(this.lblPersonalInfo);
            this.panel2.Location = new System.Drawing.Point(20, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 80);
            this.panel2.TabIndex = 1;
            // 
            // rtbPersonalInfo
            // 
            this.rtbPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPersonalInfo.Location = new System.Drawing.Point(0, 25);
            this.rtbPersonalInfo.Name = "rtbPersonalInfo";
            this.rtbPersonalInfo.ReadOnly = true;
            this.rtbPersonalInfo.Size = new System.Drawing.Size(760, 50);
            this.rtbPersonalInfo.TabIndex = 1;
            this.rtbPersonalInfo.Text = "";
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(176, 20);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "Personal Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbCareerObjective);
            this.panel3.Controls.Add(this.lblCareerObjective);
            this.panel3.Location = new System.Drawing.Point(20, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 80);
            this.panel3.TabIndex = 2;
            // 
            // rtbCareerObjective
            // 
            this.rtbCareerObjective.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCareerObjective.Location = new System.Drawing.Point(0, 25);
            this.rtbCareerObjective.Name = "rtbCareerObjective";
            this.rtbCareerObjective.ReadOnly = true;
            this.rtbCareerObjective.Size = new System.Drawing.Size(760, 50);
            this.rtbCareerObjective.TabIndex = 1;
            this.rtbCareerObjective.Text = "";
            // 
            // lblCareerObjective
            // 
            this.lblCareerObjective.AutoSize = true;
            this.lblCareerObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCareerObjective.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblCareerObjective.Location = new System.Drawing.Point(0, 0);
            this.lblCareerObjective.Name = "lblCareerObjective";
            this.lblCareerObjective.Size = new System.Drawing.Size(142, 20);
            this.lblCareerObjective.TabIndex = 0;
            this.lblCareerObjective.Text = "Career Objective";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtbEducation);
            this.panel4.Controls.Add(this.lblEducation);
            this.panel4.Location = new System.Drawing.Point(20, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 100);
            this.panel4.TabIndex = 3;
            // 
            // rtbEducation
            // 
            this.rtbEducation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEducation.Location = new System.Drawing.Point(0, 25);
            this.rtbEducation.Name = "rtbEducation";
            this.rtbEducation.ReadOnly = true;
            this.rtbEducation.Size = new System.Drawing.Size(760, 70);
            this.rtbEducation.TabIndex = 1;
            this.rtbEducation.Text = "";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblEducation.Location = new System.Drawing.Point(0, 0);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(90, 20);
            this.lblEducation.TabIndex = 0;
            this.lblEducation.Text = "Education";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtbWorkExperience);
            this.panel5.Controls.Add(this.lblWorkExperience);
            this.panel5.Location = new System.Drawing.Point(20, 410);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 100);
            this.panel5.TabIndex = 4;
            // 
            // rtbWorkExperience
            // 
            this.rtbWorkExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWorkExperience.Location = new System.Drawing.Point(0, 25);
            this.rtbWorkExperience.Name = "rtbWorkExperience";
            this.rtbWorkExperience.ReadOnly = true;
            this.rtbWorkExperience.Size = new System.Drawing.Size(760, 70);
            this.rtbWorkExperience.TabIndex = 1;
            this.rtbWorkExperience.Text = "";
            // 
            // lblWorkExperience
            // 
            this.lblWorkExperience.AutoSize = true;
            this.lblWorkExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblWorkExperience.Location = new System.Drawing.Point(0, 0);
            this.lblWorkExperience.Name = "lblWorkExperience";
            this.lblWorkExperience.Size = new System.Drawing.Size(144, 20);
            this.lblWorkExperience.TabIndex = 0;
            this.lblWorkExperience.Text = "Work Experience";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rtbSkills);
            this.panel6.Controls.Add(this.lblSkills);
            this.panel6.Location = new System.Drawing.Point(20, 520);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(760, 80);
            this.panel6.TabIndex = 5;
            // 
            // rtbSkills
            // 
            this.rtbSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSkills.Location = new System.Drawing.Point(0, 25);
            this.rtbSkills.Name = "rtbSkills";
            this.rtbSkills.ReadOnly = true;
            this.rtbSkills.Size = new System.Drawing.Size(760, 50);
            this.rtbSkills.TabIndex = 1;
            this.rtbSkills.Text = "";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblSkills.Location = new System.Drawing.Point(0, 0);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(51, 20);
            this.lblSkills.TabIndex = 0;
            this.lblSkills.Text = "Skills";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rtbReferences);
            this.panel7.Controls.Add(this.lblReferences);
            this.panel7.Location = new System.Drawing.Point(20, 610);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 80);
            this.panel7.TabIndex = 6;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // rtbReferences
            // 
            this.rtbReferences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReferences.Location = new System.Drawing.Point(0, 25);
            this.rtbReferences.Name = "rtbReferences";
            this.rtbReferences.ReadOnly = true;
            this.rtbReferences.Size = new System.Drawing.Size(760, 50);
            this.rtbReferences.TabIndex = 1;
            this.rtbReferences.Text = "";
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.lblReferences.Location = new System.Drawing.Point(0, 0);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(102, 20);
            this.lblReferences.TabIndex = 0;
            this.lblReferences.Text = "References";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(520, 710);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 35);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(620, 710);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(720, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LamsenForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LamsenForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Display - LamsenForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.RichTextBox rtbPersonalInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCareerObjective;
        private System.Windows.Forms.RichTextBox rtbCareerObjective;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.RichTextBox rtbEducation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWorkExperience;
        private System.Windows.Forms.RichTextBox rtbWorkExperience;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.RichTextBox rtbSkills;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.RichTextBox rtbReferences;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}