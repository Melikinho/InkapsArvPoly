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
            set { WolfEatsChicken = value; }
        }
        public override string DoSound()
        {
            return "Aoouuuuuwwwwwwwww!!! ";
        }

        public override string Stats => $"{base.Stats}";

        public Wolf(string Name, int Age, double Weight)
        {
            return;
        }
    }
}
