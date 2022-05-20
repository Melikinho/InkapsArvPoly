namespace InkapsArvPoly

{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Jimmy", "Melik", 28, 185, 85);
            //Person person1 = new Person("Jan", "Andersson", 60, 175.0, 120.0);
            //Console.WriteLine(person.ToString());
            //Console.WriteLine(person1.ToString());
            Person CreatePerson = new Person("Jimmy", "Melik", 28, 185.5, 85);
            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new FCBMessageUefa());
            userErrors.Add(new FCBMessageLaLiga());
            userErrors.Add(new FCBMessageCopaDelRey());
            Console.ForegroundColor = ConsoleColor.Red;

            {
                foreach (var error in userErrors)
                {
                    Console.WriteLine(error.UEMessage());
                }
            }  // 2 instaces of NumericInputError & TextInputError insert onto the list
        }
        public void TryCatchMethod()
        {
            // ToDo try/CatchMethod        
        }
    } }

