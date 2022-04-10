using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Bat : Monster
    {
        public Bat()

        {
            Health_Points = 450 + (50 * Level);            
            Current_Health = Health_Points;
            BaseAttack = 80;
            MaxAttack = BaseAttack + (20 * Level);
            ExperiencePoints = 300 + (30 * Level);
            Gold = Rnd.Next(100, 150);
            color = ConsoleColor.Cyan;
            Name = "Bat";
            Art = @"
    =/\                 /\=
    / \'._   (\_/)   _.'/ \
   / .''._'--(o.o)--'_.''. \
  /.' _/ |`'=/ "" \='`| \_ `.\
 /` .' `\;-,'\___/',-;/` '. '\
/.-'       `\(-V-)/`       `-.\
`            ""   ""            `
";

        }
    }
}
