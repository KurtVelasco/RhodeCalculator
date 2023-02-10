using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RhodeCalculator
{
    class ReadTextFiles
    {
        public static void PhysicalCalcInstruction()
        {
            using (StreamReader sr = new StreamReader("PhysicalAtkInstruct.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(line);
                    Console.ResetColor();
                }
            }
        }
        public static void APSDCalcInstruction()
        {
            using (StreamReader sr = new StreamReader("ASPDInstruct.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(line);
                    Console.ResetColor();
                }
            }
        }
        public static void FinalAtkCalcInstruction()
        {
            using (StreamReader sr = new StreamReader("FinalAttackInstruct.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(line);
                    Console.ResetColor();
                }
            }
        }
        public static void Logo()
        {
            using (StreamReader sr = new StreamReader("Logo.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(line);
                    Console.ResetColor();
                }
            }
        }
    }
}
