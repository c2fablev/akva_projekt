using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace akva_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("elolenyek.txt");
            Dictionary<string, List<string>> elolenyek = new Dictionary<string, List<string>>();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                elolenyek[adatok[0]] = new List<string> { adatok[1], adatok[2], adatok[3], adatok[4], adatok[5]};
            }
            foreach (var kvp in elolenyek)
            {
                Console.Write($"{kvp.Key} adatai: ");
                foreach (var adat in kvp.Value)
                {
                    Console.Write($"{adat} ");
                }
                Console.WriteLine();
            }
        }
    }
}