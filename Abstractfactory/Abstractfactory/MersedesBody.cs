using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class MersedesBody : Body
    {
        private int level;

        public override int Level
        {
            get { return level; }
        }

        public MersedesBody()
        {
            level = 5;
        }
    }
}
