using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhanaWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nilai1Text.Text = "";
            nilai2Text.Text = "";
            hasilText.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(nilai1Text.Text);
            int nilai2 = int.Parse(nilai2Text.Text);
            int hasil = nilai1 + nilai2;

            hasilText.Text = hasil.ToString();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(nilai1Text.Text);
            int nilai2 = int.Parse(nilai2Text.Text);
            int hasil = nilai1 - nilai2;

            hasilText.Text = hasil.ToString();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(nilai1Text.Text);
            int nilai2 = int.Parse(nilai2Text.Text);
            int hasil = nilai1 * nilai2;

            hasilText.Text = hasil.ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(nilai1Text.Text);
            int nilai2 = int.Parse(nilai2Text.Text);
            int hasil = nilai1 / nilai2;

            hasilText.Text = hasil.ToString();
        }
    }
}
