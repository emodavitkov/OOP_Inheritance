using System;
using System.Linq;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Beast!")
                {
                    return;
                }

                string[] currAnimal = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currAnimal[0];
                int age = int.Parse(currAnimal[1]);
                string gender = currAnimal[2];

                if (string.IsNullOrEmpty(name) ||
                
                    age<0 ||

                string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                switch (input)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        break;

                    case "Cat":
                        var cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        break;

                    case "Frog":
                        var frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        break;

                    case "Kitten":
                        var kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);

                        break;

                    case "Tomcat":
                        var tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat);
                        break;
                }



            }

            
        }
    }
}
