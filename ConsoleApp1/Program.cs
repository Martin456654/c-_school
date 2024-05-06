using System;

namespace ConsoleApp
{
    class Program
    {
        // Deklarace pole pro ukládání jmen
        static string[] names = new string[5];

        static void Main(string[] args)
        {
            // Výpis uvítací zprávy do konzole
            Console.WriteLine("Vítejte v konzolové aplikaci!");

            // Volání metody pro načtení jmen od uživatele
            LoadNames();

            // Volání metody pro výpis jmen uložených v poli
            PrintNames();

            // Volání metody pro výpočet průměrného věku
            CalculateAverageAge();

            // Zpráva na závěr, která instruuje uživatele, aby stiskl libovolnou klávesu pro ukončení programu
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení.");
            // Čekání na stisknutí libovolné klávesy
            Console.ReadKey();
        }

        // Metoda pro načtení jmen od uživatele a uložení do pole
        static void LoadNames()
        {
            // Výpis instrukcí pro uživatele
            Console.WriteLine("Zadejte jména:");

            // Cyklus pro načtení jmen od uživatele a uložení do pole
            for (int i = 0; i < names.Length; i++)
            {
                // Výpis promptu pro uživatele
                Console.Write($"Jméno {i + 1}: ");
                // Načtení jména od uživatele a uložení do pole
                names[i] = Console.ReadLine();
            }
        }

        // Metoda pro výpis jmen uložených v poli
        static void PrintNames()
        {
            // Výpis nadpisu pro vypsaná jména
            Console.WriteLine("\nVložená jména:");

            // Cyklus pro výpis jmen uložených v poli
            foreach (string name in names)
            {
                // Výpis jednoho jména
                Console.WriteLine(name);
            }
        }

        // Metoda pro výpočet průměrného věku
        static void CalculateAverageAge()
        {
            // Výpis instrukcí pro uživatele
            Console.WriteLine("\nZadejte věk:");

            int sum = 0;

            // Cyklus pro načtení věku od uživatele a výpočet průměru
            for (int i = 0; i < names.Length; i++)
            {
                // Výpis promptu pro uživatele
                Console.Write($"Věk pro {names[i]}: ");
                bool validInput = false;

                // Smyčka pro ověření správnosti vstupu
                while (!validInput)
                {
                    // Načtení věku od uživatele jako text
                    string input = Console.ReadLine();
                    // Pokus o převedení textu na číslo a uložení výsledku do proměnné age
                    if (int.TryParse(input, out int age))
                    {
                        // Přičtení věku k celkovému součtu
                        sum += age;
                        // Nastavení validInput na true, pokud vstup byl platný
                        validInput = true;
                    }
                    else
                    {
                        // Výpis chybové zprávy pro uživatele, pokud vstup nebyl platný
                        Console.WriteLine("Neplatný vstup. Zadejte prosím platné číslo.");
                        // Výpis promptu pro uživatele, aby znovu zadal věk
                        Console.Write($"Věk pro {names[i]}: ");
                    }
                }
            }

            // Výpočet průměrného věku
            double averageAge = (double)sum / names.Length;
            // Výpis průměrného věku do konzole
            Console.WriteLine($"Průměrný věk: {averageAge}");
        }
    }
}
