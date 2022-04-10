using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    public class Rat : Monster
    {
       public Rat()

        {
            Health_Points = 40 + (10 * Level);            
            Current_Health = Health_Points;
            BaseAttack = 20;
            MaxAttack = BaseAttack + (10 * Level);
            ExperiencePoints = 50 + (10 * Level);
            Gold = Rnd.Next(10, 20);
            color = ConsoleColor.DarkGray;
            Name = "Rat";
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
