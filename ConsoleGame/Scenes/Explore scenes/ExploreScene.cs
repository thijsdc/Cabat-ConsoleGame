using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes
{
    class ExploreScene : Scene
    {

        Random Rnd;
       
        public ExploreScene(Game game) : base(game)

        {
            Rnd = new Random();
            
        }

        public override void Run()

        {

            switch(MyGame.player.Player_Location.Name)

            {
                case "Thais":
                    MyGame.exploreThaisScene.Run();
                    break;
                case "Ferumbras Forest":
                    MyGame.exploreFerumbrasForestScene.Run();
                    break;
                case "Cabat Castle":
                    MyGame.exploreCabatCastleScene.Run();
                    break;

            }

        }
    }
}
