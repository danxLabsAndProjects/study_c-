using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1, product2;
            Creator creator = new ConcerteCreator();
            product1 = creator.FactoryMethod();
            product2 = creator.FactoryMethod();

            Console.ReadKey();
        }
    }
}
