﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            countdownlabel.Text = "Game Starting";
            Refresh();
            Thread.Sleep(3000);
            countdownlabel.Text = "3";
                Thread.Sleep(3000);
            countdownlabel.Text = "2";



        }
    }
}
