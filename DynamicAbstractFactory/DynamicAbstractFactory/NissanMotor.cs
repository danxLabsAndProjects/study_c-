using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class NissanMotor : IMotor
    {
        private int power;

        public int Power
        {
            get { return this.power; }
        }

        public NissanMotor()
        {
            this.power = 450;
        }
    }
}
