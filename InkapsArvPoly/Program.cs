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
            Dog dog = new Dog("Hej", 2, 20);

            Animals.Add(new Horse("Ponny", 8, 160.3));
            Animals.Add(new Hedgehog("Jeme", 1, 0.3));
            Animals.Add(new Dog("Lucky", 1, 10.0));
            Animals.Add(new Wolf("Varg", 10, 50.0));
            Animals.Add(new Worm("Snake", 1, 2));
            Animals.Add(new Bird("Fiolja", 3, 5));


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

            var horse = new Horse("PonnysPappa", 15, 300);
            Console.WriteLine(dog);
            dog.DoSound();
            horse.DoSound();

            static void WolfMan()
            {
                var wolfMan = new Wolfman("Wolfman", 50, 82);
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
//public void TryCatchMethod()
//{
//    // ToDo try/CatchMethod        
//}
//                 } }

