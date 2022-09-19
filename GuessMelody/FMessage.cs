using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FMessage : Form
    {
        private int timeAnswer;

        public FMessage()
        {
            InitializeComponent();
        }

        private void FMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 10;
            timer1.Start();
            labelShowAnswer.Text = "Показать ответ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            labelTimer.Text = timeAnswer.ToString();
            if (timeAnswer <= 0) {
                timer1.Stop();
                SoundPlayer soundPlayer = new SoundPlayer("Resources\\mixkit-arcade-retro-game-over-213.wav");
                soundPlayer.Play();
            }
        }

        private void FMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void labelShowAnswer_Click(object sender, EventArgs e)
        {
            labelShowAnswer.Text = Victorina.Answer;
        }
    }
}
