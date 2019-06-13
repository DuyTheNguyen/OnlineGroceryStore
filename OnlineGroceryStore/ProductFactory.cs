using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryStore.Products;

namespace OnlineGroceryStore
{
     public enum ProductCode
    { 
        SH3,
        YT2,
        TR
    }

    class ProductFactory
    {
        public ProductFactory()
        {
        }

        /// <summary>
        /// Create a product base on the Product Code enum
        /// </summary>
        /// <param name="pProductCode"></param>
        /// <returns>Product</returns>
        public BaseProduct Create(ProductCode pProductCode)
        {
            switch (pProductCode)
            {
                case ProductCode.SH3:
                    return new SlicedHam(pProductCode);
                case ProductCode.YT2:
                    return new Yoghurt(pProductCode);
                case ProductCode.TR:
                    return new ToiletRolls(pProductCode);
            }
            
            throw new NotSupportedException(); //Should not be here
        }


    }
}
