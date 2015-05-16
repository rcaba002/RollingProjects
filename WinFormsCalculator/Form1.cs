using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        string originalButtonText;
        int openCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));

            PopupForm popupForm = new PopupForm();
            popupForm.OpenCount = openCount++;
            popupForm.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
            popupForm.ShowDialog();
        }

        private void ClickMeEnter(object sender, EventArgs e)
        {
            originalButtonText = button1.Text;
            button1.Text = button1.Text.ToUpper();
        }

        private void ClickMeLeave(object sender, EventArgs e)
        {
            button1.Text = originalButtonText;
        }

        private void SelfAwareLabel_Click(object sender, EventArgs e)
        {
            selfAwareLabel.Hide();
        }

        private void OnFormDoubleClick(object sender, EventArgs e)
        {
            selfAwareLabel.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selfAwareLabel.Text = textBox1.Text.Reverse()
                .Select(x => x.ToString())
                .Aggregate((x, y) => x + y);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
