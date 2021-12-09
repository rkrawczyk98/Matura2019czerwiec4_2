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
            int dlugosc = dane.Length;

            for (int i = 0; i < dlugosc; i++)
            {
                String[] wiersz = dane[i];
                int dlugoscWiersza = wiersz.Length;
                String liczba = wiersz[0];

                String odwrocona = null;
                int[] wierszwart = new int[dlugoscWiersza];
                Console.WriteLine(dlugoscWiersza);
                
                for ( int j = 0; j <dlugoscWiersza; j++)
                    {
                        wierszwart[j] = Int32.Parse(liczba[j].ToString());
                    Console.WriteLine(wierszwart[j]);
                    }
                
                for ( int k = dlugoscWiersza; k == 2 ; k--)
                {
                    odwrocona = odwrocona + wierszwart[k];
                    Console.WriteLine(odwrocona);
                }

                int wynik = Int32.Parse(odwrocona.ToString());

                if (czyPierwsza(wynik))
                {
                    Console.WriteLine(wynik);
                }
            }
        }
    }
}
