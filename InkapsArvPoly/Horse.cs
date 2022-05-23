using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Horse : Animal
    {
        bool HorseLikeToRun = true;
        public bool HorseLikeRun
        {
            get { return HorseLikeToRun; }
            set { HorseLikeRun = value; }
        }
        public override String DoSound()
        {
            return "MEhehehhuwuuuewwwww";
        }
        public override string Stats => $"{base.Stats}";
        public Horse(string Name, int Age, double Weight) : base(Name, Weight, Age)
        {
            return;
        }
    }
}
