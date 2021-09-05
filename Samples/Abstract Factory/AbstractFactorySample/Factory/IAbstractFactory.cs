
using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactorySample.Product.Chair;
using AbstractFactorySample.Product.Sofa;

namespace AbstractFactorySample.Factory
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
