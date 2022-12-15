//Hidayat Hatta Irsyad (2207111397)
using System;

namespace DendaUts3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lamaPeminjaman;
            int totalDenda;
            int lamaPeminjaman1;
            int lamaPeminjaman2;
            int totalDenda1;
            int totalDenda2;
            int lamaPeminjaman3;
            int freeDenda = 0;
            Console.Write("Input jumlah hari peminjaman : ");
            lamaPeminjaman = Convert.ToInt32(Console.ReadLine());

            //Sistem aritmatika 1
            lamaPeminjaman1 = lamaPeminjaman - 5;
            totalDenda = 10000;
            //Sistem aritmatika 2
            lamaPeminjaman2 = lamaPeminjaman - 10;
            totalDenda1 = 20000;
            //Total denda selama 5 hari
            int totalDenda5Hari = 50000;
            int denda2 = totalDenda1 * lamaPeminjaman2;
            denda2 = denda2 + totalDenda5Hari;
            //Sistem aritmatika 3
            lamaPeminjaman3 = lamaPeminjaman - 30;
            totalDenda2 = 30000;
            //Total denda selama 30 hari
            int totalDenda30Hari = 400000;
            int denda3 = totalDenda2 * lamaPeminjaman3;
            denda3 = denda3 + totalDenda5Hari + totalDenda30Hari;

            if (lamaPeminjaman <= 5)
            {
                Console.Write("Total denda : Rp." + freeDenda);
            }
            else if (lamaPeminjaman > 5 && lamaPeminjaman <= 10)
            {
                Console.Write("Total denda : Rp." + totalDenda * lamaPeminjaman1);
            }
            else if (lamaPeminjaman > 10 && lamaPeminjaman <= 30)
            {
                Console.Write("Total denda : Rp." + denda2);
            }
            else
            {
                Console.WriteLine("Keanggotaan anda dibatalkan");
                Console.Write("Total denda : Rp." + denda3);
            }
        }
    }
}