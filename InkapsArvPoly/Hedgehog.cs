using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpikes;

        public int TotalNumOfSpikes
        {
            get { return NrOfSpikes; }
            set { NrOfSpikes = value; }
        }
        public override string DoSound()
        {
            return "SSSONICCCCCC!";
        }
    }
}
