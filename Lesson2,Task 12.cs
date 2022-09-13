using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Random rnd = new Random();

            int maxHelth = 180;
            int minHelth = 140;
            int minDamage = 20;
            int maxDamage = 80;
            int minbossHealth = 180;
            int maxbossHealth = 300;
            int minBossDamage = 20;
            int maxBossDamage = 65;
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
            bool frezing = false;
            bool repeatFrostBolt = true;

            Console.WriteLine("Ваши показатели:\n" + health + " - Здоровье\n" + spellPunch + " - Дать леща \n" + spellFrostBolt +
                " - Ледяная стрела\n" + spellFireBolt + " - Огненная стрела\n" + spellHealing + " - Исцеление");
            Console.WriteLine("\nПоказатели босса:\n" + bossHealth + " - Здоровье\n" + bossDamage + " - Урон \n");
            Console.WriteLine("Начинается бой...\nВыберите заклинание\n1- Дать леща\n2- Ледяная стрела( " +
               "теперь moжно подлататься\n3- Огненная стрела\n4- полечится на " + spellHealing);

            while (isWork == true)
            { 
                userInput = Convert.ToInt32(Console.ReadLine());
              
                   switch (userInput)
                {
                    case 1:
                       repeatFrostBolt = true;

                       if (frezing == true)
                        {                        
                            bossHealth -= spellPunch;
                            Console.WriteLine("Босс заморожен и не может бить.");
                        }
                       else 
                        {  
                            health -= bossDamage;

                            if(health <= 0)
                            {
                                health = 0;
                                Console.WriteLine("Босс Охуел и Невыхуел обратно от того что ты такой лох и поджарил твои яйца нанеся " + bossDamage*98989898989 + " урона.");
                                 break;
                            }
                            else {
                            Console.WriteLine("Босс наносит " + bossDamage + " урона, ваше ХП " + health);
                            bossHealth -= spellPunch;
                                  }
                        }
                           
                        if (bossHealth <= 0)
                        {
                            bossHealth = 0;
                        }
                        Console.WriteLine("Вы бьете ладонью по босссу нанеся " + spellPunch + " урона, у босса осталось " + bossHealth + " хп");
                        frezing = false;
                        break;
                    case 2:
                        if (repeatFrostBolt == true) 
                        { 
                           health -= bossDamage;

                           if (health <= 0)
                           {
                             health = 0;
                             Console.WriteLine("Босс Охуел и Невыхуел обратно от того что ты такой лох и поджарил твои яйца нанеся " + bossDamage * 98989898989 + " урона.");
                             break;
                           }
                             Console.WriteLine("Босс наносит " + bossDamage + " урона, ваше ХП " + health);

                            bossHealth -= spellFrostBolt;
                            activetionSpellHealing = true;
                            frezing = true;

                           if (bossHealth <= 0)
                           {
                               bossHealth = 0;
                               Console.WriteLine("\nВаша ледяная стрела пронзает сердце босса нанеся " + spellFrostBolt * 10 + " урона\n и оно рассыпается на маленькие осколки это <<FATALITY>>");
                           }
                           else 
                           {
                            Console.WriteLine("Запускаете ледяную стрелу босссу нанеся " + spellFrostBolt + " урона, у босса осталось " + bossHealth + " хп");
                            Console.WriteLine("Босс заморожен на 1 ход");
                           }
                        }
                        else
                        {
                            Console.WriteLine("Это заклинание нельзя использовать два раза подряд");
                        }
                        repeatFrostBolt = false;
                        break;
                    case 3:
                        repeatFrostBolt = true;

                        if (frezing == true)
                        {
                            bossHealth -= spellFireBolt;
                            Console.WriteLine("Босс заморожен и не может бить.");
                        }
                        else
                        {
                            health -= bossDamage;

                            if (health <= 0)
                            {
                                health = 0;
                                Console.WriteLine("Босс наносит сокрушительный удар " + bossDamage * 98989898989899 + " урона.");
                                break;
                            }
                            Console.WriteLine("Босс наносит " + bossDamage + " урона, ваше ХП " + health);
                            bossHealth -= spellFireBolt;
                            }
                       
                        if (bossHealth <= 0)
                        {
                            bossHealth = 0;
                        }
                        Console.WriteLine("Запускаете огненную стрелу босссу нанеся " + spellFireBolt + " урона, у босса осталось " + bossHealth + " хп");
                        frezing = false;

                        break;
                    case 4:
                        repeatFrostBolt = true;
                        if (activetionSpellHealing == true)
                        {
                            health += spellHealing;
                            Console.WriteLine("Вы востанавливаете себе" + spellHealing + " здоровья, ваше  хп " + health);
                            activetionSpellHealing = false;
                        }
                        else
                        {
                            Console.WriteLine("Вы впустую тратите силы...Cначала нужно заморозить босса");
                            health -= bossDamage;
                           
                            if (health <= 0)
                            {
                                health = 0;
                                Console.WriteLine("Босс не дал тебе даже кончиком губ коснутся целительного напитка зато положил на тебя болт нанеся " + bossDamage * 98989898989899 + " урона.");
                                break;
                            }
                        }
                        frezing = false;
                         break;
                        }

                if (bossHealth == 0)
                {
                    isWork = false;
                    Console.WriteLine("Вы убили босса");
                }
                
                else if (health == 0)
                {
                    Console.WriteLine("Босс победил ..");
                }
            }
        }
    }
}
