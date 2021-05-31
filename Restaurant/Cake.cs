namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGramsCake=250;
        private const double DefaultCalories=1000;
        private const decimal DefaultPrice=5;

        public Cake(string name) 
            : base(name, DefaultPrice, DefaultGramsCake, DefaultCalories)
        {

        }
    }
}