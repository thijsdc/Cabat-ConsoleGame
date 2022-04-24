using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class CabatoverlordScene : Scene
    {
        

        public CabatoverlordScene(Game game) : base(game)

        {

           
            
        }

        public override void Run()
        {
            Console.Clear();
            Monster cabat_overlord = new Cabat_Overlord();
            cabat_overlord.Display();
            Console.WriteLine("You are facing the Cabat Overlord, abandon all hope...");
            CustomMethods.WaitForKeyPress();
            MyGame.combatScene.Run(cabat_overlord);
            if(cabat_overlord.IsDead) MyGame.endScene.Run();




        }
    }
}
