using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class ProductBCreator : Creator
    {
        public override IProduct GetProduct()
        {
            return new ProductB();
        }
    }
}
