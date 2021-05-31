namespace Animals
{
    public class Tomcat : Cat
    {
        private const string GenderDefault = "Male";

        public Tomcat(string name, int age) 
            : base(name, age, GenderDefault)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}