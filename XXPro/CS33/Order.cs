using System;
using System.Collections.Generic;
using System.Text;

namespace CS33
{
    class Order : Database
    {
        public void Save()
        {
            Console.WriteLine("発注テーブル保存");
        }

        protected override void Execute()
        {
            Console.WriteLine("発注テーブル保存");
        }
    }
}
