using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxHelth = 180;
            int minHelth = 100;
            int minDamage = 20;
            int maxDamage = 80;
            int minbossHealth = 1;
            int maxbossHealth = 300;
            int minBossDamage = 20;
            int maxBossDamage = 50;
            int health = rnd.Next(minHelth, maxHelth);
            int spellPunch = rnd.Next(minDamage, maxDamage);
            int spellFrostBolt = rnd.Next(minDamage, maxDamage);
            int spellFireBolt = rnd.Next(minDamage, maxDamage);
            int spellHealing = rnd.Next(minDamage, maxDamage);
            int bossHealth = rnd.Next(minbossHealth, maxbossHealth);
            int bossDamage = rnd.Next(minBossDamage, maxBossDamage);

            bool isWork = true;
            int userInput = 0;
            bool activetionSpellHealing = false;

            Console.WriteLine("Ваши показатели:\n" + health + " - Здоровье\n" + spellPunch + " - Дать леща \n" + spellFrostBolt +
                " - Ледяная стрела\n" + spellFireBolt + " - Огненная стрела\n" + spellHealing + " - Исцеление");
            Console.WriteLine("\nПоказатели босса:\n" + bossHealth + " - Здоровье\n" + bossDamage + " - Урон \n");
            Console.WriteLine("Начинается бой...\nВыберите заклинание\n1- Дать леща\n2- Ледяная стрела( " +
               "теперь moжно подлататься\n3- Огненная стрела\n4- полечится на " + spellHealing);

            while (isWork)
            {
                if (userInput == 4)
                {
                    activetionSpellHealing = false;
                }
                userInput = Convert.ToInt32(Console.ReadLine());

                if (activetionSpellHealing == true)
                {
                    Console.WriteLine("Босс освободился от ледяных оков...");
                }
                else if (health > 0 | bossHealth > 0)
                {
                    health -= bossDamage;
                    Console.WriteLine("босс наносит по вам " + bossDamage + " урона. у вас осталось " + health + " хп..");
                }
               
                switch (userInput)
                {
                    case 1:
                        bossHealth -= spellPunch;
                        if (bossHealth <= 0)
                        {
                            bossHealth = 0;
                            
                        }
                        Console.WriteLine("Вы бьете ладонью по босссу нанеся " + spellPunch + " урона, у босса осталось " + bossHealth + " хп");
                        break;
                    case 2:
                        bossHealth -= spellFrostBolt;
                        activetionSpellHealing = true;
                        if (bossHealth <= 0)
                        {
                            bossHealth = 0;
                        }
                        else 
                        { 
                        Console.WriteLine("Запускаете ледяную стрелу босссу нанеся " + spellFrostBolt + " урона, у босса осталось " + bossHealth + " хп");
                        Console.WriteLine("Босс заморожен на 1 ход");
                        }
                        break;
                    case 3:
                        bossHealth -= spellFireBolt;
                        if (bossHealth <= 0)
                        {
                            bossHealth = 0;
                        }
                        Console.WriteLine("Запускаете огненную стрелу босссу нанеся " + spellFireBolt + " урона, у босса осталось " + bossHealth + " хп");
                        break;
                    case 4:
                        if (activetionSpellHealing == true)
                        {
                            health += spellHealing;
                            Console.WriteLine("Вы востанавливаете себе" + spellHealing + " здоровья, ваше  хп " + health);
                        }
                        else
                        {
                            Console.WriteLine("Вы впустую тратите силы...Cначала нужно заморозить босса");
                            health -= bossDamage;
                        }
                        break;
                }
                if (health <= 0)
                {
                    health = 0;
                    isWork = false;
                    Console.WriteLine("Вы проиграли");
                }
                else if (bossHealth <= 0)
                {
                    Console.WriteLine("Вы убили босса");

                    isWork = false;
                    
                    
                }

                
            }
        }
    }
}