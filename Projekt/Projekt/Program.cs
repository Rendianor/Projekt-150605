using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int działanie;
            Bohater wybór;
            Niedźwiedź niedźwiedź = new Niedźwiedź(Rasa.Niedźwiedź);
            Wilk wilk = new Wilk(Rasa.Wilk);
            Goblin goblin = new Goblin(Rasa.Goblin);
            Ork ork = new Ork(Rasa.Ork);
            Bandyta bandyta = new Bandyta(Rasa.Bandyta);
            NAIZDUP naizdup = new NAIZDUP(Rasa.NAIZDUP);
            Gui.Tytuł();
            do
            {
                Gui.Opcje(1, "Rozpoczęcie gry! ");
                Gui.Opcje(2, "Informacja o twórcy ");
                Gui.Opcje(0, "Zamknij grę! ");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                    if (działanie >= 0 && działanie <= 2) break;
                } while (true);
                switch (działanie)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("O Grze : Wcielamy się w jednego z trzech bohaterów, który podąża przez jaskinie aby uratować wioskę przed Strongmanem");
                        Console.WriteLine("Gra posiada 3 etapy jaskini, za przejścię jednego dostajemy bonusy do statystyk.");
                        Console.WriteLine("Każdy kolenych etap gry jest trudniejszy!\n");
                        Console.WriteLine("Gre wykonał Kacper Woźnicki");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (działanie == 2 || działanie == 0);
            Console.Clear();
            Console.WriteLine("Masz do wybóru trzy klasy, każda z klas ma swoje plusy i minusy więc wybieraj mądrze!");
            Console.WriteLine("1 - Pierwszą klasą jest Wojownik/Krasnolud. Posiada 65 zdrowia oraz +1 do ataku!");
            Console.WriteLine("2 - Drugą klasą jest Czarodziej/Elf. Posiada 55 zdrowia oraz +3 do ataku!");
            Console.WriteLine("3 - Trzecią klasą jest Łucznik/Człowiek. Posiada 60 zdrowia oraz +2 do ataku!");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                if (działanie >= 1 && działanie <= 3) break;
            } while (true);
            switch (działanie)
            {
                case 1:
                    wybór = new Wojownik(Rasa.Krasnolud);
                    break;
                default:
                case 2:
                    wybór = new Czarodziej(Rasa.Elf);
                    break;
                case 3:
                    wybór = new Łucznik(Rasa.Człowiek);
                    break;
            }
            Console.Clear();
            Console.WriteLine("Znajdujesz się na początku jaskini! Po przejściu paru metrów ukazują ci się trzy drogi!");
            Console.WriteLine("1 - Prowadzi cię w Lewo stronę");
            Console.WriteLine("2 - Prowadzi cię w prosto");
            Console.WriteLine("3 - Prowadzi cię w Prawo stronę");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                if (działanie >= 1 && działanie <= 3) break;
            } while (true);
            if (działanie == 1)
            {
                Console.WriteLine("Atakauje cię Wilk!");
                do
                {
                    wybór.zadajeszcios(wilk);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        wilk.przyjmujeszcios(wybór);
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && wilk.hp > 0);
                wybór.podnoszeniemikstury();

            }
            else if (działanie == 2)
            {
                Console.WriteLine("Atakauje cię Bandyta!");
                do
                {
                    wybór.zadajeszcios(bandyta);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        bandyta.przyjmujeszcios(wybór);
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && bandyta.hp > 0);
                wybór.podnoszeniemikstury();
            }
            else if (działanie == 3)
            {
                Console.WriteLine("Atakauje cię Niedźwiedź!");
                do
                {
                    wybór.zadajeszcios(niedźwiedź);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        niedźwiedź.przyjmujeszcios(wybór);
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && niedźwiedź.hp > 0);
                wybór.podnoszeniemikstury();
            }
            Console.WriteLine("Koniec etapu 1");
            wybór.levelup();
            Console.WriteLine("\n");
            Console.WriteLine("Po krótkiej wędrówce przez ciemne korytarze, dostrzegasz dużą ilość szkieletów leżących na ziemi");
            Console.WriteLine("która wskazuję na dwa rozwidlenia");
            Console.WriteLine("1 - Aby pójść w lewę rozwidlenie");
            Console.WriteLine("2 - Aby pójść w prawe rozwidlenie");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                if (działanie >= 1 && działanie <= 2) break;
            } while (true);
            Console.Clear();
            if (działanie == 1)
            {
                Console.WriteLine("Atakauje cię Ork!");
                do
                {
                    wybór.zadajeszcios(ork);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        ork.przyjmujeszcios(wybór);
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && ork.hp > 0);
                wybór.podnoszeniemikstury();
            }
            else if (działanie == 2)
            {
                Console.WriteLine("Atakauje cię Goblin!");
                do
                {
                    wybór.zadajeszcios(goblin);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        goblin.przyjmujeszcios(wybór);
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && goblin.hp > 0);
                wybór.podnoszeniemikstury();
            }

            Console.WriteLine("Koniec etapu 2");
            wybór.levelup();
            Console.WriteLine("\n");
            Console.WriteLine("Rozglądając się dostrzegasz wrota, które powoli zaczynają się otwierać");
            Console.WriteLine("Po otwarciu wrót, zauważasz duże legowisko a w nim siedzący na tronie NAIZDUP!");
            Console.WriteLine("\n");
            Gui.naizdupobrazek();
            Console.WriteLine("Widząc go, strach przechodzi przez twoje ciało.");
            Console.WriteLine("1 - Zacznij walkę!");
            Console.WriteLine("2 - Uciekaj!");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                if (działanie >= 1 && działanie <= 2) break;
            } while (true);
            Console.Clear();
            if (działanie == 1)
            {
                do
                {
                    wybór.zadajeszcios(naizdup);
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Użyj mikstury");
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                        if (działanie >= 1 && działanie <= 2) break;
                    } while (true);
                    if (działanie == 1)
                    {
                        naizdup.przyjmujeszcios(wybór);
                        if (naizdup.hp <= 0)
                        {
                            Console.WriteLine("Konającym głosem mówi ... 'to by nic nie dało'");
                        }
                    }
                    else if (działanie == 2)
                    {
                        wybór.miksturahp();
                    }

                } while (wybór.hp > 0 && naizdup.hp > 0);
            }
            else if (działanie == 2)
            {
                Console.WriteLine("A więc zostawiasz bezbronne miasteczko, przed potężnym NAIZDUP?");
                Console.WriteLine("Uciekasz jak słabiak!");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Zamknij grę");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out działanie)) continue;
                    if (działanie ==1) break;
                } while (true);
                if(działanie == 1)
                {
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Koniec etapu 3");
            Console.WriteLine("\n");
            Console.WriteLine("BRAWO URATOWAŁEŚ MIASTECZKO! MIESZKAŃCY SĄ CI OGROMNIE WDZIĘCZNI!");
            Console.WriteLine("TERAZ KAŻDY BĘDZIE ŻYŁ DŁUGO I SZCZĘŚLIWIE");
            Console.WriteLine("\n");
            Gui.koniec();
            System.Console.ReadKey();
        }
    }
}

