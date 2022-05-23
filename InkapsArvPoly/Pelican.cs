using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Pelican : Bird
    {
        bool EatsWaterFish = true;

        public Pelican(string Name, int Age, double Weight) : base(Name, Age, Weight)
        {
        }

        public string WaterFish
        {
            get { return WaterFish; }
            set { WaterFish = value; }
        }

    }
}
