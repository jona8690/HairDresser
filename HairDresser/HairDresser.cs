using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairDresser
{
    class HairDresser
    {
        public Scissors left { get; set; }
        public Scissors right { get; set; }

        public HairDresser(Scissors left, Scissors right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
