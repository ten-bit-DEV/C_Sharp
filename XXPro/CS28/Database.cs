using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS28
{
    public class Database:IDisposable
    {
        private SqlDataAdapter _adapter = new SqlDataAdapter();

        public void Dispose()
        {
            if (_adapter != null)
            {
                _adapter.Dispose();
            }
        }

        public void Insert()
        {
            //SqlConnection connection = new SqlConnection();
            //try
            //{
            //    connection.Open();
            //    //処理
            //}
            //finally
            //{
            //    connection.Dispose();   
            //}

            using(SqlConnection connection = new SqlConnection())
            {
                //処理
            }
        }
    }
}
