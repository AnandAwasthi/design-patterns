﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class ProductA : IProduct
    {
        public string Operation()
        {
            return "Operation from ProductA";
        }
    }
}
