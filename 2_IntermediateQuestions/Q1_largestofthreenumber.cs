using System;

namespace _2_IntermediateQuestions
{
    class Q1_largestofthreenumber
    {
        int num1;
        int num2;
        int num3;
        public void Set_largestNumber(int a, int b, int c)
        {
            num1 = a;
            num2 = b;
            num3 = c;

        }
        public int Get_largestNumber()
        {
        if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

    }

}