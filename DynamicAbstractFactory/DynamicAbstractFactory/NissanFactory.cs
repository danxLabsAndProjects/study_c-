using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class NissanFactory : IAbstractFactory
    {
        public dynamic Make(Parts part)
        {
            string name = GetType().Namespace + ".Nissan" + part;
            return Activator.CreateInstance(Type.GetType(name));
        }
    }
}
