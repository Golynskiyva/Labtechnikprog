using MyElevator.Presenter;
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
    public partial class Statistic : Form
    {
        public SystemLift sl;
        public Statistic()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void activForm()
        {
            label2.Text = " "+ sl.GetStatistic(1);
            label3.Text = " " + sl.GetStatistic(2);
            label4.Text = " " + sl.GetStatistic(3);
            label5.Text = " " + sl.GetStatistic(4);
            this.Show();
        }
    }
}
