using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
        int sum_maior = 0;
        int sum = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = j; i < arr.Length; i++)
            {
                sum += arr[i];  

                if(sum > sum_maior) 
                {
                    sum_maior = sum;
                }           
                           
            }
            sum=0;
        }
    return sum_maior;
  }

   public static int[] MaxSequenceArr(int[] arr) 
  { 
        List<int> sum = new List<int>();
        List<int> sum_maior = new List<int>();

        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = j; i < arr.Length; i++)
            {
                sum.Add(arr[i]);

                if(sum.Sum() > sum_maior.Sum()) 
                {
                    sum_maior = sum.GetRange(0, sum.Count);
                }           
                           
            }
            sum.Clear();
        }
    return sum_maior.ToArray();
  }
}