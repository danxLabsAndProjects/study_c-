using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAbstractFactory
{
    class MercedesBody : IBody
    {
        private int level;

        public int Level
        {
            get { return this.level; }
        }

        public MercedesBody()
        {
            this.level = 7;
        }
    }
}
