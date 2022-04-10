using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    public class Troll : Monster
    {
       public Troll()

        {
            Health_Points = 220 + (30 * Level);
            Current_Health = Health_Points;            
            BaseAttack = 40;
            MaxAttack = 50 + (10 * Level);
            ExperiencePoints = 200 + (20 * Level);
            Gold = Rnd.Next(75, 100);
            color = ConsoleColor.Blue;
            Name = "Troll";
            Art = @"
      -. -. `.  / .-' _.'  _
     .--`. `. `| / __.-- _' `
    '.-.  \  \ |  /   _.' `_
    .-. \  `  || |  .' _.-' `.
  .' _ \ '  -    -'  - ` _.-.
   .' `. %%%%%   | %%%%% _.-.`-
 .' .-. ><(@)> ) ( <(@)>< .-.`.
   ((""`(   -   | |   -   )'""))
  / \\#)\    (.(_).)    /(#//\
 ' / ) ((  /   | |   \  )) (`.`.
 .'  (.) \ .md88o88bm. / (.) \)
   / /| / \ `Y88888Y' / \ | \ \
 .' / O  / `.   -   .' \  O \ \\
  / /(O)/ /| `.___.' | \\(O) \
   / / / / |  |   |  |\  \  \ \
   / / // /|  |   |  |  \  \ \  VK
 _.--/--/'( ) ) ( ) ) )`\-\-\-._
( ( ( ) ( ) ) ( ) ) ( ) ) ) ( ) )";

        }
    }
}
