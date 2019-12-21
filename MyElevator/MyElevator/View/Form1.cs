using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyElevator.Presenter;

namespace MyElevator
{
    public partial class Form1 : Form
    {
        public SystemLift sl;
        public Lift fLift;
        public IshForm fIsh;
        public Statistic fStat;
        public Levels fLev;
        public addman faddm;
        public Form1()
        {
            InitializeComponent();
            fLift = new Lift();
            
            fIsh = new IshForm(this);
            
            fStat = new Statistic();
           
            fLev = new Levels();
            
            faddm = new addman();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fLift.sl = sl;
            fLift.Show();

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
            fIsh.sl = sl;
            fIsh.Show();
            this.button2.Enabled = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            fStat.sl = sl;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fLev.sl = sl;
            fLev.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faddm.sl = sl;
            faddm.Show();
        }
        public void GetBarStatusMan(string s1)
        {
            label1.Text = s1;
        }
        public void UpdateInfo(string s1)
        {
            textBox2.Text = s1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sl.RefreshInfo();
        }
    }
}
