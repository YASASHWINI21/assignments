﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "click button";
            b.Size = new Size(100, 50);
            b.Location = new Point(250, 150);
            this.Controls.Add(b);
            b.Click += new EventHandler(button1_click1);

        }
        private void button1_click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("This is printing Again");
        }
    }
}
