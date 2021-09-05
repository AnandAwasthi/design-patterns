using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildHouseWithPool()
        {
            builder.Wall();
            builder.Ceiling();
            builder.Floor();
            builder.Pool();
        }

        public void BuildHouseWithGardenAndPool()
        {
            builder.Wall();
            builder.Ceiling();
            builder.Floor();
            builder.Pool();
            builder.Garden();
        }

        public void BuildHouseWithFountain()
        {
            builder.Wall();
            builder.Ceiling();
            builder.Fountain();
           
        }

    }
}
