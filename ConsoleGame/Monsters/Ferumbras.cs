using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Ferumbras : Monster
    {
        public Ferumbras()

        {
            Level = 1;
            Health_Points = 500;
            Current_Health = Health_Points;
            BaseAttack = 100;
            MaxAttack = 150;
            ExperiencePoints = 2000;
            color = ConsoleColor.Yellow;
            Name = "Ferumbras";
            Art = @"
                    ____ 
                  .'* *.'
               __/_*_*(_
              / _______ \
             _\_)/___\(_/_ 
            / _((\- -/))_ \
            \ \())(-)(()/ /
             ' \(((()))/ '
            / ' \)).))/ ' \
           / _ \ - | - /_  \
          (   ( .;''';. .'  )
          _\""__ /    )\ __""/_
            \/  \   ' /  \/
             .'  '...' ' )
              / /  |  \ \
             / .   .   . \
            /   .     .   \
           /   /   |   \   \
         .'   /    b    '.  '.
     _.-'    /     Bb     '-. '-._ 
 _.-'       |      BBb       '-.  '-. 
(________mrf\____.dBBBb.________)____)";

        }
    }
}
