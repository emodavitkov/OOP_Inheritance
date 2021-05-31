namespace Animals
{
    public class Kitten : Cat
    {
        private const string GenderDefault = "Female";
        public Kitten(string name, int age) 
            : base(name, age, GenderDefault)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}