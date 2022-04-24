using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Cabat : Monster
    {
        public Cabat()

        {
            Health_Points = 400 + (50 * Level);
            Current_Health = Health_Points;            
            BaseAttack = 100;
            MaxAttack = BaseAttack + (20 * Level);            
            ExperiencePoints = 1200 + (250 * Level);
            Gold = Rnd.Next(150, 200);
            color = ConsoleColor.Magenta;
            Name = "Cabat";
            Art = @"
                      _..-'(                       )`-.._
                   ./'. '||\\.       (\_/)       .//||` .`\.
                ./'.|'.'||||\\|..    )O O(    ..|//||||`.`|.`\.
             ./'..|'.|| |||||\`````` '`""'` ''''''/||||| ||.`|..`\.
           ./'.||'.|||| ||||||||||||.     .|||||||||||| |||||.`||.`\.
          /'|||'.|||||| ||||||||||||{     }|||||||||||| ||||||.`|||`\
         '.|||'.||||||| ||||||||||||{     }|||||||||||| |||||||.`|||.`
        '.||| ||||||||| |/'   ``\||``     ''||/''   `\| ||||||||| |||.`
        |/' \./'     `\./         \!|\   /|!/         \./'     `\./ `\|
        V    V         V          }' `\ /' `{          V         V    V
        `    `         `               V               '         '    '";

        }
    }
}
