﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Gui
    {
      public static void Tytuł()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var arr = new[]
            {
            @" _____ ___________ _____ _   _ _____ ___  ___  ___   _   _   ______ _   _ _   _ _____  _____ _____ _   _ ",
            @"/  ___|_   _| ___ \  _  | \ | |  __ \|  \/  | / _ \ | \ | |  |  _  \ | | | \ | |  __ \|  ___|  _  | \ | |",
            @"\ `--.  | | | |_/ / | | |  \| | |  \/| .  . |/ /_\ \|  \| |  | | | | | | |  \| | |  \/| |__ | | | |  \| |",
            @" `--. \ | | |    /| | | | . ` | | __ | |\/| ||  _  || . ` |  | | | | | | | . ` | | __ |  __|| | | | . ` |",
            @"/\__/ / | | | |\ \\ \_/ / |\  | |_\ \| |  | || | | || |\  |  | |/ /| |_| | |\  | |_\ \| |___\ \_/ / |\  |",
            @"\____/  \_/ \_| \_|\___/\_| \_/\____/\_|  |_/\_| |_/\_| \_/  |___/  \___/\_| \_/\____/\____/ \___/\_| \_/",
            };
            Console.WindowWidth = 160;
            //Console.WriteLine("\n");
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("\n");
            Console.ResetColor();
        }
      public static void Opcje(int liczba, String str)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            str = String.Format("\n{0} - {1}", liczba, str);
            Console.WriteLine(str);
            Console.ResetColor();
        }
       public static void naizdupobrazek()
        {
            var arr = new[]
            {
      @"
        ..............................................................&&&&&&...............................
        ...........................................................(&((###%%%%/............................
        ..............................##/.........................,#(////*/(((#(...........................
        ..............................#%%%%#....................../((///*//(##%%...........................
        .............................../%%%###/.................../#/#####(%%%%%...........................
        ......................./........#%%%%%%%#.................*///***//#/(#%...........................
        ........................./*.....%%%&%%%%%%%,.............../(///**(%(#%............................
        .............,,............(*.(%%%&%%%%%%%#%#...............#(/*//(((%%,...........................
        ............../#%##*.......,#(%%#%%%%%##%%%%%%/.............(#%#(((#%&%#*..........................
        ...............*##%###%%#%&%%%(#%,.........*##((...........*((/((#%##########(.....................
        ................./%%%%%%&%%&&&*..#(/....................///(((((##(/((((((/((###,..................
        ..................,#%%#%%%&%%......%((............*(((((((((##(/#((################/...............
        %%#%%#(#%((*##**#(*//#%%&&%%%........%((.........(((/(((((/////(((((((((##((//(####%#(.............
        &%%&%%%%%%%&%%&&&&&%%/%#%%%#,........%(%...../(///(((((/((((((((((///((/((//(#####%#(.............. 
        &&&%&%%%&%%%%%%%%%%%%%%%#,#%%%%(#%%%#*...#(%.//(((#(((((((((((((((//////((%%#(/(((##%%%.....,......
        &&&%%%&&&&&&&&&&&&&&&&&%%%%#,#%&%%%%&%#,,//****#%(#((((////////(((///**//(###(####%%%%#..,**(##(*/#
        &%%%%&&&&@&&&&&&&&%&&&&&&%%&%%%%&&&&&&%&%%#**/*/#(%%((((//***///#(/////(((##//(((((####(####%%%%##%
        &&&&&&&&&&&&&&&&&&&%&&&&&&&&%&%%&&&&&&%%&&%#(///(#%&&%####((((((((#####%%%%(((###(####%%%%%#%%%%%%%
        &&&%&&&&&&&&&&&@&&&&&%%&&&&&&&&&&&&&&&&&&(####&%((%@&%##((//////(((###%%%##(((((#%%#%%%%%%%%%%%%%%%
        #&&%&&&@&&&&&&&&&%&&%&&%&&&&&&&&&&&&&&&&%((#%%%&&&@&((#&(((//*****/(#######(((((((((###%&&&&&&%&&&&
        %##%%##%##(#(############%&%#%%%&%#%&&&%#%%###&&@@@&**/*/((((/((((((//**//((((((((#%&&%%&%&%%&&&&&&
        %%%&&&%%%##%%%%%%#%%%###%%####%%%#######%%%##%%&&@#((%(*/////((/((((((((((((((#######%%&&&&&&&&&&&&
        &&&&&&&&%%&&&&&&&&&&&%%%%&&%%&%%&&%###%%%%%##%%&%&%#(#*/((/#%%%(((((//////((((##%%%%#%#%%#(%%%##%%%
        &&@&&&&&&&&&&&@&&&&&@&&&&&&&&&&&&&&&%%%&&%&&&&&&%##%#((((((#&&&%((#####%&@@&&&%%%%%%%%%%%%%%##%%%#%
        @&&&&&&@&&&&&@@&@@@&&&&&&&&&&&&&&&&&&&@@&&&&&&&&&&&%((((((//((((/(####(###%%&&&&&&&&&&&&&%&&&%&&%&%
        &&@&&&&&&@@@&&&@&@@&&&&&&&&&&&&&&&&@&&&&&&&&&&&&&&&%#(((((///////((((((###%%&%&&&&&&%%%%&&&&&&&%&&&
        @@@&&&@@&&&@@@&@@@@@@&@&&&@@@&&&@@@@@&&&@&&&@&&@@&&&*,((((//////((((((##%%%##&&%%%%%%%%%%#%%&%%%%%&
        &@@@@@@@&&&@@&&@@@&&@&&@@&@@@@&&&&@@@@@&@@@&@&&&@@&*,,,**(,,,**(/*,*.***,,**/(&%%%%%%%%%%%%&%%%&&&%
        &&@@@@@@@@&&@@@&&&@@&&&@@@@&&@&&@&&&@@&&&&@&@@@&&@,,,,,,,.,,,.*/,*,,**,*###/((#&%%%&%%%&%%%&%%&&%%%
        &&@@@@@@@@@@@@@&@@@@@&@@@&@&&&&@@@@@@@@&@@@@@@@@@,.....,***,,,*,*..,,,***,,*//%&&&&%%&&&%%%&%%&&%%%"
            };
            Console.WindowWidth = 160;
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("\n");
        }
        public static void koniec()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var arr = new[]
            {
            @"
               _____ _   _  _____   _____ _   _______ 
              |_   _| | | ||  ___| |  ___| \ | |  _  \
                | | | |_| || |__   | |__ |  \| | | | |
                | | |  _  ||  __|  |  __|| . ` | | | |
                | | | | | || |___  | |___| |\  | |/ / 
                \_/ \_| |_/\____/  \____/\_| \_/___/ "
,
            };
            Console.WindowWidth = 160;
            //Console.WriteLine("\n");
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("\n");
            Console.ResetColor();
        }
    }
}
