using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Product
    {
        List<object> PartList = new List<object>();

        public void Add(object part)
        {
            if (part != null)
            {
                PartList.Add(part);
            }
        }


        public void ShowParts()
        {
            foreach(object part in PartList)
            {
                Console.WriteLine(part.ToString());
            }
        }

    }
}
