using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    abstract class Factory
    {
        public abstract Wheel CreateWheel();
        public abstract Motor CreateMotor();
        public abstract Body CreateBody();

    }
}
