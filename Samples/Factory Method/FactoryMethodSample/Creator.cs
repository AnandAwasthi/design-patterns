using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public abstract class Creator
    {
        public abstract IProduct GetProduct();
    }
}
