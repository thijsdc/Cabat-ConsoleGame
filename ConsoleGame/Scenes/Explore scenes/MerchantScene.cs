using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Scenes.Explore_scenes
{
    class MerchantScene : Scene
    {

        public MerchantScene(Game game) : base(game)

        {

        }

        public override void Run()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ArtAssets.Merchant);
            Console.ResetColor();
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string Prompt = $"What would you like to buy {MyGame.player.Name} (Gold: {MyGame.player.Gold})?";
            string[] Options = {"Mana Potion (100)", "Travel permit to Ferumbras Forest (350)", "Travel permit to Cabat Castle (1000)", "Amulet of Life (1500)","Leave" };
            Menu mainMenu = new Menu(Prompt, Options);
            int selectedIndex = mainMenu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                    if (MyGame.player.Gold < 100)

                    {
                        InsufficientFunds(100);
                    }

                    else

                    {
                        MyGame.player.Gold -= 100;
                        MyGame.player.Mana_Potions += 1;
                        Console.WriteLine("Thank you for buying a mana potion.");
                        CustomMethods.WaitForKeyPress();
                        
                    }
                    MyGame.merchantScene.Run();
                    break;
                case 1:
                    if (MyGame.player.Gold < 350)

                    {
                        InsufficientFunds(350);
                    }

                    else

                    {
                        MyGame.player.HasFerumbrasTravelPermit = true;
                        MyGame.player.Gold -= 350;
                        Console.WriteLine("Thank you for buying a travel permit to Ferumbras Forest.");
                        CustomMethods.WaitForKeyPress();

                    }
                    MyGame.merchantScene.Run();
                    break;                    
                case 2:
                    if (MyGame.player.Gold < 1000)

                    {
                        InsufficientFunds(1000);
                    }

                    else

                    {
                        MyGame.player.HasCabatCastleTravelPermit = true;
                        MyGame.player.Gold -= 1000;
                        Console.WriteLine("Thank you for buying a travel permit to Cabat Castle.");
                        CustomMethods.WaitForKeyPress();

                    }
                    MyGame.merchantScene.Run();
                    break;
                   
                case 3:
                    if (MyGame.player.Gold < 1250)

                    {
                        InsufficientFunds(1500);
                    }

                    else

                    {
                        
                        MyGame.player.Amulet_of_Life += 1;
                        MyGame.player.Gold -= 1250;
                        Console.WriteLine("Thank you for buying an Amulet of Life. This amulet will protect you upon death.");
                        CustomMethods.WaitForKeyPress();

                    }
                    MyGame.merchantScene.Run();
                    break;                  
                                  
                case 4:
                    //MyGame.exploreThaisScene.Run();
                    break;

            }
        }

        public void InsufficientFunds(int money)

        {
                        
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(ArtAssets.Merchant);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"You can not afford this item... you need {money} gold.");
                CustomMethods.WaitForKeyPress();
                
        }
    }

}
