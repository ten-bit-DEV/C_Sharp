using System;
using System.Collections.Generic;
using System.Text;

namespace CS30
{
    class A2:A1
    {
        //:base()で親クラスのコンストラクタにとおす
        public A2(int value):base(value)
        {
            base.Protectedvalue = 3;
        }

        public override int GetData()
        {
            var value = base.GetData();
            value += 3;
            return value;
        }
    }
}
