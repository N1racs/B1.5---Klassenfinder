using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._5___Klassenfinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string askForName = "Wie heißt dein Charakter?";
            string values = "Wie sind die Werte von ";
            string wrongInput = "Deine Werte können nur zwischen 8 und 16 liegen!";
            int STR;
            int GES;
            int INT;
            int KON;
            string stärke = "Stärke: ";
            string geschicklichkeit = "Geschicklichkeit: ";
            string intelligenz = "Intelligenz: ";
            string konstitution = "Konstitution: ";
            string total = "Gesamtwertung: ";
            string average = "Durschnittswert: ";
            string classOutput = "Empfohlene Klasse: ";
            string krieger = "Krieger";
            string schurke = "Schurke";
            string magier = "Magier";
            string paladin = "Paladin";
            string star0 = "☆☆☆☆☆";
            string star1 = "★☆☆☆☆";
            string star2 = "★★☆☆☆";
            string star3 = "★★★☆☆";
            string star4 = "★★★★☆";
            string star5 = "★★★★★";



            Console.WriteLine(askForName);
            Console.Write("> ");

            string input = Console.ReadLine();
            Console.WriteLine(values + input + "?");

            Console.WriteLine(stärke);
            Console.Write("> ");

            while (true) 
            {
                STR = int.Parse(Console.ReadLine());

                if (STR > 16 || STR < 8)
                {
                    Console.WriteLine(wrongInput);
                    Console.Write("> ");
                }
                else
                {
                    break;
                }
             }

            Console.WriteLine(geschicklichkeit);
            Console.Write("> ");

            while (true)
            {
                GES = int.Parse(Console.ReadLine());

                if (GES > 16 || GES < 8)
                {
                    Console.WriteLine(wrongInput);
                    Console.Write("> ");

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(intelligenz);
            Console.Write("> ");

            while (true)
            {
                INT = int.Parse(Console.ReadLine());

                if (INT > 16 || INT < 8)
                {
                    Console.WriteLine(wrongInput);
                    Console.Write("> ");

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(konstitution);
            Console.Write("> ");

            while (true)
            {
                KON = int.Parse(Console.ReadLine());

                if (KON > 16 || KON < 8)
                {
                    Console.WriteLine(wrongInput);
                    Console.Write("> ");

                }
                else
                {
                    break;
                }
            }

            int totalValue = STR + GES + INT + KON;
            Console.WriteLine(total + totalValue);
            int totalAverage = (STR + GES + INT + KON) / 4;
            Console.WriteLine(average + totalAverage);

            while (true)

            if (STR > GES && STR > KON && STR > INT)
            {
                Console.WriteLine(classOutput + krieger);
                break;
            }
            else if (GES > STR && GES > KON && GES > INT)
            {
                Console.WriteLine(classOutput + schurke);
                break;
            }
            else if (KON > GES && KON > STR && KON > INT)
            {
                Console.WriteLine(classOutput + paladin);
                break;
            }
            else if (INT > GES && INT > KON && INT > STR)
            {
                Console.WriteLine(classOutput + magier);
                break;
            }

            while (true)

            if (totalValue > 60)
            {
                Console.WriteLine(star5);
                break;
            }
            else if (totalValue > 55)
            {
                Console.WriteLine(star4);
                    break;
            }
            else if (totalValue > 48)
            {
                Console.WriteLine(star3);
                    break;
            }
            else if (totalValue > 42)
            {
                Console.WriteLine(star2);
                    break;
            }
            else if (totalValue > 36)
            {
                Console.WriteLine(star1);
                    break;
            }
            else if (totalValue < 36)
            {
                Console.WriteLine(star0);
                    break;
            }

        }
    }
}
