﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (Database db = new Database())
            {
                //処理
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
