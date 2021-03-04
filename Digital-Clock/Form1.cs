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
            //the time label is updated using DateTime to show the current hour and minute of the day
            timeLabel.Text = DateTime.Now.ToString("hh:mm");
            //the seconds label is updated using DateTime to show the seconds of the current minute
            secondsLabel.Text = DateTime.Now.ToString("ss");
            //the AM/PM label is updated using DateTime to show if it is currently AM or PM
            amPmLabel.Text = DateTime.Now.ToString("tt");
            //the calendar label is updated using DateTime to show the current month, date, and year
            calLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            //the day label is updated using DateTime to show the current day of the week
            dayLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //when the form loads, the timer begins and all labels are updated via the timer tick function
            timer.Start();
        }
    }
}
