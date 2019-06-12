using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore.Products
{
    public class SlicedHam : BaseProduct
    {
        public SlicedHam(ProductCode pProductCode) : base(pProductCode)
        {
            packTypes.Add(5, 4.49);
            packTypes.Add(3, 2.99);
        }
    }
}
