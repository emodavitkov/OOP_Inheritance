using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTest
{
    public class Racket : GameObject
    {
        public int Size { get; set; }

        public Racket(int size, Position position)
            :base(position)
        {
            Size = size;
        }
        public override void Draw()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.SetCursorPosition(Position.Y, Position.X+i);
                Console.WriteLine("|");
            }
        }
    }
}
