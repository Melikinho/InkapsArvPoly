using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _height;
        private double _weight;

        public Person(string firstName, string lastName, int age, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Weight = weight;
        }


        public string FirstName
        {
            get { return _firstName;  }
            set{ _firstName = value; }
        }
        public string LastName 
        {
            get { return _lastName;} 
            set { _lastName = "Melik"; } 
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Only greater than 0! ");
                    throw new ArgumentException("Only greater than 0!");

                }
            }
        }
        public double Height 
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value;  }
        }

        public override string ToString()
        {
            return $"First Name:\n {FirstName}\n Last Name: {LastName}\n Age: {Age}\n Height: {Height}\n Weight: {Weight}\n";
        }
    }
}
