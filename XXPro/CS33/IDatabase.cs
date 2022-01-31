using System;
using System.Collections.Generic;
using System.Text;

namespace CS33
{
    public abstract class Database
    {
        void Save()
        {
            Before();

            Execute();

            After();
        }

        protected abstract void Execute();

        private void Before()
        {

        }

        private void After()
        {

        }
    }
}
