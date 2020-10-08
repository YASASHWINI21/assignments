using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_in_one_windows_form
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
            b.Size = new Size(50, 50);
            b.Location = new Point(200, 150);
            this.Controls.Add(b);
            b.Click += new EventHandler(Button1_click1);
            b.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("Programming is Fun");
            };
            b.Click += delegate (object sender3, EventArgs e3)
            {
                MessageBox.Show("This is printing");
            };
            b.Click += delegate (object sender4, EventArgs e4)
            {
                MessageBox.Show("This is printing again");
            };
            b.Click += delegate (object sender5, EventArgs e5)
            {
                MessageBox.Show("Yeyy! This is Creazy");
            };
            b.Click += delegate (object sender6, EventArgs e6)
            {
                MessageBox.Show("Yeyy!This is printing crazy");
            };

        }
        private void Button1_click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("Hello World");
        }
    }
}
