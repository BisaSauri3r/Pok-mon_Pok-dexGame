using System;
using System.Runtime.InteropServices;
using static PokedexGame.Entries;

namespace PokedexGame
{
    class Program
    {
        // Optische Anpassungen
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        static void Main(string[] args)
        {
            // Fenster auf Bildschirmgröße erweitern
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            // Einleitung
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                  ,'\\ ");
            Console.WriteLine("    _.----.____         ,'  _\\   ___    ___     ____ ");
            Console.WriteLine("_,-'       `.     |    |  /`.   \\,-' |   \\  /   |   |    \\  |`.  ");
            Console.WriteLine("\\      __    \\    '-.  | /   `.  ___    |    \\/    |   ' -.   \\ |  |  ");
            Console.WriteLine(" \\.    \\ \\   | __ |  |/    ,','_  `.  |          | __ |    \\|  |  ");
            Console.WriteLine("   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |  ");
            Console.WriteLine("    \\     , -'/  /   \\    ,' | \\/ / ,`.|         /  /   \\  |     |  ");
            Console.WriteLine("     \\    \\ |   \\_ /  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |  ");
            Console.WriteLine("      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |  ");
            Console.WriteLine("       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,' |  | |   |  ");
            Console.WriteLine("        \\_.- '       |__|    `-._ |              ' -.| '-.| |   |  ");
            Console.WriteLine("                                `'                            ' -._ |  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Willkommen zum Pokédex-Game!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Spielregeln:");
            Console.WriteLine("");
            Console.WriteLine("Du bekommst drei Beschreibungen zu einem Pokémon. Die erste Beschreibung enthält den Typ oder die Typen des Pokémon,\ndie zweite, ob es sich um eine Basis- oder Evolutionsstufe handelt,\nund die dritte den Pokédexeintrag.\nAlle POkémon aus diesem Quiz stammen aus der ersten Generation und somit aus der Kanto-Region.");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╚ Steuerung:                                                                                                                                 ╗");
            Console.WriteLine("╚                                                                                                                                            ╗");
            Console.WriteLine("╚ w        würfel nach einem neuen Pokémon                                                                                                   ╗");
            Console.WriteLine("╚ e        beende die Runde und lasse dir deinen Endpunktestand und deinen Trainerstatus anzeigen anzeigen                                   ╗");
            Console.WriteLine("╚                                                                                                                                            ╗");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╚ bitte bestätige alle deine Eingaben mit Enter                                                                                              ╗");
            Console.ResetColor();
            Console.WriteLine("╚                                                                                                                                            ╗");
            Console.WriteLine("╚ Drücke s um das Spiel zu starten.                                                                                                          ╗");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("");

            string sUserAction = Console.ReadLine();

            if (sUserAction == "s")
            {
                Console.Clear();
                Entries.RandomEntry();
            } else
            {
                Console.WriteLine("Steuerung:");
                Console.WriteLine("w        würfel nach einem neuen Pokémon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter    bitte bestätige alle deine Eingaben mit Enter");
                Console.ResetColor();
                Console.WriteLine("e        beende die Runde und lasse dir deinen Endpunktestand und deinen Trainerstatus anzeigen anzeigen");
                Console.WriteLine("");
                Console.WriteLine("Drücke s um das Spiel zu starten.");
                Console.WriteLine("");
                Console.ReadLine();
                Entries.RandomEntry();
            }

        }
    }
}