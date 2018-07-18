﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcereteBuilder : AbstractBuilder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product ResultProduct()
        {
            return product;
        }
    }
}