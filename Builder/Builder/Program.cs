using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcereteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.ResultProduct();
            product.ShowParts();
           
            Console.ReadKey();

        }
    }
}
