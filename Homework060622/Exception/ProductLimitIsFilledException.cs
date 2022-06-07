using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622.Exception
{
    public class ProductLimitIsFilledException:Exception
    {
        public ProductLimitIsFilledException(string msg) : base(msg)
        {
            
        }


    }
}
