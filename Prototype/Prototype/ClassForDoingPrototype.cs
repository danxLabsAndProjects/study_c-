using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ClassForDoingPrototype
    {
        public int Param = 7;
        public string StringParam = "opa";
        public InnerClass ClassParam = new InnerClass();

        public override string ToString()
        {
            string result = $"Param  = {this.Param}, StringParam = {this.StringParam}, ClassParam = {this.ClassParam.InenrParam}";
            return result;
        }
    }
}
