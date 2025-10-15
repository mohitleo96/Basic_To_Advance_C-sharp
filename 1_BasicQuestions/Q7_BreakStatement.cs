using System;
namespace BasicQuestions
{
    class Q7_BreakStatement
    {
        //Use break to stop printing numbers when the number reaches 13
        public static void Break()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=num; i++)
            {
                if (i == 13)
                    break; // if i use continue it skips 13 and go on upto 
                Console.WriteLine(i + " ");
            }
        }
    }
}