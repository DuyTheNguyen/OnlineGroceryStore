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
                Console.WriteLine("\n\n***************************************** Welcome To Online Grocery Store *****************************************");
                Console.WriteLine("\nPlease enter your amount and code(optional) for Sliced Ham, Yoghurt and Toilet Rolls respectively: (Enter -1 to exit)");
                Console.WriteLine("\n*Note: The amount and code are seperated by a space. Ex: 12 SH3");
                Console.WriteLine("\n");
                
                ProductFactory productFactory = new ProductFactory();

                BaseProduct slicedHam = productFactory.Create(ProductCode.SH3);
                BaseProduct yoghurt = productFactory.Create(ProductCode.YT2);
                BaseProduct toiletRolls = productFactory.Create(ProductCode.TR);


                Calculator calculator = new Calculator();

                input1 = Console.ReadLine();
                if(input1.Equals("-1")) break;

                input2 = Console.ReadLine();
                if(input2.Equals("-1")) break;

                input3 = Console.ReadLine();
                if(input3.Equals("-1")) break;
                

                Console.WriteLine("\n------------------ Your Order ------------------");
                calculator.Calculate(TrimString(input1), slicedHam);
                calculator.Calculate(TrimString(input2), yoghurt);
                calculator.Calculate(TrimString(input3), toiletRolls);


            } while (true);
        }

        /// <summary>
        /// Return the amount of order
        /// </summary>
        private static int TrimString(String input){
            String[] splitString;
            splitString = input.Split(' ');
            return Int32.Parse(splitString[0]);
        }
    }
}
