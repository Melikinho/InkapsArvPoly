using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Worm : Animal
    {
        public bool IsPoisonious
        {
            get;
            set;
        }
        public override void DoSound()
        {
            Console.WriteLine("Psssssttttt");
        }

        public override string Stats() => $"{base.Stats()} Is Poisonious: {IsPoisonious}";
        public Worm(String Name, int Age, double Weight, bool isPoisonious) : base(Name, Age, Weight)
        {
            IsPoisonious = isPoisonious;
        }
    }
}