using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS34
{
    public sealed class CSVReadException :Exception
    {
        public CSVReadException():base("csvの読み込みに失敗しました")
        {

        }

        public CSVReadException(Exception exception):base("csvの読み込みに失敗しました",exception)
        {

        }
    }
}
