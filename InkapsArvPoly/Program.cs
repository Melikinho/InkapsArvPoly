﻿namespace InkapsArvPoly

{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jimmy", "Melik", 28, 185, 85);
            Person person1 = new Person("Jan", "Andersson", 60, 175.0, 120.0);
            Console.WriteLine(person.ToString());
            Console.WriteLine(person1.ToString());

        }
    }
}