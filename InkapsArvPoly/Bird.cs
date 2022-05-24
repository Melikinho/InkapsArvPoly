namespace InkapsArvPoly
{
    internal class Bird : Animal
    {
        bool FlyingBird
        {
            get;
            set;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pip pip pip pip pip");
        }

        public override string Stats() => $"{base.Stats()} Bird can fly: {FlyingBird}";

        public Bird(string Name, int Age, double Weight, bool flyingBird) : base(Name, Age, Weight)
        {
            FlyingBird = flyingBird;
        }
    }
}
