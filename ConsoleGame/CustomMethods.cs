using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleGame
{
   public static class CustomMethods
    {
        public static void WaitForKeyPress()

        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }

        public static void WritingAnimation(string sentence, int speed)

        {
            for (int i = 0; i < sentence.Length; i++)

            {
                Console.Write(sentence[i]);
                Thread.Sleep(speed);

            }

            Console.WriteLine();
        }
    }
}
