﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var counter = new Counter();
            counter.Call();
        }
    }
}
