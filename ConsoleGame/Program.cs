using System;
using static System.Console;
using System.Media;
using System.Text;

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

            /*try

            {

                SoundPlayer music = new SoundPlayer("Sea Shanty.wav");
                music.PlayLooping();

            }

            catch

            {
                Console.WriteLine("System could not play audio.");
                CustomMethods.WaitForKeyPress();
                Console.Clear();
            }*/


            Game game = new Game();
            game.Run();



        }
    }
}
