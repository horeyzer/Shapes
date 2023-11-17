using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rectangle r = new Rectangle();
                pictureBox1.Image = Image.FromFile(r.AssignPicture());
            }
            if (radioButton2.Checked)
            {
                Square s = new Square();
                pictureBox1.Image = Image.FromFile(s.AssignPicture());
            }
            if (radioButton3.Checked)
            {
                Circle c = new Circle();
                pictureBox1.Image = Image.FromFile(c.AssignPicture());
            }
            if (radioButton4.Checked)
            {
                Triangle t = new Triangle();
                pictureBox1.Image = Image.FromFile(t.AssignPicture());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
