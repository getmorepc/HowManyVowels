using System;

namespace HowManyVowels
{
    public class Class1
    {
        //Create a function that takes a string and returns the number (count) of vowels contained within it.

        public static int CountVowels(string str)
        {
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    a++;
                }
            }
            return a;
        }
    }
}
