using System;
namespace BasicQuestions
{
    class Q6_ContinueStatement
    {
        //Use continue to skip odd numbers
        public static void Continue()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=num; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i + " ");
            }
        }
    }
}