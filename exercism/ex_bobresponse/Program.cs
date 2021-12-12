using System;

namespace ex_bobresponse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bob.Response("BOLSOANR$ *&@#(!"));
            Console.WriteLine(Bob.Response("wtf?   "));
            Console.WriteLine(Bob.Response("xiii"));
            Console.WriteLine(Bob.Response("BWTF?"));
        }
    }
}
