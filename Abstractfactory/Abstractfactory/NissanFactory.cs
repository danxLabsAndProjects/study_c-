using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class NissanFactory : Factory
    {
        public override Body CreateBody()
        {
            return new NissanBody();
        }

        public override Motor CreateMotor()
        {
            return new NissanMotor();
        }

        public override Wheel CreateWheel()
        {
            return new NissanWheel();
        }
    }
}
