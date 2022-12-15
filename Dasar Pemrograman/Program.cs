//Hidayat Hatta Irsyad (2207111397)
using System;

namespace DasarPemrograman
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            int kesempatan = 3;
            //Invoke Function/Method
            Intro();
            //bool bGameSelesai = PlayGame();
            while (kesempatan > 0)
            {
                PlayGame();
                kesempatan = kesempatan - 1;
            }
        }

        static void Intro()
        {
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        }

        static void PlayGame()
        {
            //Deklarasi variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            int hasilTambah;
            int hasilKali;

            //BUat Random Number Generator (RNG)
            Random rng = new Random();

            //Inisialisasi Variabel
            kodeA = rng.Next(1, 3);
            kodeB = rng.Next(1, 3);
            kodeC = rng.Next(1, 3);
            jumlahKode = 3;

            //Operasi Aritmatika
            hasilTambah = kodeA + kodeB + kodeC;
            hasilKali = kodeA * kodeB * kodeC;

            //Intro
            Console.WriteLine("- Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("- Jika ditambahkan hasilnya = " + hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya = " + hasilKali);

            //Input User
            Console.Write("Masukkan Kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode 3 : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan anda : " + tebakanA + " " + tebakanB + " " + tebakanC + " Ya/Tidak ");

            //Konfirmasi
            string Konfirmasi = Console.ReadLine();
            if (Konfirmasi == "ya")
            {
                //Logic
                if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
                {
                    Console.WriteLine("Tebakan anda benar!!!");
                    //Return True;
                }
                else
                {
                    Console.WriteLine("Tebakan anda salah!!!");
                    Console.WriteLine("Kode yang benar adalah " + kodeA + " " + kodeB + " " + kodeC);
                    //Return False
                }
            }
            else
            {
                //PlayGame();
            }

        }
    }
}