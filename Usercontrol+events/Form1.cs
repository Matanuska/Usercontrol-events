using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrol_events
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        public Form1()
        {
            InitializeComponent();
            startTime = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in this.Controls.OfType<UserControl1>())
            {
                (uc as UserControl1).serialDataReceived("up",textBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in this.Controls.OfType<ISerialDataSubscriber>())
            {
                (uc as UserControl1).serialDataReceived("down", textBox1.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;

            label1.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}:{4:00}", timeElapsed.Days,timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds,timeElapsed.Milliseconds);
           
        }
    }
}
