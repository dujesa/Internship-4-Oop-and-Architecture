using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Models.Heroes;
using DungeonCrawler.Data.Models.Monsters;
using System;

namespace DungeonCrawler.Presentation.Views
{
    public static class AttackView
    {
        public static void HandleAttack(Character attacker, Character opponent, Battle battle, Game game)
        {
            if (attacker is Warrior warrior)
            {
                AttackByMenuInput(warrior, (Monster)opponent);
            }
            else if (attacker is Mage mage)
            {
                AttackByMenuInput(mage, (Monster)opponent);
            }
            else if (attacker is Ranger ranger)
            {
                AttackByMenuInput(ranger, (Monster)opponent, battle);
            }
            else if (attacker is Goblin goblin)
            {
                GenerateAttack(goblin, (Hero)opponent);
            }
            else if (attacker is Brute brute)
            {
                GenerateAttack(brute, (Hero)opponent);
            }
            else if (attacker is Witch witch)
            {
                GenerateAttack(witch, (Hero)opponent, game);
            }
        }

        public static void HandleStunning(Battle battle)
        {
            Console.WriteLine("\nMonster is stunned by your hero and your hero automatically won this rounds move battle.\n" +
                "Your hero attacks monster\n");

            battle.Hero.Attack(battle.Monster);

            Console.WriteLine($"\n\n{battle}\n\n");
        }

        private static void AttackByMenuInput(Warrior warrior, Monster opponent)
        {
            var warriorAttackTypesCount = 2;

            Console.WriteLine("\n" +
                "\n Choose attack by its order number from menu." +
                "\n Attack menu:\n" +
                "1. ATTACK - cause damage to opponent\n" +
                "2. RAGE ATTACK - costs your warrior 15% of HP but doubles up damage strength for that round\n" +
                "\n");

            var attackType = ProvideAttackTypeFromUsersInput(warriorAttackTypesCount);

            switch (attackType)
            {
                case 1:
                    warrior.Attack(opponent);
                    Console.WriteLine("\nYour warrior attacked monster\n");
                    break;
                case 2:
                    warrior.RageAttack(opponent);
                    Console.WriteLine("\nYour warrior rage attacked monster\n");
                    break;
            }
        }
        
        private static void AttackByMenuInput(Mage mage, Monster opponent)
        {
            var mageAttackTypeCount = 2;

            Console.WriteLine("\n" +
                "\n Choose attack by its order number from menu." +
                "\n Attack menu:\n" +
                "1. ATTACK - cause damage to opponent\n" +
                "2. MANA - use mana points for heal up\n" +
                "\n");

            var attackType = ProvideAttackTypeFromUsersInput(mageAttackTypeCount);

            switch (attackType)
            {
                case 1:
                    mage.Attack(opponent);
                    Console.WriteLine("\nYour mage attacked monster\n");
                    break;
                case 2:
                    mage.UseMana();
                    Console.WriteLine("\nYour mage used mana\n");
                    break;
            }
        }

        private static void AttackByMenuInput(Ranger ranger, Monster opponent, Battle battle)
        {
            var rangerAttackTypeCount = 1;

            Console.WriteLine("\n" + 
                "\n Choose attack by its order number from menu." +
                "\n Attack menu:\n" +
                "1. ATTACK - cause damage to opponent\n" +
                "\n");

            var attackType = ProvideAttackTypeFromUsersInput(rangerAttackTypeCount);

            switch (attackType)
            {
                case 1:
                    ranger.Attack(opponent);
                    Console.WriteLine("\nYour ranger attacked monster\n");
                    break;
            }

            if (ranger.IsStunning())
            {
                battle.ActivateStun();
                Console.WriteLine("\n**Your ranger has stunned its opponent!**\n");
            }
        }

        private static void GenerateAttack(Goblin goblin, Hero opponent)
        {
            goblin.Attack(opponent);
            Console.WriteLine("\nGoblin attacked your hero\n");
        }

        private static void GenerateAttack(Brute brute, Hero opponent)
        {
            brute.Attack(opponent);
            Console.WriteLine("\nBrute attacked your hero\n");
        }

        private static void GenerateAttack(Witch witch, Hero opponent, Game game)
        {
            Random random = new Random();
            var jumbusType = 0;
            var randomAttackType = random.Next(0, 10);

            if (randomAttackType == jumbusType)
            {
                game.ActivateJumbus();
                Console.WriteLine("*!*!*!*!* Witch just started J-U-M-B-U-S *!*!*!*!*");
            }
            else
            { 
                witch.Attack(opponent);
                Console.WriteLine("\nWitch attacked your hero\n");
            }
        }

        private static int ProvideAttackTypeFromUsersInput(int characterAttackTypesCount)
        {
            var isAttackChoosen = false;
            var choosenAttack = -1;

            while (isAttackChoosen == false)
            {
                int.TryParse(Console.ReadLine(), out choosenAttack);

                if (choosenAttack > 0 && choosenAttack <= characterAttackTypesCount)
                {
                    isAttackChoosen = true;
                }
                else
                { 
                    Console.WriteLine("Wrong input, try again...");
                }
            }

            return choosenAttack;
        }
    }
}
