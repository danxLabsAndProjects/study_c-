using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class MercedesWheel : IWheel
    {
        private int diameter;

        public int Diametr
        {
            get { return this.diameter; }
        }

        public MercedesWheel()
        {
            this.diameter = 23;
        }
    }
}
