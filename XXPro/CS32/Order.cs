using System;
using System.Collections.Generic;
using System.Text;

namespace CS32
{
    class Order : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("発注テーブル保存");
        }
    }
}
