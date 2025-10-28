using System;

namespace _2_IntermediateQuestions
{
    class Q6_Vowels_Consonents
    {
        public static void checkVowels()
        {
            int vowels = 0;
            int consonants = 0;

            Console.WriteLine("Enter a String: ");
            string? str = Console.ReadLine();
            string? lower = str.ToLower();

            foreach (char c in lower)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Number of Vowels: {0}", vowels);
            Console.WriteLine("Number of Consonants: {0}", consonants);
        }
    }
}