using System;
namespace L3_OPDR1
{
    public class Person
    {
        //hier zorgen we voor de naam
        private string name;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            string[] args = name.Split(" ");

            if (name == "" || args.Length > 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hmm. deze naam klopt niet");
                Console.ResetColor();
                Console.WriteLine("probeer het nog is met een juiste naam"); name = Console.ReadLine();
                SetName(name);
                // return om fouten te voorkomen.
                return;
            }
            else
            {
                foreach (char c in name)
                {
                    if (Char.IsDigit(c))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hmm. deze naam klopt niet");
                        Console.ResetColor();
                        Console.WriteLine("probeer het nog is met een juiste naam");
                        name = Console.ReadLine();
                        SetName(name);
                        // return om fouten te voorkomen.
                        return;
                    }
                    else
                    {
                        this.name = name;
                    }
                }

            }
        }

        //hier zorgen we voor het land
        private string Gebland = "None";
        private string land;
        public string GetLand()
        {
            return Gebland;
        }


        public void SetLand(string land)
        {
            bool mag = false;

            foreach (string s in CountryList.LIST)
            {
                if (land.Equals(s))
                {
                    mag = true;
                }
            }
            if (mag == true)
            {
                this.Gebland = land;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Hmm. Ik herken het land niet");
                Console.ResetColor();
                Console.WriteLine("probeer het nog is (type je land)");
                string Gebland = Console.ReadLine();
                SetLand(Gebland);
            }
        }
        // hier zorgen we voor oogkleur

        private string oogkleur;
        public string GetOogkleur()
        {
            return oogkleur;
        }
        public void SetOogkleur(string oogkleur)
        {
            bool kleurmag = false;
            foreach (string os in oogkleuren.oogkleurenlist)
            {
                if (oogkleur == os)
                {
                    kleurmag = true;
                }
            }
            if (kleurmag == true)
            {
                this.oogkleur = oogkleur;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hmm. Ik herken deze kleur niet");
                Console.ResetColor();
                Console.WriteLine("probeer het nog is met een juiste / echte kleur");
                oogkleur = Console.ReadLine();
                SetOogkleur(oogkleur);
            }
        }
        // hier zorgen we voor de lengte
        private int Length = 0;
        public int GetLengte()
        {
            return Length;
        }
        public void SetLengte(string lengte)
        {
            bool isgoed = true;
            bool isChecking = true;

            while (isChecking == true)
            {
                foreach (char c in lengte)
                {
                    // Als er een letter in het woord zit kan het niet meer :)
                    if (Char.IsLetter(c))
                    {
                        isgoed = false;
                    }
                }

                if (isgoed == true)
                {
                    isChecking = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("hmm.. dit klopt niet helemaal probeer het opnieuw");
                    Console.ResetColor();
                    SetLengte(Console.ReadLine());
                }
            }
        }
        // hier zorgen we voor leeftijd.
        private int leeftijd = 0;
        public int GetLeeftijd()
        {
            return leeftijd;
        }
        public void SetLeeftijd(string leeftijd)
        {
            Boolean controlegedaan = false;
            Boolean goedgekeurd = true;

            while (controlegedaan == false)
            {
                goedgekeurd = true;
                if (leeftijd == "")
                {
                    // als de leeftijd leeg is gaat er iets fout
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("er is iets niet goed gegaan, probeer het opnieuw");
                    Console.ResetColor();
                    leeftijd = Console.ReadLine();
                }
                else
                {
                    // anders als de leeftijd wel is ingevuld
                    foreach (char c in leeftijd)
                    {
                        if (Char.IsLetter(c))
                        {
                            goedgekeurd = false;
                        }
                    }
                    if (goedgekeurd == true)
                    {
                        if (Convert.ToInt32(leeftijd) > 0 && Convert.ToInt32(leeftijd) < 150)
                        {
                            this.leeftijd = (Convert.ToInt32(leeftijd));
                            controlegedaan = true;
                            goedgekeurd = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("leeftijd moet tussen de 0 en de 150 zijn");
                            Console.ResetColor();
                            leeftijd = Console.ReadLine();
                            // als je een te groten of te kleinen leeftijd heb doe de functie opnieuw
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Voer alleen getalen in. Geen letters!!, probeer het opnieuw");
                        Console.ResetColor();
                        controlegedaan = false;
                        goedgekeurd = false;
                        leeftijd = Console.ReadLine();
                    }
                }
            }
        }

        //hier zrogen we voor BSN nummer
        private int BSN = 0;
        public int GetBSN()
        {
            return BSN;
        }
        public void SetBSN(string bsn)
        {
            if (bsn.Length.Equals(9))
            {
                int number = Convert.ToInt32(bsn);
                this.BSN = number;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("hmm.. er is iets niet goed gegaan");
                Console.ResetColor();
                Console.WriteLine("vul nog is een bsn nummer in");
                string BSN = Console.ReadLine();
                SetBSN(BSN);
                return;
            }
        }

    }
}