using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Giant_Rat : Monster
    {
       public Giant_Rat()

        {
            Health_Points = 75 + (10 * Level);            
            Current_Health = Health_Points;
            BaseAttack = 30;
            MaxAttack = BaseAttack + (10 * Level);
            ExperiencePoints = 100 + (10 * Level);
            Gold = Rnd.Next(25, 40);
            color = ConsoleColor.DarkGreen               ;
            Name = "Giant Rat";
            Art = @"               _     __,..---""""-._                 ';-,
        ,    _/_),-""`             '-.                `\\
       \|.-""`    -_)                 '.                ||
       /`   a   ,                      \              .'/
       '.___,__/                 .-'    \_        _.-'.'
          |\  \      \         /`        _`""""""""""""`_.-'
             _/;--._, >        |   --.__/ `""""""""""""`
           (((-'  __//`'-......-;\      )
                (((-'       __//  '--. /
                          (((-'    __//
                                 (((-'";

        }
    }
}
