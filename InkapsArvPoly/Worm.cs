using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Worm : Animal
    {
        bool isPoisonious = true;
        public bool Poisonious
        {
            get { return isPoisonious; }
            set { isPoisonious = value; }
        }
        public override void DoSound()
        {
            Console.WriteLine("Psssssttttt");
        }

        public override string Stats() => $"{base.Stats}";
        public Worm(String Name, int Age, double Weight) : base(Name, Age, Weight)
        {
            isPoisonious = isPoisonious;
        }
    }
}
