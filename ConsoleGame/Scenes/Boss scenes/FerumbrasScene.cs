using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class FerumbrasScene : Scene
    {
        

        public FerumbrasScene(Game game) : base(game)

        {

            
            
        }

        public override void Run()
        {
            Console.Clear();
            Monster ferumbras = new Ferumbras();
            ferumbras.Display();
            Console.WriteLine("You have awakened Ferumbras, the evil sorcerer!");
            CustomMethods.WaitForKeyPress();
            MyGame.combatScene.Run(ferumbras);           
            

            

        }
    }
}
