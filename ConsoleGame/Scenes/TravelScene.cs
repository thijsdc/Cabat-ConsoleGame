using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class TravelScene : Scene

    {
        public TravelScene(Game game) : base(game)

        {

        }

        
        public override void Run()
        {
            Console.Clear();

            string Prompt = "What location do you wish to visit?";
            string[] Options = { "Thais city", "Ferumbras Forest", "Cabat Castle", "Go back" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)

            {
                case 0:
                    MyGame.player.SetPlayerLocation(new Thais()) ;
                    Console.Clear();
                    Console.WriteLine(MyGame.player.Player_Location.Art);
                    Console.WriteLine("You have arrived in Thais City.");
                    CustomMethods.WaitForKeyPress();
                    break;
                case 1:
                    if (!MyGame.player.HasFerumbrasTravelPermit)

                    {
                        NotWorthy("Ferumbras Travel Permit");
                        break;
                    }

                    MyGame.player.SetPlayerLocation(new Ferumbras_Forest());
                    Console.Clear();
                    Console.WriteLine(MyGame.player.Player_Location.Art);
                    Console.WriteLine("You are visiting Ferumbras Forest.");
                    CustomMethods.WaitForKeyPress();
                    break;
                case 2:
                    if (!MyGame.player.HasCabatCastleTravelPermit)
                    {
                        NotWorthy("Cabat Castle Travel Permit");
                        break;
                    }
                    MyGame.player.SetPlayerLocation(new Cabat_Castle());
                    Console.Clear();
                    Console.WriteLine(MyGame.player.Player_Location.Art);
                    Console.WriteLine("You are visiting Cabat Castle.");
                    CustomMethods.WaitForKeyPress();
                    break;
                case 3:
                    MyGame.mainMenuScene.Run();
                    break;


            }
        }

        public void NotWorthy(string item)

        {
            Console.Clear();
            Console.WriteLine($"You require {item}!");
            CustomMethods.WaitForKeyPress();
        }
    }
}
