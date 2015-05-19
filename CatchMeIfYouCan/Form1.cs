using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMeIfYouCan
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<DateTime> clickTimes = new List<DateTime>();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 11)
            {
                RelocateButton();
                counter++;
                clickTimes.Add(DateTime.Now);
            }
            else
            {
                listBox1.Show();
                button1.Hide();

                for (int i = 1; i < clickTimes.Count; i++)
                {
                    TimeSpan interval = clickTimes[i] - clickTimes[i - 1];
                    string intervalString = string.Format(@"Click {0:00} -- {1:ss\.ff}", 
                        i, interval);
                    listBox1.Items.Add(intervalString);
                }
            }
        }

        /// <summary>
        /// Move the button to a random location
        /// </summary>
        /// <remarks>
        /// TODO: Fix the bug where the button goes off the screen
        /// </remarks>
        private void RelocateButton()
        {
            button1.Location = new Point(random.Next(this.Width - button1.Width), random.Next(this.Height - button1.Height));

            while (button1.Right > this.Right || button1.Bottom > this.Bottom)
            {
                button1.Location = new Point(random.Next(this.Width - button1.Width), random.Next(this.Height - button1.Height));
            }
        }
    }
}
