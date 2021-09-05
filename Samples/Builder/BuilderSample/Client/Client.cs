using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    public class Client
    {
        public void Main()
        {
            Director director = new Director();
            var houseBuilder = new Builder();

            DoWork(director, houseBuilder);
        }

        public void DoWork(Director director, IBuilder builder)
        {
            director.Builder = builder;

            Console.WriteLine("Build House With Pool");
            director.BuildHouseWithPool();

            Console.WriteLine(builder.GetProduct());


            Console.WriteLine("Build House With Fountain");
            director.BuildHouseWithFountain();

            Console.WriteLine(builder.GetProduct());

            Console.WriteLine("Build House With Pool & Garden");
            director.BuildHouseWithGardenAndPool();

            Console.WriteLine(builder.GetProduct());
        }
    }
}
