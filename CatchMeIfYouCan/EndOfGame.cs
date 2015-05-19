using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonPosition
{
    public partial class EndOfGame : UserControl
    {
        public event EventHandler RestartGame;

        public EndOfGame()
        {
            InitializeComponent();
        }

        internal void Show(List<DateTime> clickTimes)
        {
            for (int i = 1; i < clickTimes.Count; i++)
            {
                TimeSpan interval = clickTimes[i] - clickTimes[i - 1];
                string intervalString = string.Format(@"Click {0:00} -- {1:ss\.ff}",
                    i, interval);
                timeList.Items.Add(intervalString);
            }

            this.Show();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if (RestartGame != null)
            {
                RestartGame(this, EventArgs.Empty);
            }
        }
    }
}
