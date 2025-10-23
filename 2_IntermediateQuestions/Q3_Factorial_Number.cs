using System;
namespace _2_IntermediateQuestions
{
    class Q3_Factorial_Number
    {
        public static void factorial()
        {
            Console.WriteLine("Enter a number which you want a factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i; //fact *= i;
            }
            Console.WriteLine("so the Factorial of {0} is {1}", num, fact);
        }
    }
}