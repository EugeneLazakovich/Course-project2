using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Project2
{
    class Hero
    {
        private Item[] items = new Item[4];

        public String Name { get; private set; }
        public int Intel { get; private set; }
        public int Agil { get; private set; }
        public int Strike { get; private set; }
        public int Power { get; private set; }
        public int Health { get; private set; }
        public Hero(String name, int intel, int agil, int strike, int power, int health)
        {
            Name = name;
            Intel = intel;
            Agil = agil;
            Strike = strike;
            Power = power;
            Health = health;            
        }        
        public virtual int changeHealth()
        {
            return Health;
        }             
    }
    class Timbersaw : Hero
    {
        public Timbersaw(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return Strike / 2 + Intel / 4 + Agil / 4 + Power / 2;
        }
    }
    class Axe : Hero
    {
        public Axe(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return Strike / 2 + Intel / 4 + Agil / 4 + Power / 2;
        }
    }
    class Spectre : Hero
    {
        public Spectre(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return Agil / 2 + Strike / 4 + Intel / 4 + Power / 2;
        }
    }
    class Jakiro : Hero
    {
        public Jakiro(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return Intel / 2 + Agil / 4 + Strike / 4 + Power / 2;
        }
    }
    class Dazzle : Hero
    {
        public Dazzle(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return Intel / 2 + Agil / 4 + Strike / 4 + Power / 2;
        }
    }
}
