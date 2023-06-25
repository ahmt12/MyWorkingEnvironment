using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter the code of the product to be added to the cart: ");
            var codeA = Console.ReadLine();
            int code1 = Convert.ToInt32(codeA);

            Console.WriteLine("If you want to add more products to your cart, press 1. If you do not want, dial 0.");
            var buttonA=Console.ReadLine();
            int button1 = Convert.ToInt32(buttonA);
            if (button1==1)
            {
                Console.WriteLine("Enter the code of the product to be added to the cart: ");
                var codeB = Console.ReadLine();
                int code2 = Convert.ToInt32(codeB);

                Console.WriteLine("If you want to add more products to your cart, press 1. If you do not want, dial 0.");
                var buttonB = Console.ReadLine();
                int button2 = Convert.ToInt32(buttonB);
                if (button2==1)
                {
                    Console.WriteLine("The last remaining product has also been added to the cart.\n");
                    Console.WriteLine("Total cart amount: {0}\n",product1.Price+product2.Price+product3.Price);
                    Console.WriteLine("The remaining amount of stock for the {0} coded product: {1}\n",product1.Code,product1.Stocks-1);
                    Console.WriteLine("The remaining amount of stock for the {0} coded product: {1}\n", product2.Code, product2.Stocks - 1);
                    Console.WriteLine("The remaining amount of stock for the {0} coded product: {1}\n", product3.Code, product3.Stocks - 1);

                }
                else if (button2==0)
                {

                }
                else
                {
                    Console.WriteLine("You pressed a wrong button.");
                }




            }
            else if (button1==0) 
            { 

            }
            else
            {
                Console.WriteLine("You pressed a wrong button.");
            }

        }
        
    }
}
