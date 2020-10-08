using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from5
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

        }
            private void Button1_click1(object sender1, EventArgs e1)
            {
                MessageBox.Show("Yeyy! This is printing Crazy");
            }
        }
    }
