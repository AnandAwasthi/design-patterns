using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample.Product.Sofa
{
    public class VintageSofa : ISofa
    {
        public string Sit()
        {
            return "Sit on Vintage Sofa";
        }
    }
}
