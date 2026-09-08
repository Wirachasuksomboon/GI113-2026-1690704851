/*
 * Student ID :1690704851
 * Name       :wiracha suksomboon
 * Section    :129D
 * No.        :32
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace LAB03
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var bossName = "Kirin";
                var rank = 'S';
                int level = 7;
                int maxLevel = 10;

                int maxHp = 240;
                int currentHp = 115;

                float attackPower = 42.5f;
                double critMultiplier = 1.75;
                bool isBoss = true;

                Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
                Console.WriteLine($"Name: {bossName}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level: {level} / {maxLevel}");
                Console.WriteLine($"HP: {currentHp} / {maxHp}");
                Console.WriteLine($"Attack Power: {attackPower}");
                Console.WriteLine($"Crit Multiplier: {critMultiplier}");
                Console.WriteLine($"Is Boss: {isBoss}");

                Console.WriteLine("\n----- Implicit Conversion: HP as double -----");

                double currentHpDouble = currentHp;

                Console.WriteLine($"HP (double): {currentHpDouble}");

                Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");

                double hpPercentExact = currentHpDouble * 100 / maxHp;

                Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

                Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");

                int attackPowerExplicit = (int)attackPower;

                Console.WriteLine($"Attack Power (int cast): {attackPowerExplicit}");

                Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");

                int critCast = (int)critMultiplier;

                Console.WriteLine($"Crit Multiplier (int cast): {critCast}");

                int critConvert = Convert.ToInt32(critMultiplier);

                Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
            }
        }
    }
        
  
