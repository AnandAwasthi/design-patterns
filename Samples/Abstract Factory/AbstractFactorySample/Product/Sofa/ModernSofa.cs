using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample.Product.Sofa
{
    public class ModernSofa : ISofa
    {
        public string Sit()
        {
            return "Sit on Modern Sofa";
        }
    }
}
