using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;


namespace ConsoleGame
{
   public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health_Points { get; set; }
        public int Current_Health;
        public int Healing_Level { get; set; }
        public int Attack_Level { get; set; }
        public int Gold { get; set; }
        public int BaseAttack;
        public string Art;
        public ConsoleColor color;
        public bool IsDead { get => Current_Health <= 0;}
        public bool IsAlive { get => Current_Health > 0; }
        public Random Rnd;

        public Character()

        {
            Rnd = new Random();
            

        }

        public void SetName(string name)

        {
            Name = name;
        }

        public virtual void Display()

        {
            
            ForegroundColor = color;
            WriteLine($"\n{Art}\n");
            ResetColor();
            BackgroundColor = ConsoleColor.DarkMagenta;
            ForegroundColor = ConsoleColor.White;
            WriteLine($"--- {Name} - ({Level}) ---");
            ResetColor();
            
            
        }

        public void DisplayWithoutHealthBar()

        {
            ForegroundColor = color;
            WriteLine($"\n{Art}\n");
            ResetColor();            
        }

        public virtual void Fight(Character otherCharacter)

        {
            
            BaseAttack = Attack_Level * 10;

            int RandomAttackValue = Rnd.Next(BaseAttack, BaseAttack + 10);

            otherCharacter.TakeDamage(RandomAttackValue);

                       

            if (otherCharacter.Current_Health <= 0)

            {
                Clear();
                Display();
                otherCharacter.Display();
                Console.WriteLine($"{Name} (level {Level}) did {RandomAttackValue} damage and defeated the {otherCharacter.Name}!");
            }

            else

            {
                Clear();
                Display();
                otherCharacter.Display();                
                Console.WriteLine($"{Name} (level {Level}) did {RandomAttackValue} damage, {otherCharacter.Name} now has {otherCharacter.Current_Health} health!");
            }


        }

        public void TakeDamage(int damageAmount)

        {
            Current_Health -= damageAmount;

            if (Current_Health < 0) Current_Health = 0;
        }

        public void DisplayHealthBar()

        {

            
            BackgroundColor = ConsoleColor.Green;

            double NormalizedCurrentHealth = ((double) Current_Health) / Health_Points * 100;           
            int NormalizedCurrentHealthInt = (int)NormalizedCurrentHealth;
            
            

            for(int i = 0; i < NormalizedCurrentHealthInt; i+= 2)

            {
                Write(" ");
            }

            BackgroundColor = ConsoleColor.Red;

            for(int i = NormalizedCurrentHealthInt; i < 100; i += 2)

            {
                Write(" ");
            }
            ResetColor();
            WriteLine($" {Current_Health}/{Health_Points}");
            WriteLine();

            
        }

    }
}
