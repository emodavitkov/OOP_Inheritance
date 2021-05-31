using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Threading.Channels;

namespace Restaurant
{
    public class StartUp
    {

        static void Main(string[] args)
        {

            Soup mySoap = new Soup("skembe", 10, 200);

            Console.WriteLine(mySoap.Name);

        }
    }
}