using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class CombatScene : Scene
    {
        public CombatScene(Game game) : base(game)

        {

        }

        public override void Run(Monster monster)
        {
            while (MyGame.player.IsAlive && monster.IsAlive)

            {

                MyGame.playerFightOptionsScene.Run(monster);

                CustomMethods.WaitForKeyPress();

                Console.Clear();
                monster.Display();
                MyGame.player.Display();

                if (MyGame.player.IsDead || monster.IsDead)

                {
                    break;
                }

               MonsterAttackScene monsterAttackScene = new MonsterAttackScene(MyGame);

               monsterAttackScene.Run(monster);
               CustomMethods.WaitForKeyPress();

            }

            if (monster.IsDead)

            {
                monster.OnDefeat(MyGame.player);
                return;
            }

            if (MyGame.player.IsDead)

            {
                MyGame.player.Dies();
                
            }
        }
    }
}
