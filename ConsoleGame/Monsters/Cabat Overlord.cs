using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public class Cabat_Overlord : Monster
    {
        public Cabat_Overlord()

        {
            Level = 1;
            Health_Points = 1000;
            Current_Health = Health_Points;
            BaseAttack = 150;
            MaxAttack = 250;
            ExperiencePoints = 50000;
            color = ConsoleColor.Red;
            Name = "Cabat Overlord";
            Art = @"
              /|                                           |\                 
             /||             ^               ^             ||\                
            / \\__          //               \\          __// \               
           /  |_  \         | \   /     \   / |         /  _|  \              
          /  /  \  \         \  \/ \---/ \/  /         /  /     \             
         /  /    |  \         \  \/\   /\/  /         /  |       \            
        /  /     \   \__       \ ( 0\ /0 ) /       __/   /        \           
       /  /       \     \___    \ \_/|\_/ /    ___/     /\         \          
      /  /         \_)      \___ \/-\|/-\/ ___/      (_/\ \      `  \         
     /  /           /\__)       \/  oVo  \/       (__/   ` \      `  \        
    /  /           /,   \__)    (_/\ _ /\_)    (__/         `      \  \       
   /  '           //       \__)  (__V_V__)  (__/                    \  \      
  /  '  '        /'           \   |{___}|   /         .              \  \     
 /  '  /        /              \/ |{___}| \/\          `              \  \    
/     /        '       .        \/{_____}\/  \          \    `         \  \   
     /                ,         /{_______}\   \          \    \         \     
                     /         /{___/_\___}\   `          \    `";

        }
    }
}
