using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scaryMaze
{
    public partial class Scare : Form
    {
        public Scare()
        {
            InitializeComponent();

            //make this form full screen
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            //play the scart sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.scare;
            player.Play();//play this once
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
