using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample.Product
{
    public class House
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string Execute()
        {
            return "House Parts Build: " + string.Join(',', _parts);
        }
    }
}
