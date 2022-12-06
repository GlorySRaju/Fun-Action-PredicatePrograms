using System;

namespace PredicateVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<char> vowelCheck = new Predicate<char>(IsVowel);

            VowelFunction(vowelCheck);
        }
        static void VowelFunction(Predicate<char> vowel)
        {
            Console.WriteLine(vowel('A'));
            Console.WriteLine(vowel('a'));
            Console.WriteLine(vowel('T'));
            Console.WriteLine(vowel('t'));
            Console.WriteLine(vowel('K'));
            Console.WriteLine(vowel('k'));
        }
        static bool IsVowel(char input)
        {
            bool Isvowel = false;
            switch(char.ToLower(input))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Isvowel = true;
                    break;
                default:
                    break;
            }
            if (Isvowel)
            {
                return true;
            }
            return false;
        }

    }
}
