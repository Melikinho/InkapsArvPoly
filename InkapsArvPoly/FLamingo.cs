using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Flamingo : Bird
    {


        public Flamingo(string Name, int Age, double Weight, bool FlamingoIsAGoodSwimmer = false) : base(Name, Age, Weight)
        {
            return;
        }

        public bool FlamingoIsAGoodSwimmer { get; set; }

    }
}
