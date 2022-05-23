using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    abstract class Animal
    {

        //Properties

        protected string name;
        protected int age;
        protected double weight;

        public string Name { get { return name; } set { name = value;  } }
        public int Age { get { return age; } set { age = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        //Metod som gör ljud
        public abstract string DoSound();

        //Konstruktor
        public Animal()
        {

        }

        public virtual void Stats(string Name, int Age, double Weight)
        {
            return;
        }
    }




}
