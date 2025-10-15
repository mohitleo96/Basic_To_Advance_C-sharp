using System;
namespace BasicQuestions
{
    class Q4_Multiplication_Upto_10
    {
        public static void multi()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int mul = a * i;
                Console.WriteLine("Multiplication is {0} X {1} = {2}", a, i, mul);
            }
        }
    }
}