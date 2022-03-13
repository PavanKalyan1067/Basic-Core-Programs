using System;

namespace Powerof2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (var i = 0; i <= n; i += 2)
            {
                num = num * 2 * 2 ;
            }
        }
    }
}
