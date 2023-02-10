using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhodeCalculator
{
    internal static class MenuOptions
    {
        public static string Introduction = "Damage Calculator for Arknights  [Reminder: Percentages buffs/debuffs must be converted to decimals] \n";
        public static string MenuSelections = "[1] Final Operators Attack \n" +
              "[2] Operators ASPD Calculator \n" + "[3] Physical Damage Calculator \n" + "[4] Arts Damage Calculator";
        public static string FinalAttack = "[Operator Final Attack] \n"+ 
            "ATK_Multiplier_Buff is the ATK percentage value associated with any Talents or Skills that say things like “Increases ATK to X%” or “ X% of ATK” (identified by the absence of the + in front of the number). \n" +
            "Attack Buff Multiplier =  x1 * x2* ..... etc \n ";

    }
}
