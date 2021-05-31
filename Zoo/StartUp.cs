using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Bear teddyBear = new Bear("Teddy");
            Console.WriteLine(teddyBear.Name);
        }
    }
}
