using System;
using System.Collections.Generic;
using System.Text;
using Weighted_Randomizer;

namespace ConsoleGame
{
    public class Ferumbras_Forest : Location
    {

        public Ferumbras_Forest()

        {
            Name = "Ferumbras Forest";     

            Art = @"
            .        +          .      .          .
     .            _        .                    .
  ,              /;-._,-.____        ,-----.__
 ((        .    (_:#::_.:::. `-._   /:, /-._, `._,
  `                 \   _|`""=:_::.`.);  \ __/ /
                      ,    `./  \:. `.   )==-'  .
    .      ., ,-=-.  ,\, +#./`   \:.  / /           .
.           \/:/`-' , ,\ '` ` `   ): , /_  -o
       .    /:+- - + +- : :- + + -:'  /(o-) \)     .
  .      ,=':  \    ` `/` ' , , ,:' `'--"".--""---._/`7
   `.   (    \: \,-._` ` + '\, ,""   _,--._,---"":.__/
              \:  `  X` _| _,\/'   .-'
.               "":._:`\____  /:'  /      .           .
                    \::.  :\/:'  /              +
   .                 `.:.  /:'  }      .
           .           ):_(:;   \           .
                      /:. _/ ,  |
                   . (|::.     ,`                  .
     .                |::.    {\
                      |::.\  \ `.
                      |:::(\    |
              O       |:::/{ }  |                  (o
               )  ___/#\::`/ (O ""==._____   O, (O  /`
          ~~~w/w~""~~,\` `:/,-(~`""~~~~~~~~""~o~\~/~w|/~
       ~~~~~~~~~~~~~~~~~~~~~~~\\W~~~~~~~~~~~~\|/~~";
            //https://asciiart.website/index.php?art=plants/trees
        }

        public override Monster SelectRandomMonster()
        {
            StaticWeightedRandomizer<Monster> monsters = new StaticWeightedRandomizer<Monster>();

            monsters.Add(new Skeleton(), 70);
            monsters.Add(new Troll(), 30); 

            return monsters.NextWithReplacement();

        }


    }
}
