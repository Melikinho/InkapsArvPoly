using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Swan : Bird
    {
        public bool IsAggressive
        {
            get;
            set;
        }

        public Swan(string Name, int Age, double Weight, bool IsAggressive) : base(Name, Age, Weight)
        {
            return;

        }



    }
}
