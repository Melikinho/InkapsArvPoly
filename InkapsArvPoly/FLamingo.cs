using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Flamingo : Bird
    {
        bool FlamingoIsAGoodSwimmer = false;
        public bool FlamingoSimming
        {
            get { return FlamingoIsAGoodSwimmer;  }
            set { FlamingoIsAGoodSwimmer = value; }  
        }

    }
}
