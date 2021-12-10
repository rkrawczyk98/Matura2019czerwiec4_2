using System;
using System.Collections.Generic;
using System.IO;

namespace Matura2019czerwiec4_2
{

    class Program
    {
        static bool czyPierwsza(int liczba)
        {
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static String[][] readFile()
    {
        List<String[]> list = new List<String[]>();
        using (StreamReader reader = new StreamReader("pierwsze_przyklad.txt"))
        {
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(';');
                list.Add(values);
            }
        }
        return list.ToArray();
    }
        static void Main(string[] args)
        {
            String[][] dane = readFile();
            using (StreamWriter writer = new StreamWriter("wyniki4_2.txt")) 
            { 
                int[] wartosci = new int [dane.Length];

                for (int i = 0; i < dane.Length; i++)
                {
                    String[] wiersz = dane[i];
                    String liczba = wiersz[0];
                    int dlugoscWiersza = liczba.Length;


                    String odwrocona = null;
                    Char[] wartosc = new Char[dlugoscWiersza];

                    for (int j = 0; j < dlugoscWiersza; j++)
                    {
                        wartosc[j] = liczba[j];
                    }

                    do
                    {
                        odwrocona += wartosc[dlugoscWiersza - 1];
                        dlugoscWiersza--;
                    } while (dlugoscWiersza > 0);

                    int wynik = Int32.Parse(odwrocona);

                    if (czyPierwsza(wynik))
                    {
                        Console.WriteLine(wartosc);
                        writer.WriteLine(wartosc);
                    }
                }
                }
        }
    }
}
