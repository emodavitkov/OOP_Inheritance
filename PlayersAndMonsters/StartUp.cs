using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Threading.Channels;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
        Hero emoHero = new Hero("Emo", 100);

        DarkKnight dark = new DarkKnight("Sado", 11);

        MuseElf muse = new MuseElf("Elfcho", 12);

        Console.WriteLine(dark);
        Console.WriteLine(muse);
        Console.WriteLine(emoHero);
        }
        

       
    }
}
