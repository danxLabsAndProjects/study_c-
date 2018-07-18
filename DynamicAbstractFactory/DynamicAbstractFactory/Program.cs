using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car nissan = new Car(Factories.NissanFactory);
            nissan.WhatCarIsIt();
            Car mercedes = new Car(Factories.MercedesFactory);
            mercedes.WhatCarIsIt();

            Console.ReadKey();
        }
    }
}
