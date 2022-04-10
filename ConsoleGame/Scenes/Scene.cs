using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class Scene
    {
        protected Game MyGame;

        public Scene(Game game)

        {
            MyGame = game;
        }

        virtual public void Run()

        {

        }

        virtual public void Run(Monster monster)

        {

        }


    }
}
