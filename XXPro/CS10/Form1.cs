using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 切り捨て
            double d1 = 1.4d;
            int aaa = (int)d1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intvalue = int.Parse(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "10";
            int intValue;
            //正しく変換されたらTrue
            bool result = int.TryParse(value, out intValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = "10";
            // null の場合は0になる
            int intvalue = Convert.ToInt32(value);
        }
    }
}
