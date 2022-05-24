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
        public bool WolfLikesChicken
        {
            get;
            set;
        }
        public override void DoSound()
        {
            Console.WriteLine("Aoouuuuuwwwwwwwww!!! ");
        }

        public override string Stats() => $"{base.Stats()} Likes Chicken: {WolfLikesChicken}";

        public Wolf(string Name, int Age, double Weight, bool wolfLiksChicken) : base(Name, Age, Weight)
        {
            WolfLikesChicken = wolfLiksChicken;

        }
    }
}
