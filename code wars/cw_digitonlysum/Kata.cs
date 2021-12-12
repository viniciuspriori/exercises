public class Number
{
  public static int DigitalRoot(long n)
  {
      long resto;
      long div;
    // Your awesome code here!
    while(n>=10)
    {   
        div = n / 10;
        resto = n % 10;

        n = resto + div;
    }
      return (int)n;
  }
}