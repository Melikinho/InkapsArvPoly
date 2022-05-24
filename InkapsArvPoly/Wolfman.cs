using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string Name, int Age, double Weight, bool wolfLikesChicken) : base(Name, Age, Weight, wolfLikesChicken)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am a WolfMan! I can talk!!!! ");
            throw new NotImplementedException();
        }
    }
}
