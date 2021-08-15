using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class Client
    {
        private Creator creator;
        
        public Client(Creator creator)
        {
            this.creator = creator;
        }
        public void Execute()
        {
            var product = creator.GetProduct();
            var productResult = product.Operation();

            Console.WriteLine(productResult);
        }

    }
}
