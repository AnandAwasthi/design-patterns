using AbstractFactorySample.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    public class Client
    {

        public void Main()
        {
            Console.WriteLine("When Client need Modern furniture");
            var modernFactory = new ModernFactory();
            ClientMethod(modernFactory);
            Console.WriteLine();

            Console.WriteLine("When Client need Vintage furniture");
            var vintageFactory = new VintageFactory();
            ClientMethod(vintageFactory);
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory abstractFactory)
        {
            var chair = abstractFactory.CreateChair();
            var sofa = abstractFactory.CreateSofa();

            Console.WriteLine(chair.Sit());
            Console.WriteLine(sofa.Sit());
        }

    }

}
