using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineGroceryStore.Products;

namespace OnlineGroceryStore
{
    class MainClass
    {
        static void Main(string[] args)
        {
            String input1;
            String input2;
            String input3;
           
            do
            {
                Console.WriteLine("\n\n******************** Welcome To Online Grocery Store ********************");
                Console.WriteLine("\nPlease enter your product's amount and code: (Enter -1 to exit)\n");

                ProductFactory pFactory = new ProductFactory();

                BaseProduct slicedHam = pFactory.Create(ProductCode.SH3);
                BaseProduct yoghurt = pFactory.Create(ProductCode.YT2);
                BaseProduct toiletRolls = pFactory.Create(ProductCode.TR);


                Calulator c = new Calulator();

                input1 = Console.ReadLine();
                if(input1.Equals("-1")) break;

                input2 = Console.ReadLine();
                if(input2.Equals("-1")) break;

                input3 = Console.ReadLine();
                if(input3.Equals("-1")) break;
                
                Console.WriteLine("\n------------------ Your Order ------------------");
                c.Calculate(input1, slicedHam);
                c.Calculate(input2, yoghurt);
                c.Calculate(input3, toiletRolls);


            } while (true);
        }

       
    }
}
