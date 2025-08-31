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
    public partial class CV : Form
    {
        public CV()
        {
            InitializeComponent();
            GraphicsPath evangelista = new GraphicsPath();
            evangelista.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            pictureBox1.Region = new Region(evangelista);

            pictureBox1.Paint += new PaintEventHandler(PictureBox1_Paint);

            //picturebox2
            GraphicsPath val = new GraphicsPath();
            val.AddEllipse(0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            pictureBox2.Region = new Region(val);

            pictureBox2.Paint += new PaintEventHandler(PictureBox2_Paint);

            //picturebox3
            GraphicsPath galdi = new GraphicsPath();
            galdi.AddEllipse(0, 0, pictureBox3.Width - 1, pictureBox3.Height - 1);
            pictureBox3.Region = new Region(galdi);

            pictureBox3.Paint += new PaintEventHandler(PictureBox3_Paint);

            //picturebox4
            GraphicsPath gene = new GraphicsPath();
            gene.AddEllipse(0, 0, pictureBox4.Width - 1, pictureBox4.Height - 1);
            pictureBox4.Region = new Region(gene);

            pictureBox4.Paint += new PaintEventHandler(PictureBox4_Paint);

            //picturebox5
            GraphicsPath calcu = new GraphicsPath();
            calcu.AddEllipse(0, 0, pictureBox5.Width - 1, pictureBox5.Height - 1);
            pictureBox5.Region = new Region(calcu);

            pictureBox5.Paint += new PaintEventHandler(PictureBox5_Paint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Fillup_Evangelista generatedForm = new Fillup_Evangelista();
            generatedForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            LamsenForm1 generatedForm = new LamsenForm1();
            generatedForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            henifillupform generatedForm = new henifillupform();
            generatedForm.Show();
            this.Hide();
        }

        

        private void CV_Load(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen evangelista = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(evangelista, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            }
        }
        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen val = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(val, 0, 0, pictureBox2.Width - 1, pictureBox2.Height - 1);
            }
        }
        private void PictureBox3_Paint(object sender, PaintEventArgs e)
        {
            using (Pen galdi = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(galdi, 0, 0, pictureBox3.Width - 1, pictureBox3.Height - 1);
            }
        }
             private void PictureBox4_Paint(object sender, PaintEventArgs e)
        {
            using (Pen gene = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(gene, 0, 0, pictureBox4.Width - 1, pictureBox4.Height - 1);
            }
        }

        private void PictureBox5_Paint(object sender, PaintEventArgs e)
        {
            using (Pen calcu = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(calcu, 0, 0, pictureBox5.Width - 1, pictureBox5.Height - 1);
            }
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            Calculator generatedForm = new Calculator();
            generatedForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            galdianofillupform generatedForm = new galdianofillupform();
            generatedForm.Show();
            this.Hide();
        }
    }
}
