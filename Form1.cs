using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
namespace CamAm
{
    public partial class Form1 : Form
    {      
        private System.Media.SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            player.Stream = CamAm.Properties.Resources.宮1_01;
            player.Play();
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            player.Stream = CamAm.Properties.Resources.商2_01;
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stream = CamAm.Properties.Resources.角3_01;
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Stream = CamAm.Properties.Resources.徵4_01;
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stream = CamAm.Properties.Resources.羽5_01;   
            player.Play();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
        }
    }
}
