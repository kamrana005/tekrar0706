using System;
using System.Collections.Generic;
using System.Text;

namespace Homework060622.Implementation
{
    public class Market : IStore
    {
        public Market()
        {
            _products = new Product[0];
        }

        private Product[] _products;
        public Product[] Products => _products;
        private double _totalIncome;
        public int ProductLimit { get ; set ; }
        public double TotalIncome => _totalIncome;

        public void AddProduct(Product product)
        {
            if (ProductLimit <= _products.Length)
            {
                throw new ProductLimitIsFilledException($"Product limit is filled");
            }
            if FindProductbyNo(product.No)
                throw new ProductIsExistException ($"Same product already added with {product.No} no");

            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length-1] = product;
                
            }
        }

        public void SellProduct(string no)
        {

            Product product=FindProductbyNo(no);
            if (product == null)
                throw new ProductNotFoundException("There is not any product with no: {no} ");

            if (product.Count < 1)
                throw new ProductStockCountException("The product out of stock");
            
                if (product.Count > 0)
                {
                    _totalIncome += product.Price;
                    product.Count--;
                }

            
        }

        public Product FindProductbyNo(string no)
        {
            Product product = null;

            foreach(var pr in _products)
            {
                if (pr.No == no)
                {
                    product = pr;  
                    break;  
                }

            }
            return product; 
        }
    }
}
