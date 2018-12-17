using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype();
            ClassForDoingPrototype prot = prototype.Clone() as ClassForDoingPrototype;
            Console.WriteLine(prot.ToString());
            ClassForDoingPrototype prot2 = prototype.Clone() as ClassForDoingPrototype;
            prot2.StringParam = "opa2";
            prot2.Param = 10;
            prot2.ClassParam = new InnerClass { InenrParam = 111 };// if only change param value first prot changed to;
            Console.WriteLine(prot2.ToString());
            Console.WriteLine(prot.ToString());
            Console.ReadKey();
        }
    }
}
