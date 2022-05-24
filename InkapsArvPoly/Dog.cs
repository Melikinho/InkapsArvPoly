using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Dog : Animal
    {
        bool DogLikesToWalkInTheForest = true;
        public bool WalkingInTheForest
        {
            get { return WalkingInTheForest; }
            set { WalkingInTheForest = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("Voff Voff! Voff Voff!!!");
        }

        public Dog(string Name, int Age, double Weight) : base(Name,Age,Weight)
        {

        }

        public override string Stats() => $"{base.Stats}";
    }
}
