﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Design
{
    public partial class Test : Form
    {
        public Test()
        {
            //initalize
            InitializeComponent();
        }

        private void UserClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
