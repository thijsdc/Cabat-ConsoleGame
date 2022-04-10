using System;
using System.Collections.Generic;
using System.Text;
using Weighted_Randomizer;

namespace ConsoleGame
{
   public class Location
    {

       public string Name;
       public string Art;
      

       public virtual Monster SelectRandomMonster()

        {
            Monster monster = new Monster();
            return monster;
        }



    }
}
