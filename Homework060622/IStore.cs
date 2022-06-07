using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622
{
    public interface IStore
    {
        Product[] Products { get; }
        int ProductLimit { get; set; }
        double TotalIncome { get; }

        void AddProduct(Product Products);
        void SellProduct(string no);


    }
}
