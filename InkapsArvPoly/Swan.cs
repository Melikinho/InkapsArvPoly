using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Swan : Bird
    {
        bool IsAggresive = true;

        public Swan(string Name, int Age, double Weight) : base(Name, Age, Weight)
        {
        }

        public bool Aggressive
        {
            get { return IsAggresive; }
            set { IsAggresive = value; }
        }

    }
}
