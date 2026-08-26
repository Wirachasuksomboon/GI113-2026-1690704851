using System;
using System.Runtime.CompilerServices;
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHP = 240;
            int currentHP = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("==== BOOS STATS: INITIAL ====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHP}/{maxHP}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hppercent = currentHP * 100 / maxHP;
            Console.WriteLine($"HP Percentage: {hppercent}%");

            //Lab02 B
            string MageName = "Wooi";
            int mageMana = 250;
            double magemagicPower = 98.2;
            char mageRank = 'S';
            bool MageAlive = true;

            string MageName2 = "Chubi";
            int mageMana2 = 200;
            double magemagicPower2 = 85.0;
            char mageRank2 = 'A';
            bool MageAlive2 = true;

            string healerName = "Filix";
            int healerMana = 300;
            double healerHealingPower = 120.5;
            char healerRank = 'S';
            bool HealerAlive = true;

            string archerName = "Bladedy";
            int archerHP = 200;
            float archerAccuracy = 75.0f;
            char archerRank = 'A';
            bool ArcherAlive = true;

            Console.WriteLine("==== FANTASY GAME ====");

            Console.WriteLine("---- Mage ----");
            Console.WriteLine($"Name: {MageName}"); 
            Console.WriteLine($"Mana: {mageMana}");
            Console.WriteLine($"Magic Power: {magemagicPower}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Is Alive: {MageAlive}");

            Console.WriteLine("==== Mage 2 ====");
            Console.WriteLine($"Name: {MageName2}");
            Console.WriteLine($"Mana: {mageMana2}");
            Console.WriteLine($"Magic Power: {magemagicPower2}");
            Console.WriteLine($"Rank: {mageRank2}");
            Console.WriteLine($"Is Alive: {MageAlive2}");

            Console.WriteLine("==== Healer ====");
            Console.WriteLine($"Name: {healerName}");
            Console.WriteLine($"Mana: {healerMana}");
            Console.WriteLine($"Healing Power: {healerHealingPower}");
            Console.WriteLine($"Rank: {healerRank}");
            Console.WriteLine($"Is Alive: {HealerAlive}");

            Console.WriteLine("==== Archer ====");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"HP: {archerHP}");
            Console.WriteLine($"Accuracy: {archerAccuracy}");
            Console.WriteLine($"Rank: {archerRank}");
            Console.WriteLine($"Is Alive: {ArcherAlive}");









        }
    }
}



