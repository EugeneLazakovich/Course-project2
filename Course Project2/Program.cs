using System;

namespace Course_Project2
{    
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();

            battle.setHeroRnd1();
            battle.setHeroRnd2();
            battle.setItemRnd1();
            battle.setItemRnd2();
            battle.getStartInfo();
            battle.setParams();
            battle.fightHero();
            battle.getFinishInfo();
        }
    }
}
