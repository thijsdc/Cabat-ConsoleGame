using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleGame.CustomMethods;


namespace ConsoleGame.Scenes
{
    class EndScene : Scene

    {
        public EndScene(Game game) : base(game)

        {

        }

        public override void Run()
        {

            MyGame.stopWatch.Stop();
            var elapsedTime = MyGame.stopWatch.Elapsed;

            Console.Clear();
            Console.WriteLine(ArtAssets.TheEnd);
            Console.WriteLine();
            WritingAnimation($"Congratulations {MyGame.player.Name}, you defeated the Cabat Overlord!", 25);
            WritingAnimation("This is where the story ends, for now...",25);
            WritingAnimation($"You finished the game in {(int) elapsedTime.TotalSeconds} seconds.", 25);
            WritingAnimation($"Thank you for playing {MyGame.player.Name}!", 25);
            CustomMethods.WaitForKeyPress();
            return;





        }
    }
}
