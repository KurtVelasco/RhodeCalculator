using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhodeCalculator
{
    class Formula
    {
        public static void AttackSpeed(double ASPDbuff, double OPsAtkIntv, double AtkIntervalIncrease)
        {
            double result = ((100 + ASPDbuff) / (OPsAtkIntv + AtkIntervalIncrease)) / 100;
            double FinalResult = 1 / result;
            Console.WriteLine("____________________________");
            Console.WriteLine("Final Attack Speed Interval: " + Math.Round(FinalResult, 2) + " Seconds");
            Console.WriteLine("Adjusted for 30 Frames: " + Math.Round(FinalResult, 2) * 30 + " Frames");
            Console.ReadLine();
        }
        public static void FinalAttack(double OPDefaultAtk, double BaseAtkBuff, double FlatAtkBuff, double AttackMultiplier)
        {
            double result = ((OPDefaultAtk * (1 + BaseAtkBuff) + FlatAtkBuff) * AttackMultiplier);
            Console.WriteLine("____________________________");
            Console.WriteLine("Average Final Atk: " + Math.Round(result, 0));
            Console.ReadLine();

        }
        public static void  PhysDamageFormula(double OPFinalAtk, double ScaleDefenseDown, double FlatDefDown, double PhysicalDMGTkUp, double EnemyDefence)
        {
            double result = (OPFinalAtk - (EnemyDefence + FlatDefDown) * (ScaleDefenseDown)) * PhysicalDMGTkUp;
            Console.WriteLine("____________________________");
            Console.WriteLine("Final Physical Damage during combat " + Math.Round(result, 0));
            Console.ReadLine();
        }
        public static void ArtsDamageFormula(double OPFinalAtk)
        {
            double result = (OPFinalAtk);
        }
    }
}
