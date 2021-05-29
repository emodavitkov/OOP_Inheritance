using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy sharo = new Puppy();
            sharo.Eat();
            sharo.Bark();
            sharo.Weep();

            Dog dog = new Dog();

            dog.Bark();


            Cat cat = new Cat();
            cat.Meow();
        }
    }
}
