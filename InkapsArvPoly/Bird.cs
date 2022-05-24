using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Bird : Animal
    {
        bool iCanFly = true;
        bool flyingBird
        {
            get { return iCanFly; }
            set { iCanFly = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Pip pip pip pip pip");
        }

        public override string Stats() => $"{base.Stats}";

        public Bird(string Name, int Age, double Weight) : base(Name, Age, Weight)
        {
            iCanFly = flyingBird;
        }
    }
}
