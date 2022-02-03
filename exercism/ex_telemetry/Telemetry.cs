using System;
using System.Linq;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    { 
        var bytearr = BitConverter.GetBytes(reading);
        var prefix = (byte)((bytearr.ToList().FindLastIndex(q => q!=0))*2);

        if(reading==0) prefix = ((byte)2);  

        byte[] result = new byte[9]; 
        
         if(prefix >= 0 && prefix <= 2 && CheckRange(reading, short.MinValue, short.MaxValue/2))
            {
                result[0] = prefix;
            }
            else if(prefix >= 2 && prefix <= 4 && CheckRange(reading, Int32.MinValue, Int32.MaxValue/2))
            { 
                result[0] = prefix;
            }
            else if (prefix >= 4 && prefix <= 8 && CheckRange(reading, Int64.MinValue, Int64.MaxValue/2))
            {
                result[0] = prefix;
            } else {
                result[0] = ((byte)(256 - prefix));
            }



        for (int i = 1; i < result.Length; i++)
        {
            result[i] = bytearr[i-1];
        }

        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }

        return result;
    }

    private static bool CheckRange(long reading, long bottom, long top) => (reading >= bottom && reading <= top);

    public static long FromBuffer(byte[] buffer)
    {
        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
}
