using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IESC
{
    public partial class switcher : Form
    {
        public bool running { get; private set; }
        public int count { get; private set; }
        public int Secounds { get; private set; }

        public switcher()
        {
            InitializeComponent();
            count = 0;
            running = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "" + (trackBar1.Value * 10);
            Secounds = trackBar1.Value * 10;
            progressBar.Maximum = Secounds;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (running == true)
            {
                count++;
                Console.WriteLine(count);

                progressBar.Value = count;

                if (count == Secounds)
                {
                    SendKeys.Send("^M");
                    Console.WriteLine("changed scene");
                    count = 0;
                }
            }
        }

        private void BtnSwitchStart_Click(object sender, EventArgs e)
        {
            running = true;
            count = 0;
        }

        private void BtnSwitchStop_Click(object sender, EventArgs e)
        {
            running = false;
        }
    }
}
