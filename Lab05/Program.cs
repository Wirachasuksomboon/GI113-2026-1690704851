namespace Lab05
/*
* Student ID :1690704851
* Name       :Lab05
* Section    :129D
* No.        :32
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game
            Console.WriteLine("------Welcome to hell-------");
            Console.WriteLine("Hero VS Monster -- Fight Damage Calculator\n");

            //Hero
            Console.WriteLine("hero Health: ");
            bool herohpok = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("hero Attack: ");
            bool heroatkok = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("hero Def: ");
            bool herodefok = int.TryParse(Console.ReadLine(), out int heroDef);


            //Monster
            Console.WriteLine("monster Health: ");
            bool monsterhpok = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("monster Attack: ");
            bool monsteratkok = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("monster Def: ");
            bool monsterdefok = int.TryParse(Console.ReadLine(), out int monsterDef);

            //input
            bool heroStatus = herohpok && heroatkok && herodefok;
            bool monsterStatus = monsterhpok && monsteratkok && monsterdefok;
            Console.WriteLine($"Hero Status: {heroStatus}");
            Console.WriteLine($"Monster Status: {monsterStatus}");

            Console.WriteLine($"[HERO] HP {heroHp} ATK {heroAtk} DEF {heroDef}");
            Console.WriteLine($"[Monster] HP {monsterHp} ATK {monsterAtk} DEF {monsterDef} ");

            int potionHeal = 5;

            heroHp += potionHeal;
            Console.WriteLine($"Hero used a potion and healed {potionHeal} HP. New HP: {heroHp}");

            int nomalDmg = Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Hero attacks Monster for {nomalDmg} damage.");

            int poewrDmg = Math.Max(0, (heroAtk * 2) - monsterDef);
            Console.WriteLine($"Hero uses a power attack on Monster for {poewrDmg} damage.");

            Random random = new Random();
            int critRoll = random.Next(1, 101);
            bool isCritical = critRoll <= 25;

            int critDmg = nomalDmg + Convert.ToInt32(nomalDmg * 0.5);
            Console.WriteLine($"Crit Roll: {critRoll}. critical Hit: {isCritical}");
            Console.WriteLine($"if critical hit, Hero deals {critDmg} DMG!!");









        }
    }
}
