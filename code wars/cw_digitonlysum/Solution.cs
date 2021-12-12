public class Solution
{
  public static int DigitalRoot(long n)
  {
     return (int)(1 + (n - 1) % 9);
  }
}