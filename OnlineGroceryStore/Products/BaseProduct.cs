using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packs = System.Collections.Generic.SortedList<int, double>;

namespace OnlineGroceryStore.Products
{
    public abstract class BaseProduct
    {
        protected ProductCode productCode;
        ///<summary>Return the product code in String</summary>
        public String ProductCode {
            get {
                return productCode.ToString();
            }
        }

        protected Packs packTypes;
        ///<summary>Return the soreted list of number of packs and its price</summary>
        public Packs getCopyOfPackTypes()
        {
            return new Packs(packTypes);
        }

        public BaseProduct(ProductCode pProductCode) {
            productCode = pProductCode;
            packTypes = new Packs();
        }
    }
}
