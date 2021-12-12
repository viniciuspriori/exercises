using System;

namespace cw_roman
{
    class Program
    {
        static int y;
        //input nromal number - output its roman number
        static void Main(string[] args)
        {
            String[] hunds = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
            String[] tens = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            String[] units = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            
            var strNum = "987"; //é uma string
            int length = strNum.Length;

            int num = Convert.ToInt32(strNum);
            y = num;

            String res = String.Empty;

            for (int i = length-1; i >= 0; i--)
            {        
                    int x = y%10;       
                    y /= 10;                  

                if(x!=0)
                {
                    if(i==(length-1))
                    {
                        res += units[x-1];
                    } else 
                    
                    {
                        if(i==length-2)
                        {
                            res = tens[x-1] + res;
                        } 
                        else
                        {
                            if(i==0)
                            {
                                res = hunds[x-1] + res;
                            }
                        }  
                    }                                        
                }

            }              
            
            Console.WriteLine($"res: {res}");
        }
    }
}
