using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class MercedesMotor : IMotor
    {
        private int power;

        public int Power
        {
            get { return this.power; }
        }

        public MercedesMotor()
        {
            this.power = 600;
        }
    }

}
