﻿using ProjectConservatoire.vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConservatoire
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            PageLogin pageLog = new PageLogin();
            pageLog.Show();

        }
    }
}