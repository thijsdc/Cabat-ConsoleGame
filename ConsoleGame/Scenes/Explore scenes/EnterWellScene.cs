using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes.Explore_scenes
{
    class EnterWellScene : Scene
    {

        public EnterWellScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine(ArtAssets.Well);
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string Prompt = "Something dangerous seems to lurk beneath, are you sure you want to enter?";
            string[] Options = { "Yes", "No" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run(cursorleft,cursortop);

            switch (selectedIndex)

            {
                case 0:
                    var RatQueenScene = new RatQueenScene(MyGame);
                    RatQueenScene.Run();
                    break;
                case 1:
                    return;                    
                    
                
            }
        }
    }

}
