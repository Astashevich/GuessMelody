using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FGame : Form
    {
        Random random = new Random();

        private int musicDuration;

        public FGame()
        {
            InitializeComponent();
        }

        private void MakeMusic()
        {
            if (Victorina.MusicList.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.MusicDuration;
                int number = random.Next(0, Victorina.MusicList.Count() - 1);
                WMP.URL = Victorina.MusicList[number];
                Victorina.MusicList.RemoveAt(number);
                progressBar1.Value = 0;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            labelSongCounter.Text = Convert.ToString(Convert.ToInt32(labelSongCounter.Text) - 1);
            MakeMusic();
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void FGame_Load(object sender, EventArgs e)
        {
            labelSongCounter.Text = Victorina.MusicList.Count.ToString();
            progressBar1.Maximum = Victorina.GameDuration;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void PauseGame() 
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                PauseGame();
                if (MessageBox.Show("Правильный ответ?", "Игрок 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelCounter1.Text = Convert.ToString(Convert.ToInt32(labelCounter1.Text) + 1);
                }
            }
            if (e.KeyData == Keys.P)
            {
                PauseGame();
                if (MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    labelCounter2.Text = Convert.ToString(Convert.ToInt32(labelCounter2.Text) + 1);
                }
            }
        }
    }
}
