using System;
namespace _2_IntermediateQuestions
{
    class Q4_Reverse_Number
    {
        public static void reverse()
        {
            Console.WriteLine("Enter a number which you want a Reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int digit;
            while(num>0)
            {
                digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
                Console.WriteLine("so the Reverse is {0}", rev);
        }
    }
}