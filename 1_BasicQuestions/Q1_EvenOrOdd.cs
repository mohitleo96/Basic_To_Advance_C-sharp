using System;

namespace BasicQuestions
{
    public class Q1_EvenOrOdd
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter any Number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is Even", a);
            }
            else
            {
                Console.WriteLine("{0} is Odd", a);
            }
        }
    }
}