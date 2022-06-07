using System;

namespace Homework060622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market(20);
            string opt;
            do
            {
                Console.WriteLine("1.Product elave et.");
                Console.WriteLine("2.Product sat.");
                Console.WriteLine("3.Productlara bax.");
                Console.WriteLine("4.Menudan cix.");

                Console.WriteLine("\n Emeliyyati secin");
                opt=Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        AddProduct(market);
                        break;

                    case "2":
                        SellProduct(market);

                        break;
                    case "3":
                        ShowProduct(market);
                        break;

                        case "4":
                        break;

                        default:
                        Console.WriteLine("Yanlis secim etdiniz");
                        break;
                }



            } while(opt!=4);


        }
        static Product GetProduct()
        {
            Console.WriteLine("Mehsulun nomresini daxil et:");
            string no= Console.ReadLine();


            string countStr;
            int count;
            do
            {
                Console.WriteLine("Mehsulun sayini daxil edin:");
                 countStr = Console.ReadLine();

            } while (!int.TryParse(countStr, out count) || count < 0);

            string priceStr;
            double price;
            do
            {
                Console.WriteLine("Mwhsulun qiymetini daxil edin:");
                priceStr = Console.ReadLine();
                

            }while (!double.TryParse(countStr, out price) || price < 0);


            Product product = new Product
            {
                No = no,
                Name = name,
                Count = count,
                Price = price

            };
            return product;


        }
        
         static string GetProductNoFromConsole()
        {
            Console.WriteLine("Satmaq isdediyiniz mehsul nomresini daxil edin");
            string no=Console.ReadLine();
            return no;  
        }

        static void AddProduct(Market market)
        {
            try
            {
                Product product = GetProduct();
                market.AddProduct(product);
            }
            catch (ProductLimitIsFilledException exp)
            {
                Console.WriteLine(exp.Message);

            }
            catch (ProductIsExistException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmedik bir xeta");
            }

            
        }

        static void SellProduct(Market market)
        {
            string no = GetProductNoFromConsole();
            try
            {
                market.SellProduct(no);
            }
            catch (ProductNotFoundException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (ProductStockCountException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmedik xeta.");
            }
        }
        static void ShowProduct(Market market)
        {
            foreach(Product product in market.Products)
            {
                product.ShowInfo();
            }
        }
    }
}
