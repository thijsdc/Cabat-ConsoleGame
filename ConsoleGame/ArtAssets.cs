using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
   public static class ArtAssets
    {
        public static string Door = @"
                    _             _,-----------._        ___
|                  (_,.-      _,-'_,-----------._`-._    _)_)
                      |     ,'_,-'  ___________  `-._`.
                     `'   ,','  _,-'___________`-._  `.`.
                  ,','  ,'_,-'     .     `-._`.  `.`.
                       /,'  ,','        >|<        `.`.  `.\
                      //  ,','      ><  ,^.  ><      `.`.  \\
                     //  /,'      ><   / | \   ><      `.\  \\
                    //  //      ><    \/\^/\/    ><      \\  \\
                   ;;  ;;              `---'              ::  ::
                   ||  ||              (____              ||  ||
                  _||__||_            ,'----.            _||__||_
                 (o.____.o)____        `---'        ____(o.____.o)
                   |    | /,--.)                   (,--.\ |    |
                   |    |((  -`___               ___`   ))|    |
                   |    | \\,'',  `.           .'  .``.// |    |
                   |    |  // (___,'.         .'.___) \\  |    |
                  /|    | ;;))  ____) .     . (____  ((\\ |    |\
                  \|.__ | ||/ .'.--.\/       `/,--.`. \;: | __,|;
                   |`-,`;.| :/ /,'  `)-'   `-('  `.\ \: |.;',-'|
                   |   `..  ' / \__.'         `.__/ \ `  ,.'   |
                   |    |,\  /,                     ,\  /,|    |
                   |    ||: : )          .          ( : :||    |
                  /|    |:; |/  .      ./|\,      ,  \| :;|    |\
                  \|.__ |/  :  ,/-    <--:-->    ,\.  ;  \| __,|;
                   |`-.``:   `'/-.     '\|/`     ,-\`;   ;'',-'|
                   |   `..   ,' `'       '       `  `.   ,.'   |
                   |    ||  :                         :  ||    |
                   |    ||  |                         |  ||    |
                   |    ||  |                         |  ||    |
                   |    |'  |            _            |  `|    |
                   |    |   |          '|))           |   |    |
                   ;____:   `._        `'           _,'   ;____:
                  {______}     \___________________/     {______}
              SSt |______|_______________________________|______|
";

       public static string Well = @"
                 __
               .'/\'.
             .'-/__\-'.
           .'--/____\--'.
         .'--./______\.--'.
       .'--../________\..--'.
     .'--.._/__________\_..--'.
   .'--..__/____________\__..--'.
 .'--..___/______________\___..--'.
'========'================'========'
      [_|__]            [_|__]
     =[__|_]=====""""=====[__|_]==.
      [_|__]     '|     [_|__]  |
      [__|_]     |'     [__|_]  |
      [_|__]  .--JL--.  [_|__]  '===O
      [__|_]   \====/   [__|_]
      [_|__]_.-| .; |-._[_|__]
      [__|_]'._ \__/(_.'[__|_]
      [.-._]            [_.-.]
      [_.-.'--..____..--'.-._]
 (o)  [(_.'   .-.     .-.'._)\ (o)
(\'/) [  .-. (_.'.-. (_.' .-.](\'/)
   ;: [ (_.'.-. (_.' .-. (_.'| ;:'
;:    [ .-. '._) .-. '._).-. ]   ;:.
      [(_.'  .-. '._) .-.'._)]
  (o) /.-.  (_.'.-.  (_.' .-.];:(o)
 (\'/)['._).-. (_.'   .-.(_.'] (\'/)
      [   (_.'.-.  .-.'._)   \ ;:
;:'   '-._    '._) '._)   _.-'
  LGB      `---..____..---'   ;:`
   ;:'      ;:'.:;     ;;""";

       public static string ArtQueen = @"

                _ __
              /   \                  /      \
             '      \              /          \
            |       |Oo o|            |
            `    \  |OOOo......oOO|   /        |
             `    \\OOOOOOOOOOOOOOO\//        /
               \ _o\OOOOOOOOOOOOOOOO//. ___ /
           ______OOOOOOOOOOOOOOOOOOOOOOOo.___
            --- OO'* `OOOOOOOOOO'*  `OOOOO--
                OO.OOOOOOOOO'    .OOOOO o
                `OOOooOOOOOOOOOooooOOOOOO'OOOo
              .OO ""OOOOOOOOOOOOOOOOOOOO""OOOOOOOo
          __ OOOOOO`OOOOOOOOOOOOOOOO""OOOOOOOOOOOOo
         ___OOOOOOOO_""OOOOOOOOOOO""_OOOOOOOOOOOOOOOO
           OOOOO^OOOO0`(____)/""OOOOOOOOOOOOO^OOOOOO
           OOOOO OO000/000000\000000OOOOOOOO OOOOOO
           OOOOO O0000000000000000 ppppoooooOOOOOO
           `OOOOO 0000000000000000 QQQQ ""OOOOOOO""
            o""OOOO 000000000000000oooooOOoooooooO'
            OOo""OOOO.00000000000000000000OOOOOOOO'
           OOOOOO QQQQ 0000000000000000000OOOOOOO
          OOOOOO00eeee00000000000000000000OOOOOOOO.
         OOOOOOOO000000000000000000000000OOOOOOOOOO
         OOOOOOOOO00000000000000000000000OOOOOOOOOO
         `OOOOOOOOO000000000000000000000OOOOOOOOOOO
           ""OOOOOOOO0000000000000000000OOOOOOOOOOO'
             ""OOOOOOO00000000000000000OOOOOOOOOO""
  .ooooOOOOOOOo""OOOOOOO000000000000OOOOOOOOOOO""
.OOO"""""""""""""""""""".oOOOOOOOOOOOOOOOOOOOOOOOOOOOOo
OOO         QQQQO""'                     `""QQQQ
OOO
`OOo.
  `""OOOOOOOOOOOOoooooooo.";

        public static string TreeHouse = @"
                         vv
                     vvv^^^^vvvvv
                 vvvvvvvvv^^vvvvvv^^vvvvv
        vvvvvvvvvvv^^^^^^^^^^^^^vvvvv^^^vvvvv
    vvvvvvv^^^^^^^^^vvv^^^^^^^vvvvvvvvvvv^^^vvv
  vvvv^^^^^^vvvvv^^^^^^^vv^^^^^^^vvvv^^^vvvvvv
 vv^^^^^^^^vvv^^^^^vv^^^^vvvvvvvvvvvv^^^^^^vv^
 vvv^^^^^vvvv^^^^^^vvvvv^^vvvvvvvvv^^^^^^vvvvv^
  vvvvvvvvvv^^^v^^^vvvvvv^^vvvvvvvvvv^^^vvvvvvvvv
   ^vv^^^vvvvvvv^^vvvvv^^^^^^^^vvvvvvvvv^^^^^^vvvvvv
     ^vvvvvvvvv^^^^vvvvvv^^^^^^vvvvvvvv^^^vvvvvvvvvv^v
        ^^^^^^vvvv^^vvvvv^vvvv^^^v^^^^^^vvvvvv^^^^vvvvv
 vvvv^^vvv^^^vvvvvvvvvv^vvvvv^vvvvvv^^^vvvvvvv^^vvvvv^
vvv^vvvvv^^vvvvvvv^^vvvvvvv^^vvvvv^v##vvv^vvvv^^vvvvv^v
 ^vvvvvv^^vvvvvvvv^vv^vvv^^^^^^_____##^^^vvvvvvvv^^^^
    ^^vvvvvvv^^vvvvvvvvvv^^^^/\@@@@@@\#vvvv^^^
         ^^vvvvvv^^^^^^vvvvv/__\@@@@@@\^vvvv^v
             ;^^vvvvvvvvvvv/____\@@@@@@\vvvvvvv
             ;      \_  ^\|[  -:] ||--| | _/^^
             ;        \   |[   :] ||_/| |/
             ;         \\ ||___:]______/
             ;          \   ;=; /
             ;           |  ;=;|
             ;          ()  ;=;|
            (()          || ;=;|
                        / / \;=;\";

        public static string TheEnd = @"
  _____ _            _____           _ 
 |_   _| |__   ___  | ____|_ __   __| |
   | | | '_ \ / _ \ |  _| | '_ \ / _` |
   | | | | | |  __/ | |___| | | | (_| |
   |_| |_| |_|\___| |_____|_| |_|\__,_|
                                       ";

        public static string Cabat = @"
       _..._                                           
    .-'_..._''.                                        
  .' .'      '.\          /|                           
 / .'                     ||                           
. '                       ||                      .|   
| |                 __    ||  __        __      .' |_  
| |              .:--.'.  ||/'__ '.  .:--.'.  .'     | 
. '             / |   \ | |:/`  '. '/ |   \ |'--.  .-' 
 \ '.          .`"" __ | | ||     | |`"" __ | |   |  |   
  '. `._____.-'/ .'.''| | ||\    / ' .'.''| |   |  |   
    `-.______ / / /   | |_|/\'..' / / /   | |_  |  '.' 
             `  \ \._,\ '/'  `'-'`  \ \._,\ '/  |   /  
                 `--'  `""            `--'  `""   `'-'   ";

        public static string Merchant = @"
       .-""""-.
      /-.{}  \
      | _\__.|
      \/^)^ \/
       \ =  /
  .---./`--`\.--._
 /     `;--'`     \
;        /`       ;
|       |*        |
/   |   |     |    \
|    \  |*    /    |
\_   |\_|____/|  __/
  \__//======\\__/
  / //_      _\\ \
  -'  |`""""""""`|  `-
      |  L   |
      >_ || _<
      |  ||  |
      |  ||  |
     /   ||   \
    /    /,    \
     `|""|`""|""|""`
     /  )  /  )  
    /__/  /__/";
    }

    
}
