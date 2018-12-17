﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ConcerteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcerteProduct();
        }
    }
}
