﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new easy();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new normal();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new hard();
            newForm.Show();
        }
    }
}
