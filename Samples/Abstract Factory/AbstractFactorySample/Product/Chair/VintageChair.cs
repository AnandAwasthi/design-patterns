using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample.Product.Chair
{
    public class VintageChair : IChair
    {
        public string Sit()
        {
            return "Sit on Vintage Chair";
        }
    }
}
