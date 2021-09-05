using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactorySample.Product.Chair;
using AbstractFactorySample.Product.Sofa;

namespace AbstractFactorySample.Factory
{
    public class VintageFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VintageChair();
        }

        public ISofa CreateSofa()
        {
            return new VintageSofa();
        }
    }
}
