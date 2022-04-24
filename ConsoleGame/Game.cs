using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static ConsoleGame.CustomMethods;
using ConsoleGame.Scenes;
using ConsoleGame.Scenes.Explore_scenes;
using System.Diagnostics;

namespace ConsoleGame
{
    class Game
    {

        public Player player;
        public TitleScene titleScene;
        public MainMenuScene mainMenuScene;
        public ExploreScene exploreScene;
        public ExploreThaisScene exploreThaisScene;
        public ExploreFerumbrasForestScene exploreFerumbrasForestScene;
        public ExploreCabatCastleScene exploreCabatCastleScene;
        public CombatScene combatScene;
        public TravelScene travelScene;
        public PlayerFightOptionsScene playerFightOptionsScene;
        public EnterWellScene enterWellScene;
        public EnterTreeHouseScene enterTreeHouseScene;
        public EnterDoorScene enterDoorScene;
        public MerchantScene merchantScene;
        public EndScene endScene;
        public Stopwatch stopWatch;

        public Game()

        {
            player = new Player();
            titleScene = new TitleScene(this);
            mainMenuScene = new MainMenuScene(this);
            exploreScene = new ExploreScene(this);
            exploreThaisScene = new ExploreThaisScene(this);
            exploreFerumbrasForestScene = new ExploreFerumbrasForestScene(this);
            exploreCabatCastleScene = new ExploreCabatCastleScene(this);
            combatScene = new CombatScene(this);
            travelScene = new TravelScene(this);
            playerFightOptionsScene = new PlayerFightOptionsScene(this);
            enterWellScene = new EnterWellScene(this);
            enterTreeHouseScene = new EnterTreeHouseScene(this);
            enterDoorScene = new EnterDoorScene(this);
            merchantScene = new MerchantScene(this); 
            endScene = new EndScene(this);
            stopWatch = Stopwatch.StartNew();

        }

        public void Run()

        {
            titleScene.Run();
            mainMenuScene.Run();
            
        }




        public void CloseGame()

        {
            WriteLine("Closing the game.");
            Environment.Exit(0);
        }
    }
}
