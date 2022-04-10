using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class PlayerFightOptionsScene : Scene
    {

        public PlayerFightOptionsScene(Game game) : base(game)

        {

        }

        public override void Run(Monster monster)
        {
            Console.Clear();

            monster.Display();
            MyGame.player.Display();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string prompt = "Do you want to attack or heal?";
            string[] options =
            {
                "attack",
                "heal",
                $"use mana potion ({MyGame.player.Mana_Potions})"

            };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    MyGame.player.Attack(monster);
                    break;
                case 1:
                    if (MyGame.player.Current_Mana < 20)

                    {
                        Console.WriteLine("You have insufficient mana to heal...");
                        CustomMethods.WaitForKeyPress();
                        MyGame.playerFightOptionsScene.Run(monster);
                        break;
                    }
                    MyGame.player.Heal();                 
                    break;
                case 2:
                    if(MyGame.player.Mana_Potions == 0)

                    {
                        Console.WriteLine("You do not have any mana potions left...");
                        CustomMethods.WaitForKeyPress();
                        MyGame.playerFightOptionsScene.Run(monster);
                        break;
                    }
                    MyGame.player.UseManaPotion();
                    break;


            }
        }

    }
}
