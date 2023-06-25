using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyGroupWork1
{
    internal class ProductManager
    {


        public void Add(Product product1, Product product2, Product product3)
        {
            Console.WriteLine("Can you please write down how many products you will add to your cart? ");
            var number = Console.ReadLine();
            int number1 = Convert.ToInt32(number);

            int[] price = new int[number1];

            for (int i = 0; i < number1; i++)
            {
                Console.WriteLine("Could you please write the code of the product you will add to the cart? ");
                var code = Console.ReadLine();
                int code1 = Convert.ToInt32(code);

                if (code1 == 10)
                {
                    price[i] = product1.Price;
                    product1.Stocks=product1.Stocks-1;
                }
                else if (code1 == 11)
                {
                    price[i] = product2.Price;
                    product2.Stocks=product2.Stocks-1;
                }
                else if (code1 == 12)
                {
                    price[i] = product3.Price;
                    product3.Stocks=product3.Stocks-1;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid code.");
                }
            }

            int total_price = price.Sum();
            if (total_price >= 400)
            {
                Console.WriteLine("CONGRATULATIONS. YOU WILL NOT PAY ANY FEE FOR SHIPPING\n");
            }
            else
            {
                Console.WriteLine("To take advantage of the free shipping opportunity, add another {0} euro product to the cart.", 400 - total_price);
                Console.WriteLine("Your current basket amount is {0} euro, including the shipping fee.", total_price + 30);
            }
        }

    }
}
