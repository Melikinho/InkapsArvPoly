using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Hedgehog : Animal
    {

        public int NrOfSpikes { get; set; }

        public Hedgehog(string Name, int Age, double Weight, int nrOfSpikes) : base(Name, Age, Weight)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("SONICCCCC! ");
        }
        public override string Stats() => $"{base.Stats()}  pikes: {NrOfSpikes}";
    }
}