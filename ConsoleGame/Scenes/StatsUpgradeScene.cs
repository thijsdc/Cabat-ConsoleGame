using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class StatsUpgradeScene : Scene
    {

        public StatsUpgradeScene(Game game) : base(game)

        {

        }

       public override void Run()

        {
            Console.Clear();

            
            string prompt = "Which stat would you like to level up? You can choose between: healing strength, attack strength, and mana points.";
            string[] options =
            {
                "attack",
                "healing",
                "mana points"

            };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)

            {
                case 0:
                    MyGame.player.Attack_Level += 1;
                    Console.WriteLine($"You upgraded your attack level strength to {MyGame.player.Attack_Level}.");
                    break;
                case 1:
                    MyGame.player.Healing_Level += 1;
                    Console.WriteLine($"You upgraded your healing level to {MyGame.player.Healing_Level}.");
                    break;
                case 2:
                    MyGame.player.Mana_Points += 25;
                    Console.WriteLine($"You now have {MyGame.player.Mana_Points} mana points.");
                    break;

            }
        }

    }
}
