using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Products
{
    class ToiletRolls : BaseProduct
    {
        public ToiletRolls(ProductCode pProductCode) : base(pProductCode)
        {
            packTypes.Add(9, 7.99);
            packTypes.Add(5, 4.45);
            packTypes.Add(3, 2.95);
        }
    }
}
