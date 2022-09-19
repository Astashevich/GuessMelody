using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FGame : Form
    {
        Random random = new Random();
        FMessage message = new FMessage();
        SoundPlayer soundPlayer1 = new SoundPlayer("Resources\\1.wav");
        SoundPlayer soundPlayer2 = new SoundPlayer("Resources\\2.wav");

        private int musicDuration;
        private int gameDuration;

        public FGame()
        {
            InitializeComponent();
        }

        private void MakeMusic()
        {
            if (Victorina.MusicList.Count == 0) EndGame();
            else
            {
                int number = random.Next(0, Victorina.MusicList.Count() - 1);
                WMP.URL = Victorina.MusicList[number];
                Victorina.Answer = Path.GetFileNameWithoutExtension(WMP.URL);
                Victorina.MusicList.RemoveAt(number);
                progressBar1.Value = 0;
                buttonPause.Enabled = true;
                buttonContinue.Enabled = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            labelSongCounter.Text = Convert.ToString(Convert.ToInt32(labelSongCounter.Text) - 1);
            gameDuration--;
            MakeMusic();
            buttonNext.Text = "Следующая";
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void FGame_Load(object sender, EventArgs e)
        {
            buttonNext.Text = "Начать";
            buttonPause.Enabled = false;
            buttonContinue.Enabled = false;

            musicDuration = Victorina.MusicDuration;
            gameDuration = Victorina.GameDuration;
            labelSongCounter.Text = gameDuration.ToString();
            progressBar1.Maximum = musicDuration;
            labelP1.Text = Victorina.P1;
            labelP2.Text = Victorina.P2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                buttonPause.Enabled = false;
                buttonContinue.Enabled = false;
                return;
            }
            if (gameDuration <= 0)
            {
                buttonNext.Enabled = false;
                return;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            ContinueGame();
        }

        private void PauseGame() 
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void ContinueGame()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (e.KeyData == Keys.A)
            {
                PauseGame();
               
                soundPlayer1.PlaySync();
                message.labelMessage.Text = Victorina.P1;
                if (message.ShowDialog() == DialogResult.Yes)
                {
                    labelCounter1.Text = Convert.ToString(Convert.ToInt32(labelCounter1.Text) + 1);
                }
            }
            if (e.KeyData == Keys.P)
            {
                PauseGame();
                soundPlayer2.PlaySync();
                message.labelMessage.Text = Victorina.P2;
                if (message.ShowDialog()== DialogResult.Yes)
                {
                    labelCounter2.Text = Convert.ToString(Convert.ToInt32(labelCounter2.Text) + 1);
                }
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.RandomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration - musicDuration);
        }

        private void labelCounter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
