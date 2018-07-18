using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new MersedesFactory());
            client.WhatCarIsIt();
            client = new Client(new NissanFactory());
            client.WhatCarIsIt();

            Console.ReadKey();
        }
    }
}
