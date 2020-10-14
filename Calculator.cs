using System;
using System.Collections.Generic;
using System.Text;

namespace Asthma_Calc
{
    class Calculator
    {
        int exit = 0;

        List<int> totalportion = new List<int>();
        List<int> usedportion = new List<int>();
        public void Medicine()
        {
            var strPath = @"Medicine.csv";

            CSV.ReadingCSV(totalportion, usedportion, strPath);
            Console.WriteLine("Lunan astmalääkelaskuri\n");

            /* int unusedvl = totalportion[1] - usedportion[1];
             int unusedfx = totalportion[0] - usedportion[0];

             if (usedportion[0] >= 10)
             {
                 Console.ForegroundColor = ConsoleColor.DarkYellow;
                 Console.WriteLine($"Huom! Flixotidea on jäljellä enää {unusedfx} annosta!");
             }

             if (usedportion[1] >= 10)
             {
                 Console.ForegroundColor = ConsoleColor.DarkCyan;
                 Console.WriteLine($"Huom! Ventolinea on jäljellä enää {unusedvl} annosta!\n");
             }
             Console.ResetColor();*/

            do
            {
                int choice = MenuAndError.Menu();

                switch (choice)
                {
                    case 1:
                        int unusedvl = totalportion[1] - usedportion[1];
                        int unusedfx = totalportion[0] - usedportion[0];
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"Flixotidea on jäljellä {unusedfx} annosta,");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"Ventolinea on jäljellä {unusedvl} annosta\n\n");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.WriteLine("Kumpaa astmalääkettä käytit?\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("1. Flixotide");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("2. Ventoline");
                        Console.ResetColor();
                        int medicine = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Kuinka monta annosta otit?\n");
                        Console.WriteLine("1");
                        Console.WriteLine("2");
                        int portion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (medicine == 1)
                        {
                            if (portion == 1)
                            {
                                usedportion[0] = usedportion[0] + 1;
                                int unused = totalportion[0] - usedportion[0];
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"Flixotidea on jäljellä {unused} annosta\n");
                                Console.ResetColor();

                            }

                            else if (portion == 2)
                            {
                                usedportion[0] = usedportion[0] + 2;
                                int unused = totalportion[0] - usedportion[0];
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"Flixotidea on jäljellä {unused} annosta\n");
                                Console.ResetColor();
                            }

                            else
                                MenuAndError.PrintError();
                        }

                        else if (medicine == 2)
                        {
                            if (portion == 1)
                            {
                                usedportion[1] = usedportion[1] + 1;
                                int unused = totalportion[1] - usedportion[1];
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"Ventolinea on jäljellä {unused} annosta\n");
                                Console.ResetColor();

                            }

                            else if (portion == 2)
                            {
                                usedportion[1] = usedportion[1] + 2;
                                int unused = totalportion[1] - usedportion[1];
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"Ventolinea on jäljellä {unused} annosta\n");
                                Console.ResetColor();
                            }

                            else
                            {
                                MenuAndError.PrintError();
                            }
                        }

                        else
                        {
                            MenuAndError.PrintError();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Kumman lääkkeen haluat resetoida?\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("1. Flixotide");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("2. Ventoline");
                        Console.ResetColor();
                        int reset = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (reset == 1)
                        {
                            usedportion[0] = 0;
                        }

                        else
                        {
                            usedportion[1] = 0;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ohjelma loppuu. Mene pois");
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("Väärä valinta, yritä uudelleen");
                        break;
                }
            }
            while (exit == 0);
            CSV.WritingCSV(totalportion, usedportion, strPath);
        }
    }
}
