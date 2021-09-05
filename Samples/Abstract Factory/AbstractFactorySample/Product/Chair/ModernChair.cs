using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample.Product.Chair
{
    public class ModernChair : IChair
    {
        public string Sit()
        {
            return "Sit on Modern Chair";
        }
    }
}
