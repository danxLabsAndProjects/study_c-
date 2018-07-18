using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class MersedesMotor : Motor
    {
        private int power;

        public override int Power
        {
            get { return this.power; }
        }

        public MersedesMotor()
        {
            power = 600;
        }
    }
}
