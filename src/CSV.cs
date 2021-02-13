using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Asthma_Calc
{
    class CSV
    {
        public static void ReadingCSV(List<int> totalportion, List<int> usedportion, string strPath)
        {
            using (var filestream = new FileStream(strPath, FileMode.Open, FileAccess.Read))
            {
                using (var streamreader = new StreamReader(filestream))
                {
                    while (!streamreader.EndOfStream)
                    {
                        var line = streamreader.ReadLine();
                        var values = line.Split(';');

                        totalportion.Add(Convert.ToInt32(values[0]));
                        usedportion.Add(Convert.ToInt32(values[1]));
                    }
                }
            }
        }
        public static void WritingCSV(List<int> totalportion, List<int> usedportion, string strPath)
        {
            using (var filestream = new FileStream(strPath, FileMode.Open, FileAccess.Write))
            {
                using (var writer = new StreamWriter(filestream))
                {
                    for (int i = 0; i < totalportion.Count; i++)
                    {
                        var lineout = (Convert.ToString(totalportion[i]) + ";" + Convert.ToString(usedportion[i]));
                        writer.WriteLine(lineout, Encoding.UTF8);
                    }

                }
            }
        }
    }
}
