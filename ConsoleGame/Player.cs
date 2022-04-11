using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Console;
using System.Threading;

namespace ConsoleGame
{
    public class Player : Character
    {

        public int Experience { get; set; }        
        public int Experience_Needed { get; set; }
        public Location Player_Location { get; set; }
        public int Mana_Points { get; set; }
        public int Current_Mana { get; set; }
        public int Mana_Potions { get; set; }      
        public int Amulet_of_Life { get; set; }

        public bool HasRatTail { get; set; }
        public bool HasKey { get; set; }
        public bool HasFerumbrasTravelPermit { get; set; }
        public bool HasCabatCastleTravelPermit { get; set; }


        public Player()

        {
            Name = "Name";
            Level = 1;
            Experience = 0;
            Health_Points = 100;
            Current_Health = Health_Points;
            Mana_Points = 100;
            Mana_Potions = 1;
            Current_Mana = Mana_Points;
            Attack_Level = 1;
            Healing_Level = 1;
            Experience_Needed = 100;
            Player_Location = new Thais();
            Gold = 0;
            Amulet_of_Life = 0;

            HasRatTail = false;
            HasKey = false;
            HasFerumbrasTravelPermit = false;
            HasCabatCastleTravelPermit = false;
            

            color = ConsoleColor.Green;
            Art = @"
|\             //
 \\           _!_
  \\         /___\
   \\        [+++]
    \\    _ _\^^^/_ _
     \\/ (    '-'  ( )
     /( \/ | {&}   /\ \
       \  / \     / _> )
        ""`   >:::;-'`""""'-.
            /:::/         \
           /  /||   {&}   |
          (  / (\         /
          / /   \'-.___.-'
    jgs _/ /     \ \
       /___|    /___|";

        }

        
        public void Attack(Character otherCharacter)

        {
            int BaseAttack = Attack_Level * 10;
            int RandomAttackValue = Rnd.Next(BaseAttack, BaseAttack + 10);

            otherCharacter.TakeDamage(RandomAttackValue);

            if (otherCharacter.Health_Points <= 0)

            {
                Console.Clear();
                otherCharacter.Display();
                Display();
                Console.WriteLine($"{Name} (level {Level}) did {RandomAttackValue} damage and defeated the {otherCharacter.Name}!");
            }

            else

            {
                Console.Clear();
                otherCharacter.Display();
                Display();
                Console.WriteLine($"{Name} (level {Level}) did {RandomAttackValue} damage.");
            }

            

        }
           
        public void LevelUp()

        {
            Level += 1;
            Console.WriteLine($"You leveled up!");

            Health_Points += 20;
            ResetHealth();          

                        
            Experience -= Experience_Needed;

            Experience_Needed = (int)(Experience_Needed * 1.5);
            
            Console.WriteLine($"You require {Experience_Needed} total experience to level up again.");
            CustomMethods.WaitForKeyPress();
            StatsUpgrade();

        }

        public void StatsUpgrade()

        {
            Console.Clear();
            Display();
            Console.WriteLine();

            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;

            string prompt = "Which stat would you like to level up?";
            string[] options =
            {
                "attack",
                "healing",
                "Mana points"

            };

            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run(cursorleft, cursortop);

            switch (selectedIndex)

            {
                case 0:
                   Attack_Level += 1;
                    Console.WriteLine($"You upgraded your attack level strength to {Attack_Level}.");
                    break;
                case 1:
                    Healing_Level += 1;
                    Console.WriteLine($"You upgraded your healing level to {Healing_Level}.");
                    break;
                case 2:
                    Mana_Points += 25;
                    Console.WriteLine($"You now have {Mana_Points} mana points.");
                    break;

            }
        }
        
        public void Dies()

        {
            Console.Clear();
            Console.WriteLine(@"

           _..--""""---.
          /           "".
          `            l
          |'._  ,._ l/""\
          |  _J<__/.v._/
           \( ,~._,,,,-)
            `-\' \`,,j|
               \_,____J
          .--.__)--(__.--.
         /  `-----..--'. j
         '.- '`--` `--' \\
        //  '`---'`  `-' \\
       //   '`----'`.-.-' \\
     _//     `--- -'   \' | \________
    |  |         ) (      `.__.---- -'\
     \7          \`-(               74\\\
     ||       _  /`-(               l|//7__
     |l    ('  `-)-/_.--.          f''` -.-""|
     |\     l\_  `-'    .'         |     |  |
     llJ   _ _)J--._.-('           |     |  l
     |||( ( '_)_  .l   "". _    ..__I     |  L
     ^\\\||`'   ""   '""-. "" )''`'---'     L.-'`-.._
          \ |           ) /.              ``'`-.._``-.
          l l          / / |                      |''|
           "" \        / /   ""-..__                |  |
           | |       / /          1       ,- t-...J_.'
           | |      / /           |       |  |
           J  \  /""  (            l       |  |
           | ().'`-()/            |       |  |
          _.-""_.____/             l       l.-l
      _.-""_.+""|                  /        \.  \
/""\.-""_.-""  | |                 /          \   \
\_   ""      | |                1            | `'|
  |ll       | |                |            i   |
  \\\       |-\               \j ..          L,,'. `/
 __\\\     ( .-\           .--'    ``--../..'      '-..
   `'''`----`\\\\ .....--'''
              \\\\                                   ");
            CustomMethods.WaitForKeyPress();
            CustomMethods.WritingAnimation("Alas! Brave adventurer, you have met a sad fate.",25);
            CustomMethods.WritingAnimation("But do not despair, for the gods will bring you back into the world in exchange for a small sacrifice.",25);

            if(Amulet_of_Life > 0)

            {
                Amulet_of_Life -= 1;
                Current_Health = Health_Points;
                Console.WriteLine("You used an amulet of life to prevent your player stats from resetting.");
                CustomMethods.WaitForKeyPress();                
                
                return;

            }

            else
            {
                PlayerReset();
                CustomMethods.WaitForKeyPress();
                Console.WriteLine("You have been teleported back to Thais.");
                
                               
                
            }
                    
           
        }

        public void PlayerReset()

        {

            Health_Points = 100;
            Current_Health = 100;
            Mana_Points = 100;
            Current_Mana = 100;
            Mana_Potions = 1;
            Amulet_of_Life = 0;
            Level = 1;
            Experience = 0;
            Experience_Needed = 100;
            Healing_Level = 1;
            Attack_Level = 1;
            Gold = 0;
            HasKey = false;
            HasRatTail = false;
            HasFerumbrasTravelPermit = false;
            HasCabatCastleTravelPermit = false;            
            Player_Location = new Thais();

            Console.WriteLine("Player values have been resetted.");

        }

        public void PlayerStats()

        {
            Console.Clear();

            Display();

            Console.WriteLine("These are your stats:");
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Level: {Level}");
            Console.WriteLine($"- Health Points: {Health_Points}");
            Console.WriteLine($"- Mana Points: {Mana_Points}");
            Console.WriteLine($"- Attack Level: {Attack_Level}");
            Console.WriteLine($"- Healing Level: {Healing_Level}");
            Console.WriteLine($"- Gold: {Gold}");
            Console.WriteLine($"- Mana potions: {Mana_Potions}");
            Console.WriteLine($"- Amulet of Life: {Amulet_of_Life}");
            Console.WriteLine($"- Location: {Player_Location.Name}");

            CustomMethods.WaitForKeyPress();

        }

        public void SetPlayerLocation(Location location)

        {
            Player_Location = location;
                       
        }

        public void AddExperience(int experienceGained)

        {
            Experience += experienceGained; 
            Console.WriteLine($"{Name} gained {experienceGained} experience ({Experience}/{Experience_Needed})!");
        }

        public void ResetHealth()

        {
            Current_Health = Health_Points;
        }

        public void ResetMana()

        {
            Current_Mana = Mana_Points;
        }

        public override void Display()

        {

            
            base.Display();
            DisplayHealthBar();
            DisplayManaBar();


        }

        public void DisplayManaBar()

        {


            BackgroundColor = ConsoleColor.Blue;

            double NormalizedCurrentMana = ((double)Current_Mana) / Mana_Points * 100;
            int NormalizedCurrentManaInt = (int)NormalizedCurrentMana;



            for (int i = 0; i < NormalizedCurrentManaInt; i += 2)

            {
                Write(" ");
            }

            BackgroundColor = ConsoleColor.Black;

            for (int i = NormalizedCurrentManaInt; i < 100; i += 2)

            {
                Write(" ");
            }
            ResetColor();
            WriteLine($" {Current_Mana}/{Mana_Points}");
            WriteLine();


        }

        public void Heal()

        {
            int currentHealth = Current_Health;
            int BaseHeal = 25 + Healing_Level * 25;
            int current_Heal_Value = Rnd.Next(BaseHeal, BaseHeal + 15);
            Current_Mana -= 25;

            Clear();
            DisplayWithoutHealthBar();
            int cursorleft = Console.CursorLeft;
            int cursortop = Console.CursorTop;
            

            if (currentHealth + current_Heal_Value >= Health_Points)

            {
                for (int i = currentHealth; i < Health_Points; i++)

                {
                    Current_Health++;
                    SetCursorPosition(cursorleft, cursortop);
                    DisplayHealthBar();
                    DisplayManaBar();
                    Thread.Sleep(25);


                }
            }

            else
            {
                for (int i = currentHealth; i < currentHealth + current_Heal_Value; i++)

                {
                    Current_Health++;
                    SetCursorPosition(cursorleft, cursortop);
                    DisplayHealthBar();
                    DisplayManaBar();
                    Thread.Sleep(25);

                }
            }


            WriteLine($"{Name} healed for {current_Heal_Value} health and has {Current_Health}/{Health_Points} health.");

        }

        public void UseManaPotion()

        {

           Current_Mana = Current_Mana + 50 >= Mana_Points ?  Mana_Points : Current_Mana += 50;

           Mana_Potions -= 1;

            Console.Clear();
            Display();
            Console.WriteLine("You consumed a mana potion.");

        }

        public void LootMonster(Monster monster)

        {
            Gold += monster.Gold;
            Console.WriteLine($"{monster.Name} dropped {monster.Gold} gold.");
        }

    }

}

