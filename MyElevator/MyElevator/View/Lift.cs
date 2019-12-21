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
    public partial class Lift : Form
    {
        public SystemLift sl;
        public Lift()
        {
            InitializeComponent();
        }
        public void updateInfo(string s)
        {
            label1.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
