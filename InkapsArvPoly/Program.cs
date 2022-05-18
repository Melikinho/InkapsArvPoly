namespace InkapsArvPoly

{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jimmy", "Melik", 28, 185, 85);
            Person person1 = new Person("Zlatan", "Ibrahimovic", 39, 195, 85);
            Console.WriteLine(person.ToString());
            Console.WriteLine(person.ToString());

        }
    }
}