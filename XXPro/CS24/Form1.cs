using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS24
{
    public partial class Form1 : Form
    {
        private int _value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetData()
        {

            //型推論
            //ローカル変数のみ可
            var aaa = new List<int>();
            var value = false;
        }
    }
}
