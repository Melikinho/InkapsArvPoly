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

        public override string DoSound()
        {
            return "Voff Voff! Voff Voff!!!";
        }
        public Dog(string Name, int Age, double Weight)
        {
            return;
        }
        public override void Stats(string Name, int Age, double Weight)
        {
            base.Stats(Name, Age, Weight);
        }
    }
}
