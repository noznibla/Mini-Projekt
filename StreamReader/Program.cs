using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter_och_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läser in de 5 namn som finns i textfilen "Namn.txt"
            string[] LäsaNamn = new string[5];
            StreamReader SR = new StreamReader(@"Namn.txt");

            for(int i = 0; i < 5; i++)
            {
                LäsaNamn[i] = SR.ReadLine();
            }

            SR.Close();
            Console.WriteLine("Här är olika 5 namn från en textfil: ");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(LäsaNamn[i]);
            }


            //Skriver in 5 nya namn i en ny textfil vid namn "NyaNamn.txt"
            string[] SkrivaNamn = new string[5];
            Console.WriteLine(" ");
            Console.WriteLine("Skriv in 5 nya namn: ");

            for (int i = 0; i < 5; i++)
            {
                SkrivaNamn[i] = Console.ReadLine();
            }

            StreamWriter SW = new StreamWriter(@"NyaNamn.txt");

            for (int i = 0; i < 5; i++)
            {
                SW.WriteLine(SkrivaNamn[i]);
            }

            SW.Close();
        }
    }
}
