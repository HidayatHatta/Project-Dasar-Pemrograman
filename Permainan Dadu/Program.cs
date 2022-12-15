//Hidayat Hatta Irsyad (2207111397) TI-A
using System;

namespace PermainanDadu
{
    class Permainan
    {
        //Main method
        static void Main(string[] args)
        {
            intro();
            playGame();
        }
        //Pemanggilan Intro
        static void intro()
        {
            Console.WriteLine("'PERMAINAN DADU'");
            Console.WriteLine("Pada game ini, anda dan komputer akan bermain 10 ronde!!!");
            Console.WriteLine("Setiap putaran dadu akan dilempar dan menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Tekan 'ENTER' untuk memainkan permainan");
            Console.WriteLine("Siapa yang akan menang...? selamat berjuang :)");
            Console.WriteLine();
        }
        //Pemanggilan playGame
        static void playGame()
        {
            //Deklarasi variabel
            int playerRandomNum;
            int komRandomNum;
            int playerPoints = 0;
            int komPoints = 0;
            int ronde = 0;

            //Membuat Random Number Generator (RNG)
            Random rng = new Random();

            for (int pengulanganRonde = 0; pengulanganRonde < 10; pengulanganRonde++)
            {
                pengulanganRonde = ronde++;
                Console.WriteLine("Ronde " + ronde + ".");

                Console.ReadKey();

                playerRandomNum = rng.Next(1, 7);
                Console.WriteLine("Kamu melempar dadu berjumlah = " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(350);

                komRandomNum = rng.Next(1, 7);
                Console.WriteLine("Komputer melempar dadu berjumlah = " + komRandomNum);

                //Logic Penentuan skor
                if (playerRandomNum > komRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Anda memenangkan ronde ke-" + ronde);
                }
                else if (playerRandomNum < komRandomNum)
                {
                    komPoints++;
                    Console.WriteLine("Komputer memenangkan ronde ke-" + ronde);
                }
                else
                {
                    Console.WriteLine("Ronde ke-" + ronde + " imbang");
                }

                Console.WriteLine("Skor sekarang = Anda : " + playerPoints + ". Komputer : " + komPoints + ".");
                Console.WriteLine();
            }

            //Logic hasil akhir
            if (playerPoints > komPoints)
            {
                Console.WriteLine("Selamat anda menang!!!");
            }
            else if (playerPoints < komPoints)
            {
                Console.WriteLine("Maaf anda kalah!!!");
            }
            else
            {
                Console.WriteLine("Skor imbang!!!");
            }

            Console.ReadKey();
        }
    }
}