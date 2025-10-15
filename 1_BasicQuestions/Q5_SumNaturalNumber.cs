using System;
namespace BasicQuestions
{
    class Q5_SumNaturalNumber
    {
        public static void sum()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of all natual number upto {0} is {1} is", a, sum);
        }
    }
}