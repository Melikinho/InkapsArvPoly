using System;
namespace InkapsArvPoly

{
    class Program
    {
        static void Main(string[] args)
        {
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

            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new FCBMessageUefa());
            userErrors.Add(new FCBMessageLaLiga());
            userErrors.Add(new FCBMessageCopaDelRey());

            var horse = new Horse();
            var dog = new Dog("Friddo", 2, 20);
            Console.WriteLine(dog);
            dog.DoSound();
            Console.WriteLine(dog.DoSound());
            horse.DoSound();
            Console.WriteLine(horse.DoSound());


            {
                foreach (var error in userErrors)
                {
                    Console.WriteLine(error.UEMessage());
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

