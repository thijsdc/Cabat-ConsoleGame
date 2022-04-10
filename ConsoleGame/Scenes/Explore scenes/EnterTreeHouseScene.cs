using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes.Explore_scenes
{
    class EnterTreeHouseScene : Scene
    {

        public EnterTreeHouseScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine(ArtAssets.TreeHouse);
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string Prompt = "A mysterious glow surrounds the tree house, are you sure you want to offer Queen Rat's tail?";
            string[] Options = { "Yes", "No" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    if(MyGame.player.HasRatTail == false)

                    {
                        Console.Clear();                        
                        Console.WriteLine(ArtAssets.TreeHouse);                        
                        Console.WriteLine();
                        Console.WriteLine("How dare you try to enter my treehouse? You haven't even defeated the Rat Queen!");
                        Console.WriteLine("Bring me her tail and I will consider letting you in...");
                        CustomMethods.WaitForKeyPress();
                        return;
                    }
                    var ferumbrasScene = new FerumbrasScene(MyGame);
                    ferumbrasScene.Run();
                    break;
                case 1:
                    return;                    
                    
                
            }
        }
    }

}
