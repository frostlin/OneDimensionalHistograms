using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histogramms
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonMicrophoneClick(object sender, EventArgs e)
        {
            Audio audioForm = new Audio("microphone", "");
            audioForm.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonWav_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Audio audioForm = new Audio("wav", openFileDialog1.FileName);
                audioForm.Show();
            }
        }

        private void buttonMp3_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Audio audioForm = new Audio("mp3", openFileDialog1.FileName);
                audioForm.Show();
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Rand randForm = new Rand();
            randForm.Show();
        }
    }
}
