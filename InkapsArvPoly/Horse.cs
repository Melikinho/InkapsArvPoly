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
        public override string DoSound()
        {
            return "MEhehehhuwuuuewwwww";
        }


    }
}
