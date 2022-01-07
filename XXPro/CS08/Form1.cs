using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            byte bytevalue = 255;

            short shotvalue = 10;
            short shortmax = short.MaxValue;

            //マイナス無
            //ushort ushortvalue = -1;

            int intValue = 10;

            float floatvalue = 1.2345f;

            decimal decimalValue = 1.2345m;

            string stringValue = "sdfsd";
        }
    }
}
