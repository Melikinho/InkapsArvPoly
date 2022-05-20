using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Wolfman : Wolf, IPerson
    {
        public string Talk()
        {
            Console.WriteLine("I am a WolfMan! I can talk!!!! ");
            throw new NotImplementedException();
        }
    }
}
