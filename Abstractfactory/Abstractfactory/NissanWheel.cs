using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class NissanWheel : Wheel
    {
        private int diametr;

        public override int Diameter
        {
            get { return this.diametr; }
        }

        public NissanWheel()
        {
            diametr = 25;
        }
    }
}
