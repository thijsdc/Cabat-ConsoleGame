using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class RatQueenScene : Scene
    {
        

        public RatQueenScene(Game game) : base(game)

        {

            
            
        }

        public override void Run()
        {
            Console.Clear();
            Monster rat_queen = new Rat_Queen();
            rat_queen.Display();
            Console.WriteLine("You encounter the Rat Queen");
            CustomMethods.WaitForKeyPress();
            MyGame.combatScene.Run(rat_queen);           
            CustomMethods.WaitForKeyPress();


        }
    }
}
