using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class NissanWheel : IWheel
    {
        private int diametr;

        public int Diametr
        {
            get { return this.diametr; }
        }

        public NissanWheel()
        {
            this.diametr = 21;
        }
    }
}
