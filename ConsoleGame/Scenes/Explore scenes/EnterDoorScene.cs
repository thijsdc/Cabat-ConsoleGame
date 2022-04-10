using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes.Explore_scenes
{
    class EnterDoorScene : Scene
    {

        public EnterDoorScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine(ArtAssets.Door);
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string Prompt = "An ominous aura is seeping through this door, do you wish to use Ferumbras's masterkey?";
            string[] Options = { "Yes", "No" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    if (MyGame.player.HasKey == false)

                    {
                        Console.Clear();
                        Console.WriteLine(ArtAssets.Door);
                        Console.WriteLine();
                        Console.WriteLine("...you need a key to enter this!");
                        CustomMethods.WaitForKeyPress();
                        return;
                    }
                    var cabatOverlordScene = new CabatoverlordScene(MyGame);
                    cabatOverlordScene.Run();
                    break;
                case 1:
                    return;                    
                                    
            }
        }
    }

}
