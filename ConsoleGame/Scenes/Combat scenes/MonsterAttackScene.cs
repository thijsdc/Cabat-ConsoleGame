using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class MonsterAttackScene : Scene
    {

        public MonsterAttackScene(Game game) : base(game)

        {

        }

        public override void Run(Monster monster)
        {
            Console.Clear(); 
            int attackValue = monster.Attack(MyGame.player);
            monster.Display();
            MyGame.player.Display();
            monster.DisplayAttack(MyGame.player, attackValue);
                        
        }

    }
}
