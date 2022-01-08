using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> values = new List<int>();

            //追加
            values.Add(10);
            values.Add(20);
            values.Add(30);

            //要素数
            values.Count();
            MessageBox.Show(values.Count.ToString());

            //値参照
            MessageBox.Show(values[1].ToString());

            //値指定
            values.Remove(20); //値が20のインデックスを消す

            //インデックス指定
            values.RemoveAt(1); //1番目のインデックスを消す

            //全消去
            values.Clear();
        }
    }
}
