using System;

class HelloWorld {
    
    static long factorial(int num)
    {
        int result = 1;
        
        for (int i = 1; i <= num; i++)
        {
            result = result*i;
        }
        return result;
    }
    
    static long factorial2(int num)
    {
        int result = 1;
        
        while (1 <= num)
        {
            result *= num*1;
            num-=1;
        }
        
        
        return result;
    }
    
    static int PrimeNumber(int num)
    {
        if (num )
    }
    
    static bool prime(int n)
    {
        if(n == 1)
        {
            return False;
        }
        
        else
        {
            for(int i = 2; i <= n/i; i++)
            {
                Console.WriteLine(i);
            }
        }
        
    }
    
    
    static void Main() {
    
    /*  
    Console.WriteLine("5!  = " + factorial(5));
    Console.WriteLine("0!  = " + factorial(0));
    Console.WriteLine("27! = " + factorial(27));
    */
    
    /* 
    Console.WriteLine("5! = " + factorial2(5));
    Console.WriteLine("0! = " + factorial2(0));
    Console.WriteLine("25! = " + factorial2(25));
    */
    
    
  }
  
}
