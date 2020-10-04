using System;
using System.Collections.Generic;
using System.Text;

namespace Asthma_Calc
{
    class Calculator
    {
        int medicine;
        int portion;
        List<int> totalportion = new List<int>();
        List<int> usedportion = new List<int>();
        public void Medicine()
        {      
            var strPath = @"Medicine.csv";

            Console.WriteLine("Kumpaa astmalääkettä käytit?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1. Ventoline");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2. Flixotide");
            medicine = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Kuinka monta annosta otit?");
            Console.WriteLine("1");
            Console.WriteLine("2");
            portion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            CSV.ReadingCSV(totalportion, usedportion, strPath);
        
            if (medicine == 1)
            {
                if (portion == 1)
                {
                    usedportion[0] = usedportion[0] + 1;
                    int unused = totalportion[0] - usedportion[0];
                    Console.WriteLine($"Ventolinea on jäljellä {unused} annosta");
                        
                }

                else if (portion == 2)
                {
                    usedportion[0] = usedportion[0] + 2;
                    int unused = totalportion[0] - usedportion[0];
                    Console.WriteLine($"Ventolinea on jäljellä {unused} annosta");
                }

                else
                    Console.WriteLine("Painoit väärää nappia, pässi");
            }

            else if (medicine == 2)
            {
                if (portion == 1)
                {
                    usedportion[0] = usedportion[0] + 1;
                    int unused = totalportion[1] - usedportion[1];
                    Console.WriteLine($"Ventolinea on jäljellä {unused} annosta");

                }

                else if (portion == 2)
                {
                    usedportion[1] = usedportion[1] + 2;
                    int unused = totalportion[1] - usedportion[1];
                    Console.WriteLine($"Ventolinea on jäljellä {unused} annosta");
                }

                else
                    Console.WriteLine("Painoit väärää nappia, pässi");
            }

            else
                Console.WriteLine("Painoit väärää nappia, pässi");

            CSV.WritingCSV(totalportion, usedportion, strPath);
        }
    }
}
