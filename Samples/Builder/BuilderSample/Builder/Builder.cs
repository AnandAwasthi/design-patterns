using BuilderSample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    public class Builder : IBuilder
    {
        private House _house = new House();

        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._house = new House();
        }
        public void Ceiling()
        {
            _house.Add("Ceiling");
        }

        public void Floor()
        {
            _house.Add("Floor");
        }

        public void Fountain()
        {
            _house.Add("Fountain");
        }

        public void Garden()
        {
            _house.Add("Garden");
        }

        public void Pool()
        {
            _house.Add("Pool");
        }

        public void Wall()
        {
            _house.Add("Wall");
        }

        public string GetProduct()
        {
            return _house.Execute();
        }
    }
}
