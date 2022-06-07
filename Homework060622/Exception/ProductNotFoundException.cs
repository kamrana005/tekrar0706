using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622.Exception
{
    public class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string msg) : base(msg);

    }
}
