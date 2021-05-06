using System;

namespace Gilbert
{
    class Program
    {
        static void Schema()
        {
            Console.WriteLine("Måndag: Tomt");
            Console.WriteLine("Tisdag: Träffa Alfe");
            Console.WriteLine("Onsdag: Tomt");
            Console.WriteLine("Torsdag: Tomt");
            Console.WriteLine("Fredag: Köpa chips");
            Console.WriteLine("Lördag: Träffa Alfe");
            Console.WriteLine("Söndag: Tomt");
        }
        static void Main(string[] args)
        {
            //Spel inledningen börjar här

            Console.WriteLine("Välkommen till Gilberts Resor!");
            Console.WriteLine("En historia baserat på livet i värmdö");
            Console.WriteLine("Klicka valfri knapp för att fortsätta");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Gilbert: Jag borde kolla mitt schema");
            Console.WriteLine("Klicka valfri knapp för att öppna schema");
            Console.ReadLine();
            Console.Clear();
            Schema();
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Mamma: Gilbert kan du gå och hämta posten!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Gilbert: MAMMA JAG SPELAR FORTNITE!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mamma: HÄMTA POSTEN NU!");
            Console.WriteLine("Hämtar du posten?");

            //Spel inledningen avslutas här
            //--------------------------------------------------------------------------------------------------
            //Spel koden börjar här

            string Fråga1 = "";
            string Fråga2 = "";
            Console.ReadLine();
            if (Fråga1 != "Ja" || Fråga1 != "ja")
            {
                Console.WriteLine("Gilbert går ut med soporna itsället");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Gilber: Jag önskar jag var rik så jag kunde köpa massor av...");
                Console.ReadLine();
                Console.WriteLine("Okänd: Ey! Kolla lil grabben som tror han är något!");



            }
            else if (Fråga1 != "Nej" || Fråga1 != "nej")
            {
                Console.WriteLine("Mamma: Jävla ungjävel");
                Console.ReadLine();
                Console.WriteLine("Du blir utslängd från hemmet");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Okänd: Ey! Kolla lil grabben som tror han är något!");
            }

            Console.WriteLine("Gilbert ser ett par gangstrar gå långsamt mot honom");
            Console.WriteLine("Ska Gilbert springa ?");
            Console.WriteLine("Springa = Ja");
            Console.WriteLine("Stanna = Nej");
            Console.ReadLine();

            if (Fråga2 != "Ja" || Fråga2 != "ja")
            {
                Console.WriteLine("Gilbert sprang till ica runt hörnet och såg aldrig dem igen");
                Console.WriteLine("Game Over");
                Console.ReadLine();
                Console.Clear();
            }

            else if (Fråga2 != "Nej" || Fråga2 != "nej")
            {
                Console.WriteLine("Okänd: Ey! Jag ska slå sönder dig!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Gilber: Nej jag vill inte");
                Console.WriteLine("Den okända mannen puttade gilbert och fighten börja");
                Console.ReadLine();
                Console.Clear();


                string gilbert = "Gilbert";
                int gilbertliv = 100;
                int gilbertskada;
                string gangster = "Gangster";
                int gangsterliv = 100;
                int gangsterskada;
                Random generator = new Random();

                while (gilbertliv > 0 && gangsterliv > 0)
                {
                    Console.WriteLine(gangster + " " + gangsterliv + "HP");
                    Console.WriteLine(gilbert + " " + gilbertliv + "HP");
                    Console.WriteLine("Klicka Enter För Att Slåss!");
                    Console.ReadLine();


                    gilbertskada = generator.Next(1, 20);
                    gangsterliv = gangsterliv - gilbertskada;
                    if (gilbertskada == 0)
                    {
                        Console.WriteLine(gangster + " Blev inte träffad!");
                    }

                    else
                    {
                        Console.WriteLine(gangster + " tog " + gilbertskada + " Skada");
                    }

                    gangsterskada = generator.Next(1, 15);
                    gilbertliv = gilbertliv - gangsterskada;
                    if (gangsterskada == 0)
                    {
                        Console.WriteLine(gilbert + " Blev inte träffad!");
                    }
                    else
                    {
                        Console.WriteLine(gilbert + " tog" + gangsterskada + " Skada");
                    }

                }
                if (gangsterliv > 0)
                {
                    Console.WriteLine("Gilbert vart nedslagen och mobbad");
                }
                else if (gilbertliv > 0)
                {
                    Console.WriteLine("Gilbert vann fighten mot gangstern och är poppis på värmdö nu");
                }


            }

            else
            {
                Console.WriteLine("Gilbert vart forvirrad och nedslagen");
                Console.WriteLine("Game Over");
            }




            Console.ReadLine();
        }
    }
}
