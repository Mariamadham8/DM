using System.ComponentModel;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("pls enter a stasrtup num ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("pls enter a end num ");
        int num2 = int.Parse(Console.ReadLine());
        int sum_etrations = 0;
        for (int i = 2; i <= num2; i++)
        {


            for (int j = 1; j <= i; j++)
            {
               if(i % j == 0)
                {
                    sum_etrations += 1;    // in every time the remainder=0 (the number is divisable) num increase by 1 
                }
            }
            if(sum_etrations == 2)        // prime number divisanbe only by itself and 1 so sum would be 2
            {
                Console.WriteLine(i);
               
            }
            sum_etrations = 0;    // to repeat the test of sum to each iteration



        }
    }
}