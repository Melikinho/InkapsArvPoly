using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Wolf : Animal
    {
        public string MyWolf;

        bool WolfLikesChicken = true;
        public bool WolfEatsChicken
        {
            get { return WolfLikesChicken; }
        }
        public override void DoSound()
        {
            Console.WriteLine("Aoouuuuuwwwwwwwww!!! ");
        }

        public override string Stats() => $"{base.Stats}";

        public Wolf(string Name, int Age, double Weight) : base(Name, Age, Weight)
        {
            return;
        }
    }
}
