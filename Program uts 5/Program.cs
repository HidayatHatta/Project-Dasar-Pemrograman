//Hidayat Hatta Irsyad (2207111397)
using System;
using System.Threading;
namespace TicTacToe
{
    class Program
    {
        static char[] himpunan = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int pilihan;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X dan Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Turn");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn");
                }
                Console.WriteLine("\n");
                Board();
                pilihan = int.Parse(Console.ReadLine());
                if (himpunan[pilihan] != 'X' && himpunan[pilihan] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        himpunan[pilihan] = 'O';
                        player++;
                    }
                    else
                    {
                        himpunan[pilihan] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Maaf baris {0} sudah di isi oleh {1}", pilihan, himpunan[pilihan]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Tunggu selama 2 detik.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} menang", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Pembuatan kotak
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", himpunan[1], himpunan[2], himpunan[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", himpunan[4], himpunan[5], himpunan[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", himpunan[7], himpunan[8], himpunan[9]);
            Console.WriteLine("     |     |      ");
        }
        //Pengecekan player menang atau kalah
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Kondisi menang baris ke 1
            if (himpunan[1] == himpunan[2] && himpunan[2] == himpunan[3])
            {
                return 1;
            }
            //Kondisi menang baris ke 2
            else if (himpunan[4] == himpunan[5] && himpunan[5] == himpunan[6])
            {
                return 1;
            }
            //Kondisi menang baris ke 3
            else if (himpunan[6] == himpunan[7] && himpunan[7] == himpunan[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Kondisi menang kolom ke 1
            else if (himpunan[1] == himpunan[4] && himpunan[4] == himpunan[7])
            {
                return 1;
            }
            //Kondisi menang kolom ke 2
            else if (himpunan[2] == himpunan[5] && himpunan[5] == himpunan[8])
            {
                return 1;
            }
            //Kondisi menang kolom ke 3
            else if (himpunan[3] == himpunan[6] && himpunan[6] == himpunan[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (himpunan[1] == himpunan[5] && himpunan[5] == himpunan[9])
            {
                return 1;
            }
            else if (himpunan[3] == himpunan[5] && himpunan[5] == himpunan[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (himpunan[1] != '1' && himpunan[2] != '2' && himpunan[3] != '3' && himpunan[4] != '4' && himpunan[5] != '5' && himpunan[6] != '6' && himpunan[7] != '7' && himpunan[8] != '8' && himpunan[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}