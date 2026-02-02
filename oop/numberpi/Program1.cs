/******************************************************************************

Calculating number Pi according to leibnitz formula

*******************************************************************************/
using System;

class NumberPi {

//-----------------------------------------

    static double NumberPiLeibnitz(int num)
    {
    double total = 0;
    int k = 1;
    
    for (int i = 1; i<=num; i+=2)
    {
        //Console.Write(1.0/(a*k) + " ");
        total += 1.0/(k*i);
        k = k*(-1);
    }
        return(4*total);
        
    }
    
//-----------------------------------------

    static double NumberPiEuler(int num)
    {
    double total = 0;
    
    for(int i = 1; i<= num; i++)
    {
        total += 1.0/(i*i);
    }
        return(Math.Sqrt(6*total));
    }

//-----------------------------------------

    static double NumberPiWallis[int num]
    {
    double total = 0;
    int k = 1;
    
    for(int i = 1; i<=num; i++)
    {
        total += 1.0*2*i/(2*i-1)*2*i/(2*i+1)
    }
    
    }
    
    
//-----------------------------------------
    static void Main() {
      
    /*
    int k = 1;
    
    for (int i = 1; i<=10; i++)
    {
        Console.Write(i*k + ", ");
        k = k*(-1);
    }
    */
    
    
    double RealPi = 3.141592;
    
    double OurPi = NumberPiLeibnitz(100);
    double diff = OurPi-RealPi;
    
    
    Console.WriteLine("pi = " + OurPi);
    Console.WriteLine("diff = " + Math.Round(diff,10));
    Console.WriteLine("diff absolute value = " + Math.Abs(Math.Round(diff,10)));
    
    
  }
  
}
