using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Rot13
{
    public class Kata
    {
        public static string Rot13(string message)
        {
            char[] alphaArr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            var count = alphaArr.Count();

            char[] messageArr = message.ToLower().ToCharArray();

            string res = string.Empty;

            for (int j = 0; j < messageArr.Length; j++)
            {
                if (char.IsLetter(messageArr[j]))
                {
                    var aux = messageArr[j];
                    var index = Array.IndexOf(alphaArr, aux);

                    if (index + 13 >= count)
                    {
                        index -= count;
                    }

                    messageArr[j] = alphaArr[index + 13]; 
                } else
                {
                    messageArr[j] = messageArr[j];
                }
            }

            for (int i = 0; i < messageArr.Length; i++)
            {
                if (char.IsUpper(message.ToCharArray()[i]))
                {
                    res += char.ToUpper(messageArr[i]);
                }
                else
                {
                    res += messageArr[i];
                }
            }

            return res;
        }
    }
}
