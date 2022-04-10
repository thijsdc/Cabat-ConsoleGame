using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class ExploreFerumbrasForestScene : Scene
    {
        public ExploreFerumbrasForestScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            
            Console.Clear();
            Console.WriteLine(MyGame.player.Player_Location.Art);
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string Prompt = "What do you wish to do?";
            string[] Options = { "Search for monster", "Visit Ferumbras Tower" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    Console.Clear();
                    Scene fightOrFlighscene = new FightOrFleaScene(MyGame);
                    fightOrFlighscene.Run();
                    break;
                case 1:
                    MyGame.enterTreeHouseScene.Run();
                    break;

            }
        }
    }
}
