using System;
using System.Collections.Generic;

namespace InheritanceTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<GameObject> objects = new List<GameObject>();

            objects.Add(new Ball(new Position(5, 6), Direction.Right));
            objects.Add(new Racket(10,new Position(2,3)));
            objects.Add(new Racket(10,new Position(2,3)));

            foreach (var gameObject in objects)
            {
                gameObject.Draw();
            }
            

            
        }
    }
}
