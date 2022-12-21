
using System;

class GFG
{
    public static void Main(string[] args)
    {
        //To run the program, click start without Debugging (Ctrl+F5)

        int a, b, i, j, flag;

        Console.WriteLine("Enter two numbers " +
            "to find the prime numbers between them");


        Console.WriteLine("Enter First number"); 
                       
       a = int.Parse(Console.ReadLine());

       Console.WriteLine("\nEnter Second number");
                       
      b = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nPrime numbers between " +
                        "{0} and {1} are: ", a, b);

       
        for (i = a; i <= b; i++)
        {
          
            if (i == 1 || i == 0)
                continue;
           
            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
        
            if (flag == 1)
                Console.WriteLine(i);

            
        }
    }
}

