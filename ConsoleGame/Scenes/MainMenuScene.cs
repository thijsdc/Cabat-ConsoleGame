using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class MainMenuScene : Scene
    {
        public MainMenuScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            while (true)

            {
                Console.Clear();
                Console.WriteLine(MyGame.player.Player_Location.Art);
                Console.WriteLine();

                int cursorleft = Console.CursorLeft;
                int cursortop = Console.CursorTop;

                string Prompt = "These are the options available to you:";
                string[] Options = { "Explore", "Travel", "Character Stats", "Close Game" };
                Menu mainMenu = new Menu(Prompt, Options);
                int selectedIndex = mainMenu.Run(cursorleft, cursortop);

                
                switch (selectedIndex)

                {
                    case 0:
                        MyGame.exploreScene.Run(); 
                        break;
                    case 1:
                        MyGame.travelScene.Run();
                        break;
                    case 2:
                        MyGame.player.PlayerStats();
                        break;
                    case 3:
                        MyGame.CloseGame();
                        break;


                }
            }
        }
    }
}
