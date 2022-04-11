using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Rat_Queen : Monster
    {
        public Rat_Queen()

        {
            Level = 1;
            Health_Points = 250;
            Current_Health = Health_Points;
            Gold = 150;
            BaseAttack = 40;
            MaxAttack = 60;
            ExperiencePoints = 250;
            color = ConsoleColor.Red;
            Name = "Rat Queen";
            Art = @"
       __             _,-""~^""-.
     _// )      _,-""~`         `.
   ."" ( /`""-,-""`                 ;
  / 6                             ;
 /           ,             ,-""     ;
(,__.--.      \           /        ;
 //'   /`-.\   |          |        `._________
   _.-'_/`  )  )--...,,,___\     \-----------,)
 (((""~` _.-'.-'           __`-.   )         //
   jgs (((""`             (((---~""`         //
                                          ((________________
                                          `----""""""""~~~~^^^```";
            

        }
    }
}
