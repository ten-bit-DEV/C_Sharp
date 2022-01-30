using System;
using System.Collections.Generic;
using System.Text;

namespace CS32
{
    public class Product : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
