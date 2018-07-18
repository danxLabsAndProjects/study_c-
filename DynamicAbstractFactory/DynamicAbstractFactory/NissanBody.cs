using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class NissanBody : IBody
    {
        private int level;

        public int Level
        {
            get { return this.level; }
        }

        public NissanBody()
        {
            this.level = 3;
        }
    }
}
