using System;
using System.Numerics;

namespace CW_PerimeterSquares
{
    public class SumFct
    {

        //public BigInteger Integer { get; set; }

        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger numSquares = n + 1;
            BigInteger x = 4 * fibo(numSquares);

            return x;
        }

        public static BigInteger fibo(BigInteger contagem)
        {
            BigInteger anterior = 1;
            BigInteger atual = 1;
            BigInteger resultado = 0;

            for (BigInteger i = 0; i < contagem; i++)
            {
                resultado = atual + anterior;
                anterior = atual;
                atual = resultado;
            }
             
            return (BigInteger)resultado-1;
        }
    }

    //public class BigInteger
    //{
    //    public int value { get; set; }
    //    public BigInteger(int integer)
    //    {
    //        this.value = integer;
    //    }
    //    public BigInteger()
    //    {

    //    }
    //}
}
