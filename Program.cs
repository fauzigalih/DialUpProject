﻿using System;

namespace Dial_Up_Project
{
    class Program
    {
        public Program()
        {
            Main();
        }
        static void Main()
        {
            Console.WriteLine("Selamat Datang, silakan pilih menu untuk menggunakan Dial Up");
            Console.WriteLine("1. Telkomsel");
            Console.WriteLine("2. Indosat");
            Console.WriteLine("3. Keluar");

            SelectMenuFirst();
        }

        private static void SelectMenuFirst()
        {
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    new Telkomsel();
                    break;
                case "2":
                    Console.Clear();
                    new Indosat();
                    break;
                case "3":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Program.Main();
                    break;
            }
        }
    }
}
