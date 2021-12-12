using System;

namespace cw_3e5_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 20;
            var count = 1;
            var sum = 0;

            while(count<num)
            {
                if(count%3 == 0 && count%5 == 0)
                {
                   sum += count;

                } else
                {
                    if(count%3==0)
                    {
                        sum += count;
                        
                    } else
                    {
                        if(count%5==0)
                        {
                            sum += count;
                            
                        }
                    }
                }
                count++;
            }

            Console.WriteLine(sum);
        }
    }
}
