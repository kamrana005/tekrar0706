using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622.Exception
{
    public class ProductStockCountException : Exception
    {
        public ProductStockCountException(string msg) : base(msg)
        {

        }


    }
}
