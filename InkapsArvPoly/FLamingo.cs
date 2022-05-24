using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Flamingo : Bird
    {


        public Flamingo(string Name, int Age, double Weight, bool FlamingoIsAGoodSwimmer) : base(Name, Age, Weight, FlamingoIsAGoodSwimmer)
        {

        }

        public bool FlamingoIsAGoodSwimmer { get; set; }

    }
}
