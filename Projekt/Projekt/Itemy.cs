using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Ekwipunek
    {
        List<Item> eq;
        public Ekwipunek(List<Item>_eq)
        {
            this.eq = _eq;
        }

    }
    class Item
    {
        protected string nazwa;
        protected int bonusdohp;
        protected int bonusdodmg;
        public Item(string nazwa)
        {
            this.nazwa = nazwa;
        }
    }
    class Miksturadohp : Item
    {
        public Miksturadohp(string nazwa):base(nazwa)
        {
            this.bonusdohp = 30;
        }
    }
    class Miksturadodmg:Item
    {
        public Miksturadodmg(string nazwa):base(nazwa)
        {
            this.bonusdodmg = 4;
        }
    }
}
