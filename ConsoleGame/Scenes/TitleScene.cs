using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleGame.CustomMethods;


namespace ConsoleGame.Scenes
{
    class TitleScene : Scene

    {
        public TitleScene(Game game) : base(game)

        {

        }

        public override void Run()
        {

            Console.WriteLine(ArtAssets.Cabat);
            Console.WriteLine();
            
            WritingAnimation("Welcome brave adventurer, what is your name?", 25);
            MyGame.player.SetName(Console.ReadLine());

            string[] Script =
            {
             $"{MyGame.player.Name}, the good people of Thais have been terrorized by the Cabat Overlord for decades...!",
             "Many warriors have come before you to challenge him, but I believe you might have potential.",
             "Can you help us defeat him?",
             $"Be warned {MyGame.player.Name}, death is lurking behind every corner!",
             "Good Luck my friend!",
             "You are currently in Thais."
            };

            for (int i = 0; i < Script.Length; i++)

            {
                WritingAnimation(Script[i], 25);
            }

            CustomMethods.WaitForKeyPress();



        }
    }
}
