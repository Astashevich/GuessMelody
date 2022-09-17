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
    public partial class FMain : Form
    {
        private readonly FParams fParams = new FParams();
        private readonly FGame fGame = new FGame();

        public FMain()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            fGame.ShowDialog();
        }

        private void buttonParams_Click(object sender, EventArgs e)
        {
            fParams.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
