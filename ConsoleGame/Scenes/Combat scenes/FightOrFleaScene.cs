using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class FightOrFleaScene : Scene
    {
        public Monster monster;

        public FightOrFleaScene(Game game) : base(game)

        {
            monster = MyGame.player.Player_Location.SelectRandomMonster();
        }

        public override void Run()
        {

           
            monster.Display();
            
            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string prompt = $"A {monster.Name} has appeared, do you want to fight or flea?";
            string[] options =
            {
                "fight",
                "flea",

            };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    MyGame.combatScene.Run(monster);
                    break;
                case 1:
                    Console.WriteLine("You choose to flea.");
                    CustomMethods.WaitForKeyPress();
                    break;                

            }

                        
        }
    }
}
