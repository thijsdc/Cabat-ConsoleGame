using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    public class Skeleton : Monster
    {
       public Skeleton()

        {
            Health_Points = 170 + (30 * Level);
            Current_Health = Health_Points;            
            BaseAttack = 35;
            MaxAttack = 45 + (10 * Level);
            ExperiencePoints = 140 + (10 * Level);
            Gold = Rnd.Next(35, 50);
            color = ConsoleColor.White;
            Name = "Skeleton";
            Art = @"
      .-.
     (o.o)
      |=|
     __|__
   //.=|=.\\
  // .=|=. \\
  \\ .=|=. //
   \\(_=_)//
    (:| |:)
     || ||
     () ()
     || ||
     || ||
    ==' '==";

        }
    }
}
