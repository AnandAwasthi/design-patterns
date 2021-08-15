using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            Console.WriteLine("When client need Product A");
            var productAInstance = new ProductACreator();
            client = new Client(productAInstance);
            client.Execute();

            Console.WriteLine("When client need Product B");
            var productBInstance = new ProductBCreator();
            client = new Client(productBInstance);
            client.Execute();

            Console.ReadLine();

        }
    }
}
