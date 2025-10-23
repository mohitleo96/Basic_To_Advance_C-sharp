using System;
namespace _2_IntermediateQuestions
{
    class Q2_PrimeNumber
    {
        public static void PrimeNumber()
        {
            int a = 50;
            for(int i=2;i<=a; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}