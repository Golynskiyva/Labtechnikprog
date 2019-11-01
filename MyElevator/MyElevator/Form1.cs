using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyElevator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lift newl = new Lift();
            newl.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IshForm newForm = new IshForm(this);
            newForm.Show();
            this.button2.Enabled = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistic newForm = new Statistic();
            newForm.Show();
            
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Levels newlev = new Levels();
            newlev.Show();
        }
    }
}
