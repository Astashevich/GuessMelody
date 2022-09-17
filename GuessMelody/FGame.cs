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

        public FGame()
        {
            InitializeComponent();
        }

        private void MakeMusic()
        {
            int number = random.Next(0, Victorina.MusicList.Count() - 1);
            WMP.URL = Victorina.MusicList[number];
            Victorina.MusicList.RemoveAt(number);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }
    }
}
