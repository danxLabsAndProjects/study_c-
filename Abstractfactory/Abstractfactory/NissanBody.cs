using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    class NissanBody : Body
    {
        private int level;

        public override int Level
        {
            get { return this.level; }
        }

        public NissanBody()
        {
            this.level = 10;
        }
    }
}
