using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            endOfGame1.Hide();

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
                endOfGame1.Show(clickTimes);
                button1.Hide();
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
            button1.Location = new Point(
                random.Next(this.ClientSize.Width - button1.Width),
                random.Next(this.ClientSize.Height - button1.Height));
        }

        private void endOfGame1_RestartGame(object sender, EventArgs e)
        {
            clickTimes.Clear();
            endOfGame1.Hide();
            button1.Show();
            counter = 1;
            RelocateButton();
        }
    }
}
