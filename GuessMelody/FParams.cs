using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FParams : Form
    {
        public FParams()
        {
            InitializeComponent();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(
                    dialog.SelectedPath,
                    "*.mp3",
                    cbAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.MusicList.Clear();
                Victorina.MusicList.AddRange(music_list);
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Victorina.MusicList.Clear();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Victorina.WriteParam();
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
