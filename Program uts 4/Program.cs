//Hidayat Hatta Irsyad (2207111397)
using System;

namespace BatuGuntingKertas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool status;
            int menang = 0;
            int kalah = 0;
            int seri = 0;
            Console.WriteLine("Batu, Gunting, Kertas");

            status = true;
            while (status)
            {
                Console.Clear();
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit:");
                string playerChoice = Console.ReadLine();

                if (playerChoice == "e")
                {
                    break;
                }

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Komputer memilih batu");

                    switch (playerChoice)
                    {
                        case "b":
                            Console.WriteLine("Seri.");
                            seri++;
                            break;
                        case "k":
                            Console.WriteLine("Anda menang.");
                            menang++;
                            break;
                        case "g":
                            Console.WriteLine("Anda kalah.");
                            kalah++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Komputer memilih kertas.");

                    switch (playerChoice)
                    {
                        case "b":
                            Console.WriteLine("Anda kalah.");
                            kalah++;
                            break;
                        case "k":
                            Console.WriteLine("Seri.");
                            seri++;
                            break;
                        case "g":
                            Console.WriteLine("Anda menang.");
                            menang++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Komputer memilih gunting");

                    switch (playerChoice)
                    {
                        case "b":
                            Console.WriteLine("Anda menang.");
                            menang++;
                            break;
                        case "k":
                            Console.WriteLine("Anda kalah.");
                            kalah++;
                            break;
                        case "g":
                            Console.WriteLine("Seri.");
                            seri++;
                            break;
                    }
                }
                Console.WriteLine("Skor: " + menang + " menang, " + kalah + " kalah, " + seri + " seri");
                Console.WriteLine("Tekan Enter untuk melanjutkan permainan...");
                while(Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    status = true;
                }   

            }
        }
    }
}