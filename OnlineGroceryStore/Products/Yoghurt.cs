using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Products
{
    class Yoghurt : BaseProduct
    {
        public Yoghurt(ProductCode pProductCode) : base(pProductCode)
        {
            packTypes.Add(4, 4.95);
            packTypes.Add(15, 13.95);
            packTypes.Add(10, 9.95);
        }
    }
}
