using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcerteProduct : Product
    {
        private int id;
        public int ID
        {
            get { return this.id; }
        }

        public ConcerteProduct()
        {
            this.id = new Random().Next();
            Console.WriteLine($"Id of this prod{this.ID}");
        }
    }
}
