using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Pelican : Bird
    {

        public Pelican(string Name, int Age, double Weight, bool waterFish) : base(Name, Age, Weight, waterFish)
        {
            WaterFish = waterFish;
        }

        public bool WaterFish
        {
            get;
            set;
        }

    }
}
