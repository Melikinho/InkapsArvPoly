using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Horse : Animal
    {
        public bool HorseLikeToRun { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("MEhehehhuwuuuewwwww");
        }
        public override string Stats() => $"{base.Stats()} Horse likes to Run: {HorseLikeToRun}";
        public Horse(string Name, int Age, double Weight, bool horseLikeToRun) : base(Name, Age, Weight)
        {
            HorseLikeToRun = horseLikeToRun;
        }
    }
}
