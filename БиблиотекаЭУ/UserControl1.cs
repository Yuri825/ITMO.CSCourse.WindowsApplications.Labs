﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БиблиотекаЭУ
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        //public bool TimeEnabled
        //{
        //    get { return timer1.Enabled; }
        //    set { timer1.Enabled = value; }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
