using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp
{
    class NSFException : Exception
    {
        public NSFException() : base()
        {

        }

        public NSFException(string message) : base(message)
        {

        }
    }
}
