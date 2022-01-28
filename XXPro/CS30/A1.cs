using System;
using System.Collections.Generic;
using System.Text;

namespace CS30
{
    class A1
    {
        private int _privatevalue;
        protected int Protectedvalue;

        public A1(int value)
        {
            _privatevalue = value;
        }

        public int GetData()
        {
            return 100;
        }
    }
}
