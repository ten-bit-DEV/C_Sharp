using System;
using System.Collections.Generic;
using System.Text;

namespace CS33
{
    public class Product : Database
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの保存");
        }

        protected override void Execute()
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
