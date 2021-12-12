using System;

namespace ex_squeakyclean
{
    class Program
    {
        static void Main(string[] args)
        {
            Identifier.Clean("Id     -a  \0my");
        }
    }
}
