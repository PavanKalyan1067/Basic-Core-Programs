
using System;

namespace Vowels
{
    class Vowels
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Charachter to check if its a vowel..");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("{0} is a vowel", ch);
                    break;
                default:
                    Console.WriteLine("{0} is not a vowel", ch);
                    break;
            }
            Console.ReadKey();
        }
    }
}
