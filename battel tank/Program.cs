//Hidayat Hatta Irsyad (2207111397)
using System;

namespace BattleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inisialiasai variabel yang dibutuhkan
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'x';
            char miss = '0';
            int jumlahTank = 3;

            char[,] area = buatRuang(panjangArea, rumput, tank, jumlahTank);

            printArea(area, rumput, tank);

            int jumlahTankTersembunyi = jumlahTank;

            //Gameplay
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakKoordinat, area, tank, rumput, hit, miss);
                if (updateTampilanArea == hit)
                {
                    jumlahTankTersembunyi--;
                }
                area = updateArea(area, tebakKoordinat, updateTampilanArea);
                printArea(area, rumput, tank);
            }
            Console.WriteLine("Game Over!!!");
        }

        private static char[,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char[panjangArea, panjangArea];

            for (int baris = 0; baris < panjangArea; baris++)
            {
                for (int kolom = 0; kolom < panjangArea; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }
            return letakkanTank(ruangan, jumlahTank, rumput, tank);
        }
        static char[,] letakkanTank(char[,] ruangan, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArea = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisi = ruangan[lokasiTank[0], lokasiTank[1]];

                if (posisi == rumput)
                {
                    ruangan[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        //Menentukan posisi kordinat tank (x,y)
        private static int[] tentukanKoordinatTank(int panjangArea)
        {
            Random rng = new Random();
            int[] kordinat = new int[2];
            for (int i = 0; i < kordinat.Length; i++)
            {
                kordinat[i] = rng.Next(panjangArea); // x = random (0,4) ; y = random(0,4)
            }
            return kordinat;
        }
        //Menampilkan area permainan ke console
        private static void printArea(char[,] area, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " "); // 1 2 3 4 5
            }
            Console.WriteLine();
            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " "); // 1 2 3 4 5
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = area[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    }
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Tebakan kordinat
        private static int[] getKoordinatTebakan(int panjangArea)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("Pilih baris : ");
                baris = Convert.ToInt32(Console.ReadLine());
            }
            while (baris < 0 || baris > panjangArea + 1);

            do
            {
                Console.Write("Pilih kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }
            while (kolom < 0 || kolom > panjangArea + 1);

            return new[] { baris - 1, kolom - 1 };
        }

        //Verifikasi tebakan pemain
        private static char verifikasiTebakan(int[] tebakKoordinat, char[,] area, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            char target = area[baris, kolom];

            if (target == tank)
            {
                pesan = "HIT!!!";
                target = hit;
            }
            else if (target == rumput)
            {
                pesan = "MISS!!!";
                target = miss;
            }
            else
            {
                pesan = "CLEAR!!!";
            }

            Console.Write(pesan);
            Console.WriteLine("----");
            return target;
        }

        private static char[,] updateArea(char[,] area, int[] tebakKoordinat, char updateTampilanArea)
        {
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            area[baris, kolom] = updateTampilanArea;
            return area;
        }
    }
}