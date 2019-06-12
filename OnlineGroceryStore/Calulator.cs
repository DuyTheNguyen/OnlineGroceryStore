using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packs = System.Collections.Generic.SortedList<int, double>;


namespace OnlineGroceryStore.Products
{
    class Calulator
    {
        public Calulator()
        {
        }


        public void Calculate(int amount, BaseProduct product)
        {


            Packs filtedPack = FiltThePacksWithAmount( amount, product.getCopyOfPackTypes());

            // Return if could not get the filted pack.
            if (filtedPack.Count == 0) {
                Console.WriteLine("Could not get the order of " + product.ProductCode + " with " + amount + " pack(s)\n");
                return;
            }

            string result = "";
            
            int originalAmount = amount;
            int currentAmount;
            double price = 0;

            foreach (var kvp in filtedPack.Reverse())
            {
                if (amount < kvp.Key) continue; // continue with the next pack's type if the amount is greater than the current pack's type.
                
                currentAmount = amount / kvp.Key; // Get the amount for current pack's type.
                amount = amount % kvp.Key; // get the remaining amount.
                price += currentAmount * kvp.Value; // calculate the total price.
            
                result += " " + currentAmount + " x " + kvp.Key + " $" + kvp.Value + "\n";

                if (amount == 0) break; // Break the loop if there is no amount left.
            }

            Console.WriteLine(originalAmount + " " + product.ProductCode + " $" + price);
            Console.WriteLine(result);
        }
        
        private Packs FiltThePacksWithAmount(int amount, Packs packs)
        {
            while (packs.Count > 0)
            {
                int originalAmount = amount; // Keep the original amount for each loop

                foreach (var pack in packs.Reverse())
                {
                    if (originalAmount % pack.Key == 0) return packs; // Return the packs when there is no amount left.

                    originalAmount = originalAmount % pack.Key; // Get the remaining amount.
                }

                packs.RemoveAt(packs.Count - 1); // Remove the last element of the list. 
            }

            return packs;//This is an empty pack
        }
    }
}
