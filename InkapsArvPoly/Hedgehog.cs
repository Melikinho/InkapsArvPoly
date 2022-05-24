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

        public Hedgehog(string Name, int Age, double Weight) : base(Name, Age, Weight)
        {
            NrOfSpikes = TotalNumOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("SONICCCCC! ");
        }
        public override string Stats() => $"{base.Stats}" + " Spikes: {TotalNumOfSpikes}";


    }
}