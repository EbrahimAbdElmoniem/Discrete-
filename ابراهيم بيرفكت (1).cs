
using System;
public class Exercise28
{
    public static void Main()
    {
        //To run the program, click start without Debugging (Ctrl+F5)

        int n, i, sum;
        int mn, mx;

        Console.Write("\n\n");
        Console.Write("Find the perfect number between two numbers:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Enter First Number : ");
        mn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        mx = Convert.ToInt32(Console.ReadLine());
        Console.Write("The perfect number between the two numbers is : ");
        for (n = mn; n <= mx; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}
