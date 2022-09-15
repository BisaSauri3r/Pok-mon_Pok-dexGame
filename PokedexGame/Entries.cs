using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace PokedexGame
{
    class Entries
    {
        static Random rand = new Random();

        public static class Global
        {
            public static double iScore;
            public static double iRounds;
        }

        // Bisasam
        public static void P001()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon trägt von Geburt an einen Samen auf dem Rücken, der im Laufe der Zeit keimt und wächst.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "bisasam")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Bisasam!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Bisasam");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P002()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sobald die Knospe auf seinem Rücken groß wird, kann es nicht mehr auf zwei Beinen stehen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "bisaknosp")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Bisaknosp!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Bisaknosp");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P003()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es nutzt Solarenergie als Nahrung und bringt so seine große Blume zum Blühen. Es geht dorthin, wo die Sonne scheint.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "bisaflor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Bisaflor!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Bisaflor");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P004()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon bevorzugt heiße Dinge. Bei Regen soll seine Schwanzspitze dampfen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "glumanda")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Glumanda!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Glumanda");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P005()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es ist brutal veranlagt. Im Kampf schlägt es mit seinem brennenden Schweif um sich und schlitzt Gegner mit seinen scharfen Klauen auf.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "glutexo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Glutexo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Glutexo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P006()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer, Flug");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon kann mit seinem Feueratem Felsen schmelzen. Es verursacht ab und zu Waldbrände.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "glurak")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Glurak!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Glurak");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P007()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Zieht es seinen langen Hals in seinen Panzer zurück, verspritzt es Wasser mit unbändiger Kraft.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "schiggy")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Schiggy!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Schiggy");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P008()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es gilt als Symbol für Langlebigkeit. Sehr alte Exemplare erkennt man daran, dass ihr Panzer mit Algen übersät ist.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "schillok")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Schillok!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Schillok");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P009()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es begräbt seine Gegner mit seinem enormen Körpergewicht. Wenn es in einer aussichtslosen Lage steckt, zieht es sich in seinen Panzer zurück.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "turtok")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Turtok!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Turtok");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P010()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Als Schutz vor Feinden sondert es einen übel riechenden Gestank mit seinen Antennen ab.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "raupy")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Raupy!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Raupy");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P011()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: In diesem Zustand wartet es auf die Entwicklung. Es kann nur seinen Panzer erhärten, daher bewegt es sich nicht, um nicht angegriffen zu werden.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "safcon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Safcon!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Safcon");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P012()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Flug");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn es sehr schnell mit den Flügeln schlägt, setzt es hochgiftigen Flügelstaub frei.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "smettbo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Smettbo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Smettbo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P013()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Auf seinem Kopf befindet sich ein spitzer Stachel. Es versteckt sich im hohen Gras sowie in Wäldern und frisst eifrig Blätter.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "hornliu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Hornliu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Hornliu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P014()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Obwohl es sich kaum bewegen kann, ist es bei Gefahr in der Lage, einen Stachel auszufahren, mit dem es seine Gegner vergiftet.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kokuna")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kokuna!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kokuna");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P015()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Gift");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es verfügt über insgesamt drei Giftstachel, zwei an den Armen und einen am Hinterleib, mit denen es seine Gegner wiederholt angreift.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "bibor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Bibor!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Bibor");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P016()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Ein sanftmütiges Pokémon, welches lieber Sand zum Schutz aufwirbelt, als zurückzuschlagen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "taubsi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Taubsi!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Taubsi");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P017()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Dieses kraftvolle Pokémon wacht unermüdlich über sein riesiges Territorium und fliegt weite Strecken auf der Suche nach Beute.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tauboga")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tauboga!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tauboga");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P018()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Auf der Jagd nach Beute fliegt es mit einer Geschwindigkeit von bis zu Mach 2. Seine mächtigen Klauen gelten als gefürchtete Waffen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tauboss")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tauboss!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tauboss");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P019()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es knabbert mit seinen zwei Nagezähnen alles und jeden an. Stößt man auf eines, findet man sicherlich 40 weitere in der Gegend.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rattfratz")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rattfratz!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rattfratz");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P020()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Die Hinterbeine dieses Pokémon verfügen über kleine Schwimmhäute. So kann es in Flüssen jagen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rattikarl")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rattikarl!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rattikarl");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P021()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: In großen Höhen fällt ihm das Fliegen schwer. Allerdings kann es pfeilschnell umherflitzen, wenn es um den Schutz seines Habitats geht.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "habitak")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Habitak!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Habitak");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P022()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon gehört einer sehr alten Spezies an. Wittert es Gefahr, so fliegt es sofort in große Höhen davon.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "ibitak")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Ibitak!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Ibitak");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P023()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Mit dem Alter wird der Körper dieses Pokémon immer länger. Nachts wickelt es sich um Äste, um zu ruhen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rettan")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rettan!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rettan");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P024()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Von dem furchterregenden Muster auf seinem Bauch wurden durch Studien bislang sechs verschiedene Varianten entdeckt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "arbok")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Arbok!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Arbok");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P025()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Je stärker die Elektrizität ist, die es produziert, desto weicher und elastischer sind seine Backentaschen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "pikachu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Pikachu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Pikachu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P026()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sein langer Schweif dient ihm zur Erdung. So bleibt es von der lähmenden Wirkung von Hochspannung selbst verschont.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "raichu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Raichu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Raichu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P027()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es badet sehr gern im trockenen Sand. Dadurch befreit es seinen Körper von Schmutz und Feuchtigkeit.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sandan")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sandan!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sandan");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P028()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Je trockener das Gebiet ist, in dem es lebt, desto härter und glatter fühlen sich die Stacheln an seinem Rücken an.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sandamer")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sandamer!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sandamer");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P029()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Sie sind geruchsempfindlicher als Nidoran♂. Auf Nahrungssuche folgen sie der Windrichtung, die sie mit ihren Tasthaaren ermitteln.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidoran")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidoran♀!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidoran♀");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P030()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Man geht davon aus, dass sich das Horn auf ihrem Kopf zurückgebildet hat, damit sie ihre Jungen nicht beim Füttern verletzen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidorina")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidorina!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidorina");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P031()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift, Boden");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sie sind eher defensiv als offensiv veranlagt. Mit ihren panzerartigen Schuppen schützen sie ihre Jungen vor jeglichen Angriffen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidoqueen")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidoqueen!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidoqueen");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P032()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Das Horn auf seiner Stirn enthält ein starkes Gift. Dieses Pokémon ist sehr vorsichtig und stellt seine großen Ohren stets wachsam auf.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidoran")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidoran♂!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidoran♂");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P033()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Auf der Suche nach einem Mondstein zerstört es Felsen mit seinem Horn, das härter ist als ein Diamant.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidorino")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidorino!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidorino");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P034()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift, Boden");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Gerät es in Rage, ist es nur schwer aufzuhalten. Doch vor einem Nidoqueen, mit dem es schon viele Jahre verbracht hat, zeigt es sich friedlich.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nidoking")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nidoking!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nidoking");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P035()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Fee");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Eine Ansammlung von seiner Art bei Vollmond tanzen zu sehen, soll ein glückliches Leben verheißen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "piepi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Piepi!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Piepi");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P036()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Fee");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Ein feenhaftes und scheues Pokémon, das sofort die Flucht ergreift, wenn es Menschen wahrnimmt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "pixi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Pixi!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Pixi");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P037()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: In seiner Jugend hat es sechs hinreißende Schweife. Während es wächst, kommen noch weitere neue Schweife hinzu.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "vulpix")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Vulpix!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Vulpix");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P038()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Man sagt, es lebe 1 000 Jahre und jedem seiner Schweife wohnen übernatürliche Kräfte inne.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "vulnona")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Vulnona!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Vulnona");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P039()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Fee");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Sein Lungenvolumen übersteigt das der meisten anderen Pokémon. Es singt so lange Schlaflieder, bis seine Gegner eingenickt sind.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "pummeluff")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Pummeluff!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Pummeluff");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P040()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Fee");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Je mehr Luft es einatmet, desto größer wird es. Ist es verärgert, bläst es seinen Körper enorm auf und schüchtert so seine Gegner ein.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "knuddeluff")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Knuddeluff!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Knuddeluff");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P041()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Flug, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Über den Mund stößt es Ultraschallwellen aus, um seine Umgebung zu erkunden. So kann es selbst in engen Höhlen geschickt umherfliegen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "zubat")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Zubat!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Zubat");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P042()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Flug, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Das Blut anderer Lebewesen ist seine Leibspeise. Man sagt, dass es das abgesaugte Blut manchmal mit hungrigen Artgenossen teilt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "golbat")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Golbat!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Golbat");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P043()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Wird es vom Mondschein getroffen, bewegt es sich. Nachts wandert es weite Wege, um seine Samen zu verstreuen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "myrapla")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Myrapla!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Myrapla");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P044()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sein Stempel sondert einen unglaublich faulen Gestank ab. Dieser stechende Geruch kann selbst bis zu 2 km entfernte Gegner bewusstlos machen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "duflor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Duflor!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Duflor");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P045()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es besitzt die größten Blütenblätter der Welt. Bei jedem Schritt streut es große Mengen an Giftpollen zu Boden.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "giflor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Giflor!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Giflor");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P046()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Pflanze");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es gräbt sich in den Boden, um Baumwurzeln Nährstoffe zu entziehen. Den Großteil davon absorbieren jedoch die Pilze auf seinem Rücken.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "paras")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Paras!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Paras");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P047()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Pflanze");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Der Pilz auf Paraseks Rücken nutzt das Pokémon als Wirt und entzieht ihm Energie. Es scheint, als habe er die Kontrolle über das Pokémon.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "parasek")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Parasek!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Parasek");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P048()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine großen Augen fungieren als Radar. Im Licht kann man erkennen, dass sie aus unzähligen, sehr kleinen Augen bestehen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "bluzuk")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Bluzuk!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Bluzuk");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P049()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Berührt man die staubartigen Schuppen auf seinen Flügeln, heften diese sich hartnäckig am Körper an und sondern darüber hinaus Gift ab.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "omot")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Omot!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Omot");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P050()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Bewegt sich ein Digda unterirdisch fort, pflügt es dabei den Erdboden gleich mit und bereitet so den Anbau von Feldfrüchten vor.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "digda")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Digda!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Digda");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P051()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Diese Drillinge graben sich manchmal bis zu 100 km tief in den Erdboden und lösen dadurch Erdbeben aus.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "digdri")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Digdri!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Digdri");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P052()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es sammelt mit Vorliebe glänzende Gegenstände. Ist es gut gelaunt, lässt es seinen Trainer einen Blick auf seine Sammlung werfen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "mauzi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Mauzi!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Mauzi");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P053()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es ist sehr stolz, was es nicht leicht macht, mit ihm Freundschaft zu schließen. Wenn ihm etwas missfällt, fährt es unverzüglich die Krallen aus.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "snobilikat")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Snobilikat!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Snobilikat");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P054()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es leidet permanent unter Kopfschmerzen. Wenn es seine geheimnisvollen Kräfte freisetzt, sollen die Schmerzen für eine Weile nachlassen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "enton")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Enton!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Enton");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P055()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon lebt in sanft fließenden Flüssen. Mit seinen langen Gliedmaßen schwimmt es voller Eleganz durch das Wasser.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "entoron")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Entoron!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Entoron");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P056()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist sehr agil und lebt auf Bäumen. Aufgrund seiner hitzköpfigen Natur wird es schnell wütend, was dazu führt, dass es alles und jeden angreift.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "menki")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Menki!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Menki");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P057()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es hört lediglich dann auf zu toben, wenn niemand in der Nähe ist. Diesen Anblick zu Gesicht zu bekommen, ist daher nicht einfach.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rasaff")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rasaff!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rasaff");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P058()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist von Natur aus tapfer und vertrauenswürdig und scheut auch vor Gegnern nicht zurück, die größer und stärker sind als es selbst.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "fukano")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Fukano!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Fukano");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P059()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Viele Trainer sind davon fasziniert, dass dieses Pokémon innerhalb eines Tages 10 000 km zurücklegen kann.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "arkani")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Arkani!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Arkani");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P060()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es kann besser schwimmen als laufen. Das Spiralmuster auf seinem Bauch ist ein Teil seiner Innereien, der durch die Haut sichtbar ist.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "quapsel")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Quapsel!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Quapsel");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P061()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wer länger auf seine Bauchspirale blickt, wird schläfrig. Manche Leute nutzen dies anstelle eines Schlaflieds, damit ihre Kinder einschlafen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "quaputzi")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Quaputzi!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Quaputzi");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P062()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Kampf");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sein ganzer Körper besteht fast nur aus Muskeln. In kalten Meeren zerschlägt es mit seinen starken Armen Treibeis, um voranzukommen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "quappo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Quappo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Quappo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P063()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es setzt seine Psycho-Kräfte selbst im Schlaf ein. Der Inhalt seiner Träume hat Einfluss auf die Kräfte, die es verwendet.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "abra")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Abra!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Abra");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P064()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Seine Psycho-Kräfte ermöglichen es ihm, schwebend zu schlafen. Seinen äußerst elastischen Schweif nutzt es dabei als Kissen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kadabra")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kadabra!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kadabra");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P065()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es verfügt über extrem hohe Intelligenz und soll sich an alles erinnern können, was zwischen seiner Geburt und seinem Tod passiert.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "simsala")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Simsala!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Simsala");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P066()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Sein ganzer Körper besteht aus Muskeln. Auch wenn es nur so groß wie ein Menschenkind ist, kann es 100 Erwachsene jonglieren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "machollo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Machollo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Machollo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P067()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon ist superstark. Es kann sich nur mit einem kraftregulierenden Gürtel bewegen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "maschock")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Maschock!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Maschock");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P068()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es verwendet seine vier Arme, um seine Gegner unermüdlich mit schnellen Schlägen aus allen Winkeln einzudecken.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "machomei")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Machomei!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Machomei");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P069()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es bevorzugt einen warmen und feuchten Lebensraum. Es ernährt sich von kleinen Käfer-Pokémon, die es mit seinen Ranken fängt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "knofensa")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Knofensa!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Knofensa");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P070()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn es hungrig ist, schnappt es willkürlich nach allem, was sich bewegt. Nachdem es seine Beute verschluckt hat, schaltet es sie mit Säure aus.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "ultrigaria")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Ultrigaria!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Ultrigaria");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P071()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Gift");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es lockt Beute mit einem Duft an, der an Honig erinnert. Was in sein Maul gelangt, wird samt Knochen binnen eines Tages zersetzt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sarzenia")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sarzenia!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sarzenia");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P072()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Da es kein besonders guter Schwimmer ist, treibt es in seichten Gewässern an der Wasseroberfläche und sucht nach Beute.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tentacha")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tentacha!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tentacha");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P073()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Leuchten die roten Kugeln auf seinem Kopf stark auf, ist Vorsicht geboten, da es kurz danach Ultraschallwellen ausstoßen wird.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tentoxa")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tentoxa!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tentoxa");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P074()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Boden");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es hält sich gern in der Nähe von Gebirgspfaden auf. Tritt man versehentlich auf eins, wird es sehr wütend. Deshalb ist höchste Vorsicht geboten.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kleinstein")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kleinstein!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kleinstein");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P075()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Boden");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es rollt sich gerne Gebirgspfade hinunter. Dabei ist es ihm egal, wer oder was sich in seinem Weg befindet.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "georok")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Georok!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Georok");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P076()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Boden");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Nachdem es sich gehäutet hat, wird sein Körper weich und hell. Durch den Kontakt mit der Luft erhärtet er aber sofort wieder.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "geowaz")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Geowaz!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Geowaz");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P077()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Nach der Geburt fällt ihm das Laufen schwer. Die Wettrennen, die es sich mit seinen Freunden liefert, stärken jedoch seine Beinmuskulatur.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "ponita")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Ponita!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Ponita");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P078()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Die lodernde Mähne dieses Pokémon flattert im Wind, wenn es mit einer Geschwindigkeit von 240 km/h über Felder und Wiesen galoppiert.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "gallopa")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Gallopa!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Gallopa");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P079()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist so träge und unempfindlich, dass es keinen Schmerz verspürt, wenn seine Rute gegessen wird. Es bemerkt nicht einmal, dass sie nachwächst.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "flegmon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Flegmon!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Flegmon");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P080()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Psycho");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es entwickelte sich, als ein Muschas in seine Rute biss. Das süße Aroma, das aus der Rute strömt, hat Muschas in eine Art Trance versetzt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "lahmus")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Lahmus!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Lahmus");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P081()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro, Stahl");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Manchmal geht die Elektrizität in seinem Körper zur Neige, woraufhin es zu Boden fällt. Eine Batterie bringt es wieder in Bewegung.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "magnetilo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Magnetilo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Magnetilo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P082()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro, Stahl");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es entsteht durch den Zusammenschluss dreier Magnetilo und sendet starke Radiowellen aus, um seine Umgebung zu untersuchen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "magneton")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Magneton!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Magneton");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P083()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Unter seinem Flügel trägt es eine Lauchstange, die es wie ein Schwert gegen Feinde einsetzt und welche ihm im Bedarfsfall auch als Nahrung dient.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "porenta")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Porenta!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Porenta");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P084()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es kann nicht gut fliegen, weil seine Flügel zu klein sind. Dafür kann es mit seinen starken Beinen sehr schnell laufen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "dodu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Dodu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Dodu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P085()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal, Flug");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Bei seiner Entwicklung hat sich einer von Dodus Köpfen in zwei geteilt. Es flitzt mit einer Geschwindigkeit von 60 km/h über Wiesen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "dodri")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Dodri!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Dodri");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P086()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es bevorzugt eiskalte Lebensräume und schwimmt mit Vorliebe in -10 ºC kaltem Wasser.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "jurob")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Jurob!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Jurob");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P087()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Eis");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sein ganzer Körper ist schneeweiß. Da ihm Kälte nichts ausmacht, kann es selbst in Eiswasser kraftvoll schwimmen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "jugong")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Jugong!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Jugong");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P088()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist aus erhärtetem Schlamm entstanden. Es riecht sehr penetrant und man sollte es nicht berühren. Wo es hintritt, wächst kein Gras mehr.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sleima")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sleima!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sleima");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P089()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Sein fürchterlicher Gestank kann zur Ohnmacht führen. Da seine Nase so verkümmert ist, kann es selbst nichts mehr riechen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sleimok")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sleimok!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sleimok");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P090()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es schwimmt rückwärts, indem es seine Schale öffnet und schließt, und ist damit überraschend schnell.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "muschas")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Muschas!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Muschas");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P091()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Eis");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Seine Schale ist extrem hart und kann nicht einmal durch eine Bombe zerschmettert werden. Sie öffnet sich nur, wenn es angreift.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "austos")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Austos!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Austos");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P092()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Geist, Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist aus Gasen entstanden. Wird jemand in seinen gasförmigen, giftigen Körper gehüllt, so fällt er in Ohnmacht.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nebulak")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nebulak!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nebulak");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P093()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Geist, Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Seine Zunge besteht aus Gas. Schleckt es seine Opfer damit ab, zittern diese unentwegt, bis sie schließlich entschlafen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "alpollo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Alpollo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Alpollo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P094()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Geist, Gift");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn Schatten bei Vollmond plötzlich anfangen, sich zu bewegen und zu lachen, steckt zweifellos Gengar dahinter.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "gengar")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Gengar!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Gengar");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P095()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Boden");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Wenn es sich durch die Erde gräbt, nimmt es viele harte Gegenstände auf, die seinen Körper erhärten.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "onix")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Onix!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Onix");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P096()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Wenn man immer in der Nähe eines Traumato schläft, zeigt es einem nachts manchmal Träume, die es vor langer Zeit verspeist hat.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "traumato")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Traumato!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Traumato");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P097()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Läuft man einem Hypno über den Weg, sollte man wegsehen, da es andere mit dem Pendel in seiner Hand hypnotisieren kann.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "hypno")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Hypno!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Hypno");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P098()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es kommt vor allem nahe dem Meer vor. Die großen Scheren wachsen nach, wenn sie vom Körper abgetrennt wurden.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "krabby")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Krabby!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Krabby");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P099()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Die Kraft seiner großen und harten Schere entspricht 10 000 PS. Durch die Größe ist sie aber auch äußerst unhandlich und sperrig.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kingler")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kingler!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kingler");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P100()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Man sagt, es tarne sich als Pokéball, um sich zu schützen. Allerdings zerstört es sich schon bei der kleinsten äußeren Einwirkung selbst.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "voltobal")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Voltobal!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Voltobal");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P101()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es speichert elektrische Energie in seinem Körper. Schon die geringste Erschütterung lässt es explodieren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "lektrobal")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Lektrobal!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Lektrobal");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P102()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es mag zwar Eiern ähneln, ist aber ein echtes Pokémon, das aus sechs Individuen besteht, die wohl telepathisch miteinander kommunizieren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "owei")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Owei!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Owei");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P103()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze, Psycho");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Jeder der drei Köpfe hat einen eigenen Willen und scheint sich nur für sich selbst zu interessieren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kokowei")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kokowei!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kokowei");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P104()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Denkt es an seine verstorbene Mutter, so weint es. Sein Schluchzen hallt dabei in dem Schädel auf seinem Kopf klagend wider.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tragosso")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tragosso!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tragosso");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P105()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Als es seine Trauer überwand, entwickelte es sich und wurde stärker. Mit seinem Knochen als Waffe stellt es sich mutig seinen Feinden.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "knogga")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Knogga!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Knogga");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P106()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon besitzt einen formidablen Gleichgewichtssinn. Es kann in jeder Position pausenlos zutreten.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kicklee")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kicklee!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kicklee");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P107()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Kampf");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine Fäuste zerschneiden regelrecht die Luft. Sie sind so schnell, dass selbst die geringste Berührung Verbrennungen verursacht.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "nockchan")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Nockchan!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Nockchan");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P108()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Wäscht man sich nach der Berührung mit seinem klebrigen Speichel nicht, setzt bald ein starker Juckreiz ein, der nicht mehr zu stoppen ist.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "schlurp")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Schlurp!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Schlurp");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P109()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Sein Körper ist zum Bersten voll mit Giftgas. Angelockt vom fauligen Geruch verrottender Abfälle, lungert es auf Müllhalden herum.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "smogon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Smogon!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Smogon");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P110()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gift");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: In seinen beiden Körpern vermischt es Gase. Man sagt, dass es früher überall in der Galar-Region anzutreffen gewesen sei.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "smogmog")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Smogmog!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Smogmog");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P111()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden, Gestein");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon ist zwar nicht besonders klug, aber dafür so stark, dass es durch Rammen sogar Hochhäuser zum Einsturz bringen kann.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rihorn")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rihorn!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rihorn");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P112()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Boden, Gestein");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Nach seiner Entwicklung geht es aufrecht auf seinen Hinterbeinen. Mit seinem Horn kann es Löcher in Felsen bohren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rizeros")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rizeros!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rizeros");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P113()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine Eier sind äußerst nahrhaft und schmecken köstlich, weshalb sie als erlesene Kochzutat gelten.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "chaneira")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Chaneira!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Chaneira");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P114()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Pflanze");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine wahre Gestalt ist weiterhin ein Mysterium, da sie von Ranken verdeckt wird, die unaufhörlich nachwachsen, selbst wenn sie abreißen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tangela")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tangela!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tangela");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P115()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Obwohl es sein Junges im Beutel trägt, bewegt sich dieses Pokémon äußerst leichtfüßig. Gegner schreckt es mit blitzschnellen Schlägen ab.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kangama")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kangama!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kangama");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P116()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es lebt in Meeren mit ruhigem Gezeitenstrom. Wird es angegriffen, versprüht es tiefschwarze Tinte und ergreift daraufhin die Flucht.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "seeper")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Seeper!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Seeper");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P117()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Männlichen Pokémon dieser Art obliegt es, den Nachwuchs großzuziehen. In diesem Zeitraum ist das Gift in ihren Rückenstacheln stärker und dickflüssiger.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "seemon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Seemon!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Seemon");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P118()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine Brust-, Rücken- und Schwanzflossen bewegen sich anmutig. Daher nennt man es den „Wassertänzer“.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "goldini")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Goldini!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Goldini");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P119()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Im Herbst legt es an Gewicht zu und erscheint in prächtigen Farben, um so einen Partner anzulocken.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "golking")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Golking!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Golking");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P120()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Bei spätsommerlichen Strandbesuchen kann man Gruppen von Sterndu begegnen, deren Kerne in gleichmäßigem Rhythmus aufblinken.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sterndu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sterndu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sterndu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P121()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Psycho");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Das als Kern bezeichnete Organ dieses Pokémon erstrahlt in den sieben Farben des Regenbogens, wenn es mächtige Psycho-Kräfte entfesselt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "starmie")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Starmie!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Starmie");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P122()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho, Fee");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Viele Forscher glauben, seine Hände hätten nur deshalb so eine beachtliche Größe angenommen, damit es Pantomime praktizieren kann.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "pantimos")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Pantimos!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Pantimos");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P123()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Mit jedem Kampf werden seine Sicheln schärfer. Es kann selbst einen massiven Baumstamm mit nur einem Schnitt zerteilen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "sichlor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Sichlor!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Sichlor");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P124()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Eis, Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: In einer bestimmten Gegend von Galar wurde es einst als „Königin des Eises“ gleichermaßen gefürchtet wie verehrt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "rossana")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Rossana!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Rossana");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P125()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: In vielen Elektrizitätswerken werden Pokémon vom Typ Boden eingesetzt, um Elektek davon abzuhalten, den dortigen Strom anzuzapfen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "elektek")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Elektek!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Elektek");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P126()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es erlegt seine Beute mit Feuer. Manchmal röstet es diese zu seinem Bedauern so stark, dass sie versehentlich verkohlt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "magmar")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Magmar!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Magmar");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P127()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Käfer");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Der Status dieses Pokémons hängt von seinen Hörnern ab. Je dicker und stattlicher diese sind, desto beliebter ist es beim anderen Geschlecht.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "pinsir")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Pinsir!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Pinsir");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P128()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Peitscht es seinen Körper mit seinen Schweifen aus, ist Vorsicht geboten, denn es steht kurz davor, mit Karacho auf sein Ziel loszustürmen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "tauros")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Tauros!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Tauros");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P129()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist nutzlos, was Kraft und Geschwindigkeit angeht. Dieses Pokémon ist das schwächste und erbärmlichste der Welt.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "karpador")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Karpador!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Karpador");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P130()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Flug");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es ist von Natur aus sehr aggressiv. Der Hyperstrahl, den es aus seinem Maul verschießt, äschert seine Gegner ein.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "garados")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Garados!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Garados");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P131()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser, Eis");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Ein intelligentes und herzensgutes Pokémon. Während es auf dem Meer schwimmt, lässt es seinen herrlichen Gesang erklingen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "lapras")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Lapras!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Lapras");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P132()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es modifiziert seine Zellstruktur, um sich in alles zu verwandeln, was es sieht. Im entspannten Zustand nimmt es wieder seine Ausgangsform an.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "ditto")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Ditto!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Ditto");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P133()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist imstande, seinen Körper perfekt an die jeweilige Umgebung anzupassen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "evoli")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Evoli!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Evoli");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P134()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn seine Flossen beginnen zu vibrieren, ist das ein sicheres Zeichen dafür, dass in den nächsten Stunden Regen aufziehen wird.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "aquana")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Aquana!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Aquana");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P135()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn es erschrickt oder wütend wird, stellt sich sein Fell auf wie scharfe Nadeln und sticht den Gegner.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "blitza")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Blitza!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Blitza");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P136()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Wenn die Flamme in seinem Körper heiß genug brennt, kann seine Körpertemperatur bis zu 900 ºC erreichen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "flamara")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Flamara!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Flamara");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P137()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es ist weltweit das erste künstliche Pokémon, das dank neuester Technologien mittels Computerprogrammen erschaffen wurde.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "porygon")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Porygon!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Porygon");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P138()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Diese Pokémon entwickeln sich allmählich zu einem Problem, da einige wiederbelebte Exemplare fliehen oder freigelassen werden.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "amonitas")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Amonitas!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Amonitas");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P139()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es starb wohl aus, weil seine Bewegungen durch das große, schwere Gehäuse so langsam wurden, dass es keine Beute mehr fangen konnte.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "amoroso")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Amoroso!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Amoroso");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P140()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Wasser");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon ist so gut wie ausgestorben. Sein Panzer wird immer härter, indem es sich alle drei Tage häutet.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kabuto")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kabuto!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kabuto");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P141()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Wasser");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es schlitzt seine Beute auf und saugt ihre Körpersäfte aus. Die Überreste dienen als Nahrung für andere Pokémon.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "kabutops")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Kabutops!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Kabutops");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P142()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Gestein, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Selbst mit moderner Technologie scheint es unmöglich, ein perfektes Exemplar von diesem wilden urzeitlichen Pokémon zu reproduzieren.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "aerodactyl")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Aerodactyl!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Aerodactyl");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P143()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Normal");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es muss über 400 kg Nahrung am Tag fressen, um satt zu werden. Ist es mit dem Essen fertig, schläft es sofort ein.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "relaxo")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Relaxo!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Relaxo");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P144()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Eis, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Seine wunderschönen blauen Flügel sollen aus Eis bestehen. Es fliegt über schneebedeckte Berge, während sein langer Schweif hinter ihm flattert.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "arktos")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Arktos!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Arktos");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P145()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Elektro, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es kann Elektrizität manipulieren. Überlieferungen nach soll sein Nest inmitten pechschwarzer Gewitterwolken liegen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "zapdos")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Zapdos!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Zapdos");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P146()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Feuer, Flug");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Schlägt dieses Legendäre Vogel-Pokémon mit den Flügeln, so leuchten die Flammen an seinen Schwingen in einem bezaubernden Rot.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "lavados")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Lavados!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Lavados");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P147()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Drache");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Es lebt in der Nähe reißender Gewässer, wie etwa in tiefen Becken unter Wasserfällen. Es wächst, indem es sich immer wieder häutet.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "dratini")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Dratini!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Dratini");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P148()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Drache");
            Console.WriteLine("Stufe:           1. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Es lebt in klaren Meeren und Seen. Mit seiner Gabe, das Wetter zu beeinflussen, schwingt es sich auf dem Wind in den Himmel.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "dragonir")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Dragonir!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Dragonir");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P149()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Drache, Flug");
            Console.WriteLine("Stufe:           2. Stufe");
            Console.WriteLine("Pokédex-Eintrag: Erspäht dieses gutherzige Pokémon ertrinkende Menschen oder Pokémon, so kann es gar nicht anders, als sie zu retten.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "dragoran")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Dragoran!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Dragoran");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P150()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Dieses Pokémon und Mew weisen sehr ähnliche Gene auf, doch hinsichtlich ihres Charakters und ihrer Größe unterscheiden sich die beiden erheblich.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "mewtu")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Mewtu!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Mewtu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }

        public static void P151()
        {
            Global.iRounds = Global.iRounds + 1.00;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Typ:             Psycho");
            Console.WriteLine("Stufe:           Basis");
            Console.WriteLine("Pokédex-Eintrag: Wenn man seine Haut mithilfe eines Mikroskops betrachtet, so erkennt man ein Fell aus vielen feinen und kurzen Härchen.");

            Console.WriteLine("");
            Console.WriteLine("Lösung: ");

            string sUserAnswer = Console.ReadLine().ToLower();
            if (sUserAnswer == "mew")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Richtig. Es ist Mew!");
                Global.iScore = Global.iScore + 1.00;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Deine Antwort ist leider falsch.\nDie richtige Antwort wäre gewesen: Mew");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╚ Deine bisherige Punktzahl ist: " + Global.iScore + "                                                                                       ╗");
                Console.WriteLine("╚                                                                                                                                            ╗");
                Console.WriteLine("╚ Würfeln (w)                                                                                                                                ╗");
                Console.WriteLine("╚ Beenden (e)                                                                                                                                ╗");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ResetColor();
            }

            string sUserAction = Console.ReadLine().ToLower();
            if (sUserAction == "w")
            {
                Entries.RandomEntry();
            }
            else if (sUserAction == "e")
            {
                TrainerStatus();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Spiel wird beendet.");
            }
        }


        // Zufallsgenerator
        public static void RandomEntry()
        {
            switch (rand.Next(1, 151))
            {
                case 1:
                    P001();
                    break;
                case 2:
                    P002();
                    break;
                case 3:
                    P003();
                    break;
                case 4:
                    P004();
                    break;
                case 5:
                    P005();
                    break;
                case 6:
                    P006();
                    break;
                case 7:
                    P007();
                    break;
                case 8:
                    P008();
                    break;
                case 9:
                    P009();
                    break;
                case 10:
                    P010();
                    break;
                case 11:
                    P011();
                    break;
                case 12:
                    P012();
                    break;
                case 13:
                    P013();
                    break;
                case 14:
                    P014();
                    break;
                case 15:
                    P015();
                    break;
                case 16:
                    P016();
                    break;
                case 17:
                    P017();
                    break;
                case 18:
                    P018();
                    break;
                case 19:
                    P019();
                    break;
                case 20:
                    P020();
                    break;
                case 21:
                    P021();
                    break;
                case 22:
                    P022();
                    break;
                case 23:
                    P023();
                    break;
                case 24:
                    P024();
                    break;
                case 25:
                    P025();
                    break;
                case 26:
                    P026();
                    break;
                case 27:
                    P027();
                    break;
                case 28:
                    P028();
                    break;
                case 29:
                    P029();
                    break;
                case 30:
                    P030();
                    break;
                case 31:
                    P031();
                    break;
                case 32:
                    P032();
                    break;
                case 33:
                    P033();
                    break;
                case 34:
                    P034();
                    break;
                case 35:
                    P035();
                    break;
                case 36:
                    P036();
                    break;
                case 37:
                    P037();
                    break;
                case 38:
                    P038();
                    break;
                case 39:
                    P039();
                    break;
                case 40:
                    P040();
                    break;
                case 41:
                    P041();
                    break;
                case 42:
                    P042();
                    break;
                case 43:
                    P043();
                    break;
                case 44:
                    P044();
                    break;
                case 45:
                    P045();
                    break;
                case 46:
                    P046();
                    break;
                case 47:
                    P047();
                    break;
                case 48:
                    P048();
                    break;
                case 49:
                    P049();
                    break;
                case 50:
                    P050();
                    break;
                case 51:
                    P051();
                    break;
                case 52:
                    P052();
                    break;
                case 53:
                    P053();
                    break;
                case 54:
                    P054();
                    break;
                case 55:
                    P055();
                    break;
                case 56:
                    P056();
                    break;
                case 57:
                    P057();
                    break;
                case 58:
                    P058();
                    break;
                case 59:
                    P059();
                    break;
                case 60:
                    P060();
                    break;
                case 61:
                    P061();
                    break;
                case 62:
                    P062();
                    break;
                case 63:
                    P063();
                    break;
                case 64:
                    P064();
                    break;
                case 65:
                    P065();
                    break;
                case 66:
                    P066();
                    break;
                case 67:
                    P067();
                    break;
                case 68:
                    P068();
                    break;
                case 69:
                    P069();
                    break;
                case 70:
                    P070();
                    break;
                case 71:
                    P071();
                    break;
                case 72:
                    P072();
                    break;
                case 73:
                    P073();
                    break;
                case 74:
                    P074();
                    break;
                case 75:
                    P075();
                    break;
                case 76:
                    P076();
                    break;
                case 77:
                    P077();
                    break;
                case 78:
                    P078();
                    break;
                case 79:
                    P079();
                    break;
                case 80:
                    P080();
                    break;
                case 81:
                    P081();
                    break;
                case 82:
                    P082();
                    break;
                case 83:
                    P083();
                    break;
                case 84:
                    P084();
                    break;
                case 85:
                    P085();
                    break;
                case 86:
                    P086();
                    break;
                case 87:
                    P087();
                    break;
                case 88:
                    P088();
                    break;
                case 89:
                    P089();
                    break;
                case 90:
                    P090();
                    break;
                case 91:
                    P091();
                    break;
                case 92:
                    P092();
                    break;
                case 93:
                    P093();
                    break;
                case 94:
                    P094();
                    break;
                case 95:
                    P095();
                    break;
                case 96:
                    P096();
                    break;
                case 97:
                    P097();
                    break;
                case 98:
                    P098();
                    break;
                case 99:
                    P099();
                    break;
                case 100:
                    P100();
                    break;
                case 101:
                    P101();
                    break;
                case 102:
                    P102();
                    break;
                case 103:
                    P102();
                    break;
                case 104:
                    P104();
                    break;
                case 105:
                    P105();
                    break;
                case 106:
                    P106();
                    break;
                case 107:
                    P107();
                    break;
                case 108:
                    P108();
                    break;
                case 109:
                    P109();
                    break;
                case 110:
                    P110();
                    break;
                case 111:
                    P111();
                    break;
                case 112:
                    P112();
                    break;
                case 113:
                    P113();
                    break;
                case 114:
                    P114();
                    break;
                case 115:
                    P115();
                    break;
                case 116:
                    P116();
                    break;
                case 117:
                    P117();
                    break;
                case 118:
                    P118();
                    break;
                case 119:
                    P119();
                    break;
                case 120:
                    P120();
                    break;
                case 121:
                    P121();
                    break;
                case 122:
                    P122();
                    break;
                case 123:
                    P123();
                    break;
                case 124:
                    P124();
                    break;
                case 125:
                    P125();
                    break;
                case 126:
                    P126();
                    break;
                case 127:
                    P127();
                    break;
                case 128:
                    P128();
                    break;
                case 129:
                    P129();
                    break;
                case 130:
                    P130();
                    break;
                case 131:
                    P131();
                    break;
                case 132:
                    P122();
                    break;
                case 133:
                    P132();
                    break;
                case 134:
                    P134();
                    break;
                case 135:
                    P135();
                    break;
                case 136:
                    P136();
                    break;
                case 137:
                    P137();
                    break;
                case 138:
                    P138();
                    break;
                case 139:
                    P139();
                    break;
                case 140:
                    P140();
                    break;
                case 141:
                    P141();
                    break;
                case 142:
                    P142();
                    break;
                case 143:
                    P142();
                    break;
                case 144:
                    P144();
                    break;
                case 145:
                    P145();
                    break;
                case 146:
                    P146();
                    break;
                case 147:
                    P147();
                    break;
                case 148:
                    P148();
                    break;
                case 149:
                    P149();
                    break;
                case 150:
                    P150();
                    break;
                case 151:
                    P151();
                    break;
            }
        }

        public static void TrainerStatus()
        {
            Console.Clear();
            double iEndScore = Global.iScore / Global.iRounds;
            // Console.WriteLine("Deine Endpunktzahl betragt " + Global.iScore);
            // Console.WriteLine("Deine Endpunktzahl betragt " + Global.iRounds);
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
            Console.WriteLine("Professor Eich hat aufgrund der Anzahl deiner gespielten Rundne und deiner Punktzahl einen Trainerwert von " + iEndScore + " ermittelt.");

            // TRAINERSTATUS AUSGEBEN
            switch (iEndScore)
            {
                case >= 0.9:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Du bist unsere Nummer (00)1, ein wahrlich begabter Pokémon-Trainer!");
                    Console.ResetColor();
                    break;
                case > 0.7:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("");
                    Console.WriteLine("Dein Pokémon-Wissen ist herausragend!");
                    Console.ResetColor();
                    break;
                case > 0.5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Dein Pokémon-Wissen ist beeindruckend! Gehe weiter mit deinem Pokémon auf Reise, um dein Wissen stetig zu erweitern.");
                    Console.ResetColor();
                    break;
                case > 0.3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("Du hast dich gut auf den Beginn deiner Pokémon-Reise vorbereitet! Lerne fleißig weiter, damit du es bald zum Pokémon-Meister schaffst.");
                    Console.ResetColor();
                    break;
                case >= 0.1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Dein Pokémon-Wissen ist so scharf, wie Relaxo sportlich ist. Nimm dir deinen Pokédex zur Hand und lerne mehr über die Pokémon, die diese Welt bewohnen.");
                    Console.ResetColor();
                    break;
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("");
                    Console.WriteLine("Lege los und spiel Pokémon, damit du ein fundiertes Wissen als Pokemon-Trainer aufbauen kannst!");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Fehler in der Berechnung");
                    break;
            }
        }
    }
}
