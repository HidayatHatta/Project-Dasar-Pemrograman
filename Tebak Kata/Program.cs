//Hidayat Hatta Irsyad (2207111397)
using System;
using System.Collections.Generic;

namespace PermainanKata
{
    class Program
    {
        static string kataRahasia = "naruto";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string> { };


        static void Main(string[] args)
        {
            Intro();
            MulaiMain();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat Datang, Hari Ini Kita Akan Bermain Tebak Kata...");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kali kesempatan untuk menebak kata misteri ini.");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama film animasi.");
            Console.WriteLine($"Kata ini terdiri dari {kataRahasia.Length} karakter.");
            Console.WriteLine("Film apakah yang dimaksud?");
        }

        static void MulaiMain()
        {
            while (kesempatan > 0)
            {
                Console.Write("Apa karakter tebakanmu?(a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);

                if (cekJawaban(kataRahasia, tebakanPemain))
                {
                    Console.WriteLine("Selamat anda menang");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataRahasia}");
                    break;
                }
                else if (kataRahasia.Contains(input))
                {
                    Console.WriteLine("Tebakan anda benar");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    Console.WriteLine(cekHuruf(kataRahasia, tebakanPemain));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Maaf tidak ada huruf tersebut di dalam kata misteri");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                    Console.WriteLine();
                }


                if (kesempatan == 0)
                {
                    Console.WriteLine("Mohon maaf kesempatan anda habis.");
                    Console.WriteLine($"Kata misteri yang dimaksud adalah {kataRahasia}.");
                    Console.WriteLine("Terimakasih sudah bermain...");
                    break;
                }
            }
        }

        static bool cekJawaban(string kataRahasia, List<string> tebakan)
        {
            bool status = false;

            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if (tebakan.Contains(c))
                {
                    status = true;
                }
                else
                {
                    return status = false;
                }
            }

            return status;
        }

        static string cekHuruf(string kataRahasia, List<string> tebakan)
        {
            string x = "";

            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if (tebakan.Contains(c))
                {
                    x = x + c;
                }
                else
                {
                    x = x + "_";
                }
            }

            return x;
        }

    }
}