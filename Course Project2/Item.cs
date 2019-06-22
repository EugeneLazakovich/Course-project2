using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Project2
{
    class Item
    {
        public String Name { get; private set; }
        public int Intel { get; private set; }
        public int Agil { get; private set; }
        public int Strike { get; private set; }
        public Item(String name, int intel, int agil, int strike)
        {
            Name = name;
            Intel = intel;
            Agil = agil;
            Strike = strike;
        }  
        public int plusItem()
        {
            return Intel + Agil + Strike;
        }
    }
    
}
