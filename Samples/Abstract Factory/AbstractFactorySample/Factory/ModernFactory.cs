using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactorySample.Product.Chair;
using AbstractFactorySample.Product.Sofa;

namespace AbstractFactorySample.Factory
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
