using System;
namespace _2_IntermediateQuestions
{
    class Q5_Reverse_String
    {
        public static void reverse()
        {
            Console.WriteLine("Enter a String which you want a Reverse");
            string? name = Console.ReadLine();
            string rev = "";
           for(int i = name.Length-1 ; i >= 0 ; i--)
             {
                rev += name[i];
            }
                Console.WriteLine("so the Reverse is {0} is {1}", name, rev);
        }
    }
}