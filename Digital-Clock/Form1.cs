using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            calLabel.Text = DateTime.Now.ToString("MMM dd, yyyy");
            dayLabel.Text = DateTime.Now.ToString("dddd");
        }
    }
}
