using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapsArvPoly
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double height;
        private double weight;

        public string FirstName
        {
            get { return firstName;  }
            set{ firstName = value; }
        }
        public string LastName 
        {
        get { return lastName;} 
            set { lastName = value; } 
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height 
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value;  }
        }






    }
}
