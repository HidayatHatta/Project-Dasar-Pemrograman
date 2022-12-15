//Hidayat Hatta Irsyad  (2207111397)
using System;

namespace NameTagUts1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            double nim;
            string konsentrasi;

            Console.WriteLine("Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Nim : ");
            nim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Konsentrasi : ");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|**********************|");
            Console.WriteLine("{0,-4}{1,17}", "|Nama: ", nama + "|");
            Console.WriteLine("{0,-12}{1,12}", "|", nim + "|");
            Console.WriteLine("|----------------------|");
            Console.WriteLine("{0,-12}{1,12}", "|", konsentrasi + "|");
            Console.WriteLine("|**********************|");
        }
    }
}
