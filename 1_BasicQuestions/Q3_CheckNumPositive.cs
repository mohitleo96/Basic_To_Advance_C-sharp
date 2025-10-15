using System;
namespace BasicQuestions
{
    class Q3_CheckNumPositive
    {
        public static void checkNum()
        {
            Console.WriteLine("Write a Number as your wish");
            int n = Convert.ToInt32(Console.ReadLine());
            string result = (n > 0) ? "Positive" : ((n < 0) ? "Negative" : "Equal To 0");
            Console.WriteLine(result);
        }
    }
}