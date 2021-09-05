using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    public interface IBuilder
    {
        void Wall();
        void Ceiling();
        void Floor();
        void Pool();
        void Garden();
        void Fountain();
        string GetProduct();
    }
}
