//Hidayat Hatta Irsyad (2207111397)
using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rng = new Random();
            int angkaRahasia = rng.Next(0, 100);
            bool status = true;
            int tebakan = 0;
            int angkaTebakan;
            while (status)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                angkaTebakan = Convert.ToInt32(Console.ReadLine());
                tebakan += 1;
                if (angkaTebakan == angkaRahasia)
                {
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    break;
                }
                else if (angkaTebakan < angkaRahasia)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }
                else if (angkaTebakan > angkaRahasia)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }
                else{}
            }
        }
    }
}