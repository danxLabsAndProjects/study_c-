using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class MersedesWheel : Wheel
    {
        private int diameter;

        public override int Diameter
        {
            get { return this.diameter; }
        }

        public MersedesWheel()
        {
            this.diameter = 21;
        }
    }
}
