using System;
using System.Collections.Generic;
using System.Text;

namespace CS21
{
    class Customer
    {
        public string FirstName;
        public string LastName;

        //コンストラクタ
        public Customer(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;
        }

        public Customer(string lastName) : this("--", lastName)
        {

        }

        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
