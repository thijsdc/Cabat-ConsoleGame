using System;
using System.Collections.Generic;
using System.Text;
using Weighted_Randomizer;

namespace ConsoleGame
{
    public class Cabat_Castle : Location
    {

        public Cabat_Castle()

        {
            Name = "Cabat Castle";            
            Art = @"
                           .-----.
                         .'       `.
                        :      ^v^  :
                        :           :
                        '           '
         |~        www   `.       .'
        /.\       /#^^\_   `-/\--'
       /#  \     /#%    \   /# \
      /#%   \   /#%______\ /#%__\
     /#%     \   |= I I ||  |- |
     ~~|~~~|~~   |_=_-__|'  |[]|
       |[] |_______\__|/_ _ |= |`.
^V^    |-  /= __   __    /-\|= | :;
       |= /- /\/  /\/   /=- \.-' :;
       | /_.=========._/_.-._\  .:'
       |= |-.'.- .'.- |  /|\ |.:'
       \  |=|:|= |:| =| |~|~||'|
        |~|-|:| -|:|  |-|~|~||=|      ^V^
        |=|=|:|- |:|- | |~|~|| |
        | |-_~__=_~__=|_^^^^^|/___
        |-(=-=-=-=-=-(|=====/=_-=/\
        | |=_-= _=- _=| -_=/=_-_/__\ 
        | |- _ =_-  _-|=_- |]#| I II
        |=|_/ \_-_= - |- = |]#| I II
        | /  _/ \. -_=| =__|]!!!I_II!!
       _|/-'/  ` \_/ \|/' _ ^^^^`.==_^.
     _/  _/`-./`-; `-.\_ / \_'\`. `. ===`.
    / .-'  __/_   `.   _/.' .-' `-. ; ====;\
   /.   `./    \ `. \ / -  /  .-'.' ====='  >
  /  \  /  .-' `--.  / .' /  `-.' ======.' /";
            // https://www.asciiart.eu/buildings-and-places/other
        }

        public override Monster SelectRandomMonster()
        {
            StaticWeightedRandomizer<Monster> monsters = new StaticWeightedRandomizer<Monster>();

            monsters.Add(new Bat(), 70);
            monsters.Add(new Cabat(), 30);

            return monsters.NextWithReplacement();

        }


    }
}
