using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int TossNumber = 100;
            int Heads = 0;
            int Tails = 0;
            while (TossNumber > 0)
            {
                Random random = new Random();
                int result = random.Next(2);

                if (result == 0)
                {
                    Heads++;
                }
                else if (result == 1)
                {
                    Tails++;
                }
                Console.WriteLine("Number Of Heads : " + Heads);
                Console.WriteLine("Number Of Tails : " + Tails);
            }
          
        }
    }
}
