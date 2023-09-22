using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            countdownlabel.Text = "Game Starting";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            SoundPlayer hornPlayer = new SoundPlayer(Properties.Resources.Horn);
            // Hide the button when it's clicked
            startbutton.Visible = false;
            secretbutton.Visible = false;
            countdownlabel.Text = "Game Starting";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting.";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting..";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting...";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting.";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting..";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "Game Starting...";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "3";
            Refresh();
            Thread.Sleep(1000);
            countdownlabel.Text = "2";
            Refresh();
            Thread.Sleep(1000);
            countdownlabel.Text = "1";
            Refresh();
            hornPlayer.Play();
            Thread.Sleep(800);
            this.BackColor = Color.Green;
            countdownlabel.Text = "Go!";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the button when it's clicked
            secretbutton.Visible = false;
            startbutton.Visible = false;
            countdownlabel.Text = "You Found The Secret Button!";
            Refresh();
            Thread.Sleep(1500);
            countdownlabel.Text = "You get.";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "You get..";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "You get...";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "You get.";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "You get..";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "You get...";
            Refresh();
            Thread.Sleep(300);
            countdownlabel.Text = "A  Cookie";
            Refresh();
            Thread.Sleep(700);
        }
    }
}
