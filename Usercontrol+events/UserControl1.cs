using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrol_events
{
    public partial class UserControl1 : UserControl, ISerialData
    {
        public UserControl1()
        {
            InitializeComponent();
            numericUpDown1.ResetText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void serialDataReceived(string inc,string msg)
        {
            if (msg == textBox1.Text)
            {
                if (inc == "up")
                {
                    numericUpDown1.Value = numericUpDown1.Value + 1;
                }
                else
                {
                    if (numericUpDown1.Value > numericUpDown1.Minimum)
                    {
                        numericUpDown1.Value = numericUpDown1.Value - 1;
                    }
                    else
                    {
                        numericUpDown1.ResetText();
                    }
                }
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
