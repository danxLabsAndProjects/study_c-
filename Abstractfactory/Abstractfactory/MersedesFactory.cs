using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class MersedesFactory : Factory
    {
        public override Body CreateBody()
        {
            return new MersedesBody();
        }

        public override Motor CreateMotor()
        {
            return new MersedesMotor();
        }

        public override Wheel CreateWheel()
        {
            return new MersedesWheel();
        }
    }
}
