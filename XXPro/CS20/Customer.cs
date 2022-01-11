using System;
using System.Collections.Generic;
using System.Text;

namespace CS20
{
    class Customer
    {
        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            return LastName + FirstName;
        }
    }
}
