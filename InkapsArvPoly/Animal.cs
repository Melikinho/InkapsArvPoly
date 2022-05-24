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
        public abstract void DoSound();

        //Konstruktor
        public Animal(string Name, int Age, double Weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public virtual string Stats() => $"Name: {GetType().Name}" +
                $"Age: {Age}" +
                $"Weight: {Weight}";
    }




}
