﻿using System;
namespace InkapsArvPoly

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new PersonHandler().CreatePerson("Jimmy", "Melik", 28, 185, 85);
                Console.WriteLine($"Name: {person.FirstName} {person.LastName} " +
                    $"Age: {person.Age} years old " +
                    $"Height: {person.Height} kg " +
                    $"Weight: {person.Weight} cm ");
            }


            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                //Person person = new Person("Jimmy", "Melik", 28, 185, 85);
                //Person person1 = new Person("Jan", "Andersson", 60, 175.0, 120.0);
                //Console.WriteLine(person.ToString());
                //Console.WriteLine(person1.ToString());
                Person CreatePerson = new Person("Jimmy", "Melik", 28, 185.5, 85);
                List<UserError> userErrors = new List<UserError>();
                List<Animal> AnimalList = new List<Animal>();
                List<Horse> horseList = new List<Horse>();
                List<Animal> Animals = new List<Animal>();
                Dog dog = new Dog("Hej", 2, 20);
                dog.DoSound();





                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());
                userErrors.Add(new FCBMessageUefa());
                userErrors.Add(new FCBMessageLaLiga());
                userErrors.Add(new FCBMessageCopaDelRey());

                foreach (var animal in Animals)

                {
                    Console.WriteLine(animal.Stats());
                    animal.DoSound();

                }

                var horse = new Horse("PonnysPappa", 15, 300, true);
                horse.DoSound();

                static void WolfMan()
                {
                    var wolfMan = new Wolfman("Wolfman", 50, 82, true);
                    wolfMan.Talk();
                    wolfMan.DoSound();
                }


                static void Doggy()
                {
                    var dogList = new List<Dog>()
                {
                    new Dog("Buster", 5, 10),
                    new Dog("Lucky", 10, 20)

                 };
                }

                {
                }



            }
        }
    }
}
//public void TryCatchMethod()
//{
//    // ToDo try/CatchMethod        
//}
//                 } }

