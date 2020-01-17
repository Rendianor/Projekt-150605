using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public enum Rasa { Człowiek,Elf,Krasnolud,Niedźwiedź,Wilk,Goblin,Ork,Bandyta,NAIZDUP};
    public enum Profesja { Wojownik,Czarodziej,Łucznik}

    class Bohater
    {
        protected Rasa rasa;
        protected Profesja profesja;
        public int hp;
        public double zywotnosc = 1.0;
        public int maksymalnehp;
        protected int dmg;
        public int mikstura;
        protected int bonushp;
        protected int bonusatak;
        Random atak = new Random();
        public bool zycie { get; private set; } = true;
        protected Bohater(Rasa _rasa)
        {
            this.rasa = _rasa;
        }
        public virtual void przyjmujeszcios(Bohater obiekt)
        {
            this.dmg = atak.Next(1, 10) + obiekt.bonusatak;
            this.hp = this.hp - this.dmg;
            Console.WriteLine($"{obiekt.profesja} zadał {dmg} punktów obrażeń {this.rasa}");
            if (this.hp <= 0)
            {
                this.zycie = false;
                this.zywotnosc = 0;
                Console.WriteLine($"{this.rasa} zginął!");
            }
            else
                this.zywotnosc = (double)this.hp / (double)this.maksymalnehp;
        }
        public virtual void zadajeszcios(Bohater obiekt)
        {
            this.dmg = atak.Next(1, 10) + obiekt.bonusatak; 
            this.hp = this.hp - this.dmg;
            Console.WriteLine($"{this.profesja} otrzymał {dmg} punktów obrażeń od {obiekt.rasa}");
            Console.WriteLine($"Posiadasz {this.hp} punktów zdrowia");
            if (this.hp <= 0)
            {
                this.zycie = false;
                this.zywotnosc = 0;
                Console.WriteLine($"{this.profesja} zginął!");
                Gui.koniec();
                Environment.Exit(0);
            }
            else
                this.zywotnosc = (double)this.hp / (double)this.maksymalnehp;
        }
        public virtual void podnoszeniemikstury()
        {
            this.mikstura++;
            Console.WriteLine($"Gratulacje zyskałeś miksturę zdrowia! Posiadasz już {this.mikstura} mikstur zdrowia!");
        }
        public virtual void miksturahp()
        {
            if(this.mikstura>0)
            {
                this.bonushp = 30;
                this.hp = this.hp + this.bonushp;
                this.mikstura--;
                Console.WriteLine($"Użyłeś mikstury, teraz posiadasz {this.hp} punktów zdrowia");
                Console.WriteLine($"Posiadasz {this.mikstura} mikstur zdrowia");
            }else
            {
                Console.WriteLine("Nie posiadasz mikstur zdrowia");
            }
        }
        public virtual void levelup()
        {
            this.bonusatak += 1;
            this.hp = this.hp + 5;
            Console.WriteLine("Level up! Dostałeś + 1 do ataku oraz +5 do zdrowia!");
        }
    }
    class Wojownik : Bohater
    {
        public Wojownik(Rasa rasa) : base(rasa)
        {
            this.profesja = Profesja.Wojownik;
            this.maksymalnehp = 65;
            this.hp = maksymalnehp;
            this.bonusatak = 1;
        }

    }
    class Czarodziej:Bohater
    {
        public Czarodziej(Rasa rasa):base(rasa)
        {
            this.profesja = Profesja.Czarodziej;
            this.maksymalnehp = 55;
            this.hp = maksymalnehp;
            this.bonusatak = 3;
        }
    }
    class Łucznik : Bohater
    {
        public Łucznik(Rasa rasa) : base(rasa)
        {
            this.profesja = Profesja.Łucznik;
            this.maksymalnehp = 60;
            this.hp = maksymalnehp;
            this.bonusatak = 2;
        }
    }
    class Niedźwiedź:Bohater
    {
        public Niedźwiedź(Rasa rasa):base(rasa)
        {
            this.rasa = Rasa.Niedźwiedź;
            this.maksymalnehp = 20;
            this.hp = maksymalnehp;
            this.bonusatak = 2;
        }
    }
    class Wilk: Bohater
    {
        public Wilk(Rasa rasa) : base(rasa)
        {
            this.rasa = Rasa.Wilk;
            this.maksymalnehp = 20;
            this.hp = maksymalnehp;
            this.bonusatak = 1;
        }
    }
    class Goblin : Bohater
    {
        public Goblin(Rasa rasa) : base(rasa)
        {
            this.rasa = Rasa.Goblin;
            this.maksymalnehp = 25;
            this.hp = maksymalnehp;
            this.bonusatak = 2;
        }
    }
    class Ork : Bohater
    {
        public Ork(Rasa rasa) : base(rasa)
        {
            this.rasa = Rasa.Ork;
            this.maksymalnehp = 30;
            this.hp = maksymalnehp;
            this.bonusatak = 1;
        }
    }
    class Bandyta : Bohater
    {
        public Bandyta(Rasa rasa) : base(rasa)
        {
            this.rasa = Rasa.Bandyta;
            this.maksymalnehp = 15;
            this.hp = maksymalnehp;
            this.bonusatak = 2;
        }
    }
    class NAIZDUP : Bohater
    {
        public NAIZDUP(Rasa rasa) : base(rasa)
        {
            this.rasa = Rasa.NAIZDUP;
            this.maksymalnehp = 40;
            this.hp = maksymalnehp;
            this.bonusatak = 3;
        }
    }
}
