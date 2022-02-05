using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CW_GreedIsGood
{
    using System;

    public static class Kata
    {
        public static int Score(int[] dice)
        {
            int sum = 0;

            var dict = new Dictionary<int, int>();

            foreach (var value in dice)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }

            foreach (var item in dict)
            {
                if(item.Value >= 3)
                {
                    switch (item.Key)
                    {
                        case 1:
                            sum += 1000;
                            break;
                        case 6:
                            sum += 600;
                            break;
                        case 5:
                            sum += 500;
                            break;
                        case 4:
                            sum += 400;
                            break;
                        case 3:
                            sum += 300;
                            break;
                        case 2:
                            sum += 200;
                            break;
                        default:
                            sum += 0;
                            break;
                    }

                    
                }
            }
                foreach (var value in dict)
                {
                    int diff = 0;

                    if (value.Value >= 3) //checa se foi contado 3x e pega a diferença 
                    {
                            diff = value.Value - 3;
                    }
                    else
                    {
                        diff = value.Value;
                    }

                        if (value.Key == 1) sum += 100 * diff;
                        if (value.Key == 5) sum += 50 * diff; ;
                    
                        
                }
                    
            return sum;
        }
    }
}
