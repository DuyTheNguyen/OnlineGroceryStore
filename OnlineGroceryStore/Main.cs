using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineGroceryStore.Products;

namespace OnlineGroceryStore
{
    class Main
    {
        static void Main(string[] args)
        {
            String input;
            do
            {
                Console.WriteLine("Enter -1 to exit:\n");

                ProductFactory pFactory = new ProductFactory();

                BaseProduct slicedHam = pFactory.Create(ProductCode.SH3);
                BaseProduct yoghurt = pFactory.Create(ProductCode.YT2);
                BaseProduct toiletRolls = pFactory.Create(ProductCode.TR);


                Calulator c = new Calulator();

                c.Calculate(1, slicedHam);
                c.Calculate(56, yoghurt);
                c.Calculate(12, toiletRolls);

                input = Console.ReadLine();

            } while (!input.Equals("-1"));
        }
    }
}
