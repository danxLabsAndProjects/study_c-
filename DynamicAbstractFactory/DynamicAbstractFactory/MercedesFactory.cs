using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class MercedesFactory : IAbstractFactory
    {
        public dynamic Make(Parts part)
        {
            string name = GetType().Namespace + ".Mercedes" + part;
            return Activator.CreateInstance(Type.GetType(name));
        }
    }
}
