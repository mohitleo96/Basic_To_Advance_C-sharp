using System;

namespace BasicQuestions
{
    class Q2_SwapNumbers
    {
        public static void swap()
        {
            Console.WriteLine("Before Swapping enter a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping a= {0} and b={1}", a, b);
        }
    }
}