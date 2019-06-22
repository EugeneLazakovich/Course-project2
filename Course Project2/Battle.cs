using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Course_Project2
{
    class Battle
    {
        private Hero[] heroes = new Hero[5];
        private Item[] items = new Item[4];

        private int health1;
        private int health2;

        public Battle()
        {
            heroes[0] = new Timbersaw("Timbersaw", 23, 16, 23, 26, 587);
            heroes[1] = new Axe("Axe", 18, 20, 25, 27, 625);
            heroes[2] = new Spectre("Spectre", 16, 23, 23, 23, 587);
            heroes[3] = new Jakiro("Jakiro", 26, 10, 27, 27, 663);
            heroes[4] = new Dazzle("Dazzle", 25, 21, 18, 22, 492);

            items[0] = new Item("Club", 0, 2, 4);
            items[1] = new Item("Bow", 1, 4, 1);
            items[2] = new Item("Cane", 4, 2, 0);
            items[3] = new Item("None", 0, 0, 0);
        }
        private int rnd1;
        private int rnd2;
        private int rnd3;
        private int rnd4;
        Random random1 = new Random();
        Random random2 = new Random();
        Random random3 = new Random();
        Random random4 = new Random();
        public void setHeroRnd1()
        {
            rnd1 = random1.Next(0, heroes.Length);
        }
        public int getHeroRnd1()
        {
            return rnd1;
        }
        public void setHeroRnd2()
        {
            rnd2 = random2.Next(0, heroes.Length);
        }
        public int getHeroRnd2()
        {
            return rnd2;
        }
        public void setItemRnd1()
        {
            rnd3 = random3.Next(0, items.Length);
        }
        public int getItemRnd1()
        {
            return rnd1;
        }
        public void setItemRnd2()
        {
            rnd4 = random4.Next(0, items.Length);
        }
        public int getItemRnd2()
        {
            return rnd1;
        }
        public void getStartInfo()
        {
            Console.WriteLine(heroes[getHeroRnd1()].Name + " with " + items[getItemRnd1()].Name + " vs " + heroes[getHeroRnd2()].Name + " with " + items[getItemRnd2()].Name);
            Console.WriteLine(heroes[getHeroRnd1()].Name + ": Inteligence: " + heroes[getHeroRnd1()].Intel);
            Console.WriteLine("\t" + ": Agility: " + heroes[getHeroRnd1()].Agil);
            Console.WriteLine("\t" + ": Strike: " + heroes[getHeroRnd1()].Strike);
            Console.WriteLine("\t" + ": Power: " + heroes[getHeroRnd1()].Power);
            Console.WriteLine("\t" + ": Health: " + heroes[getHeroRnd1()].Health);
            Console.WriteLine(items[getItemRnd1()].Name + ": Inteligence: " + items[getItemRnd1()].Intel);
            Console.WriteLine("\t" + ": Agility: " + items[getItemRnd1()].Agil);
            Console.WriteLine("\t" + ": Strike: " + items[getItemRnd1()].Strike);
            Console.WriteLine(heroes[getHeroRnd2()].Name + ": Inteligence: " + heroes[getHeroRnd2()].Intel);
            Console.WriteLine("\t" + ": Agility: " + heroes[getHeroRnd2()].Agil);
            Console.WriteLine("\t" + ": Strike: " + heroes[getHeroRnd2()].Strike);
            Console.WriteLine("\t" + ": Power: " + heroes[getHeroRnd2()].Power);
            Console.WriteLine("\t" + ": Health: " + heroes[getHeroRnd2()].Health);
            Console.WriteLine(items[getItemRnd2()].Name + ": Inteligence: " + items[getItemRnd2()].Intel);
            Console.WriteLine("\t" + ": Agility: " + items[getItemRnd2()].Agil);
            Console.WriteLine("\t" + ": Strike: " + items[getItemRnd2()].Strike);
        }
        public void setParams()
        {
            health1 = heroes[getHeroRnd1()].Health;
            health2 = heroes[getHeroRnd2()].Health;
        }
        public void fightHero()
        {
            do
            {
                health1 -= heroes[getHeroRnd2()].changeHealth() + items[getItemRnd2()].plusItem();
                health2 -= heroes[getHeroRnd1()].changeHealth() + items[getItemRnd1()].plusItem();
                if (health1 < 0)
                {
                    health1 = 0;
                }
                if (health2 < 0)
                {
                    health2 = 0;
                }
                Console.WriteLine();
                Console.WriteLine(heroes[getHeroRnd1()].Name + " hit " + heroes[getHeroRnd2()].Name + ": " + heroes[getHeroRnd2()].changeHealth());
                Console.WriteLine(heroes[getHeroRnd2()].Name + "'s health: " + health2);
                Console.WriteLine(heroes[getHeroRnd2()].Name + " hit " + heroes[getHeroRnd2()].Name + ": " + heroes[getHeroRnd1()].changeHealth());
                Console.WriteLine(heroes[getHeroRnd1()].Name + "'s health: " + health1);
                Thread.Sleep(1000);
            } while (health1 > 0 && health2 > 0);
        }
        public void getFinishInfo()
        {
            Console.WriteLine();
            if(health1==0 && health2 == 0)
            {
                Console.WriteLine("DRAW!!!");
            }
            else
            {
                if (health1 == 0)
                {
                    Console.WriteLine(heroes[getHeroRnd2()].Name + " IS WINNER!!!");
                }
                else
                {
                    Console.WriteLine(heroes[getHeroRnd1()].Name + " IS WINNER!!!");
                }
            }            
        }
    }
}
