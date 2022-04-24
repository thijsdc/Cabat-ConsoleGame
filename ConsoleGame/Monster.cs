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
        public int BaseAttack;
        public int ExperiencePoints; 
        



        public Monster()

        {
            Healing_Level = 1;
            Attack_Level = 1;

            StaticWeightedRandomizer<int> levels = new StaticWeightedRandomizer<int>() { { 1, 60 }, {2,30}, {3,10} };
            Level = levels.NextWithReplacement();        

        }

        public override int Attack(Character otherCharacter)

        {
            int RandomAttackValue = Rnd.Next(BaseAttack, MaxAttack);
            otherCharacter.TakeDamage(RandomAttackValue);

            return RandomAttackValue;
        }


        public void OnDefeat(Player player)

        {
            
            Console.WriteLine($"{player.Name} defeated {Name}.");
            
            player.ResetHealth();
            player.ResetMana();

            player.LootMonster(this);

            player.AddExperience(ExperiencePoints);           

            if (player.Experience >= player.Experience_Needed) player.LevelUp();

            if(this is Ferumbras && player.HasKey == false)

            {
                Console.WriteLine("You obtained Ferumbras's masterkey.");
                player.HasKey = true;
            }

            if (this is Rat_Queen && player.HasRatTail == false)

            {
                Console.WriteLine("You now possess the Queen Rat's tail.");
                player.HasRatTail = true;
            }

            
            CustomMethods.WaitForKeyPress();


        }

        public override void Display()

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ForegroundColor = color;
            WriteLine($"\n{Art}\n");
            ResetColor();
            BackgroundColor = ConsoleColor.DarkMagenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine($"--- {Name} - {LevelToStar(Level)} ---");
            ResetColor();
            DisplayHealthBar();

        }

        public string LevelToStar(int level)

        {
            //✶
            return new string('✶', level);
        }

        


    }


}

