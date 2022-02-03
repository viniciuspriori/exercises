using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
       if(IsPositive(balance)){

           if(!GreaterThanThousand(balance)) {
               return (float)0.05;
           }
           else { 
               if(!GreaterThanFiveThousand(balance)) return (float)1.621;

               return (float)2.475;
           } 

       }
       return (float)3.213M;
        
    }

    static bool IsPositive(decimal balance) => balance > 0 ? true : false;
    static bool GreaterThanThousand(decimal balance) => balance >= 1000 ? true : false;
    static bool GreaterThanFiveThousand(decimal balance) => balance >= 5000 ? true : false;

    public static decimal Interest(decimal balance)
    {
        return ((decimal)InterestRate(balance) * balance/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
      int cont = 0;

       while(balance <= targetBalance)
       {
           balance += Interest(balance);
           cont++;
       }

       return cont;
    }
}
