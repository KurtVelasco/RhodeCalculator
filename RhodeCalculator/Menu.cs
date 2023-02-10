using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhodeCalculator
{
    class Menu
    {
        static bool SetFlag = true;
        public void MainHub()
        {
            while(SetFlag)
            {
                ReadTextFiles.Logo();
                Console.WriteLine(MenuOptions.Introduction);
                Console.WriteLine(MenuOptions.MenuSelections);
                int Choice = MainHubOptions(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        //Operators Final Attack
                        Console.Clear(); ReadTextFiles.FinalAtkCalcInstruction();
                        Console.Write("Operator's Base Attack (Trust is already added to the base atk): ");
                        Double BaseAtk = NumberCalculator(Console.ReadLine());
                        Console.Write("Operator's Base Attack Buff (Sum of all +buffs): ");
                        Double Base_atkBuff = NumberCalculator(Console.ReadLine());
                        Console.Write("Flat Attack Buff: ");
                        Double Flat_ATKbuff = NumberCalculator(Console.ReadLine());
                        Console.Write("Attack Multiplier Buff (If none place 1 instead): ");
                        Double Atk_MultiplierBuff = NumberCalculator(Console.ReadLine());
                        Formula.FinalAttack(BaseAtk, Base_atkBuff, Flat_ATKbuff, Atk_MultiplierBuff);
                        break;
                    case 2:
                        //Operator Final ASPD
                        Console.Clear(); ReadTextFiles.APSDCalcInstruction();
                        Console.Write("External Attack Speed Buffs (Talents/Buffs): ");
                        Double ASPDbuff = NumberCalculator(Console.ReadLine());
                        Console.Write("Operator's Default Attack Interval: ");
                        Double OPsAtkIntv = NumberCalculator(Console.ReadLine());
                        Console.Write("Operator's ASPD Skill Modifier: ");
                        Double AtkIntervalIncrease = NumberCalculator(Console.ReadLine());
                        Formula.AttackSpeed(ASPDbuff, OPsAtkIntv, AtkIntervalIncrease);
                        break;
                    case 3:
                        //Operator Final Physical Attack
                        Console.Clear(); ReadTextFiles.PhysicalCalcInstruction();
                        Console.Write("\n" + "Operator's Final Attack: ");
                        Double F_Attack = NumberCalculator(Console.ReadLine());
                        Console.Write("Scaling Defense Debuffs: ");
                        Double ScalingDefDebuffs = NumberCalculator(Console.ReadLine());
                        Console.Write("Flat Defense Debuffs: ");
                        Double Flat_DefDebuff = NumberCalculator(Console.ReadLine());
                        Console.Write("Physical Damage Buffs: ");
                        Double PhysDmgBuffs = NumberCalculator(Console.ReadLine());
                        Console.Write("Enemy Defense: ");
                        Double EnemyDef = NumberCalculator(Console.ReadLine());
                        Formula.PhysDamageFormula(F_Attack, ScalingDefDebuffs, Flat_DefDebuff, PhysDmgBuffs, EnemyDef);
                        break;
                    case 4:
                        break;
                }
                Console.Clear();               
            }
        }
        public int MainHubOptions(string UserInput)
        {
            int Output = 0;
            bool flag = int.TryParse(UserInput, out Output);
            if(flag == true)
            {
                return Output;
            }
            else
            {
                Console.Write("Invalid Option, Please Input another option: ");
                MainHubOptions(Console.ReadLine());
            }
            return Output;
        }
        public Double NumberCalculator(string UserInput)
        {
            Double Output = 0;
            bool flag = Double.TryParse(UserInput, out Output);
            if (flag == true)
            {
                return Output;
            }
            else
            {
                Console.Write("Invalid Option, Please Input another option: ");
                MainHubOptions(Console.ReadLine());
            }
            return Output;
        }
    }
}
