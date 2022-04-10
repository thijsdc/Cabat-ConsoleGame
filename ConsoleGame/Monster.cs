using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Weighted_Randomizer;

namespace ConsoleGame
{
   public class Monster : Character
    {
        
        
        public int MaxAttack;
        public int ExperiencePoints; 
        



        public Monster()

        {
            Healing_Level = 1;
            Attack_Level = 1;

            StaticWeightedRandomizer<int> levels = new StaticWeightedRandomizer<int>() { { 1, 60 }, {2,30}, {3,10} };
            Level = levels.NextWithReplacement();        

        }

        public override void Fight(Character otherCharacter)
        {
            int CurrentAttackValue = Rnd.Next(BaseAttack, MaxAttack);
            otherCharacter.Current_Health -= CurrentAttackValue;

            if (otherCharacter.IsAlive)

            {

                Console.WriteLine($"{Name} attacked you for {CurrentAttackValue} damage.");
            }

            else
            {
                Console.WriteLine($"{Name} attacked you for {CurrentAttackValue} damage and killed you!.");                

            }

            
        }
            
        public void OnDefeat(Player player)

        {
            
            Console.WriteLine($"{player.Name} defeated {Name}.");
            
            player.ResetHealth();
            player.ResetMana();

            player.LootMonster(this);

            player.AddExperience(ExperiencePoints);           

            if (player.Experience >= player.Experience_Needed) player.LevelUp();

            if(this is Ferumbras)

            {
                Console.WriteLine("You obtained Ferumbras's masterkey.");
                player.HasKey = true;
            }

            if (this is Rat_Queen)

            {
                Console.WriteLine("You now possess the Queen Rat's tail.");
                player.HasRatTail = true;
            }

            
            CustomMethods.WaitForKeyPress();


        }

        public override void Display()

        {

            base.Display();            
            DisplayHealthBar();

        }

        


    }


}

