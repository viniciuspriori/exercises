using System;
using System.Linq;
public class NewSolution
{
        public static int SquareDigits(int n)
        {
            return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        }
}