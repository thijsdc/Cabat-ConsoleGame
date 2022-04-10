using System;
using static System.Console;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Title = "Cabat";
            CursorVisible = false;

            try

            {
                WindowHeight = 55;
                WindowWidth = 140;
            }

            catch

            {
                WriteLine("Error: Cannot create a big enough console window.");
                WriteLine("You can continue playing, but be aware that some art might not render as intended.");
                CustomMethods.WaitForKeyPress();
            }


            Game game = new Game();
            game.Run();

                       
            
        }
    }
}
