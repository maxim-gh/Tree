using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Element
    {
        public Element Right { get; set; }
        public Element Left { get; set; }
        public int Counter { get; set; }
        public int Value { get; set; }
    }
}
