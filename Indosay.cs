using System;
using System.Collections.Generic;
using System.Linq;

namespace Dial_Up_Project
{
    class Indosay
    {
        public Indosay()
        {
            Home();
        }

        static int pulsa = 120000;
        static string date = (DateTime.Now).AddDays(6).ToShortDateString();
        static List<Paket> pakets = new List<Paket>();
        
        private static void Home()
        {
            Console.WriteLine("Selamat Datang di Layanan Indosay \nSilakan melakukan dial up seperti *123# dan lainnya");
            Console.WriteLine("99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "99":
                    Console.Clear();
                    new Program();
                    break;
                case "*123#":
                    Console.Clear();
                    Dial_123();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    new Indosay();
                    break;
            }
        }
        private static void Dial_123()
        {
            Console.WriteLine("Pulsa Rp. {0} s.d {1}", pulsa, date);
            Console.WriteLine(
                "1. NEW! Freedom Kuota Harian \n" +
                "2. Freedom Internet \n" +
                "3. Info \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Menu_1();
                    break;
                case "2":
                    Console.Clear();
                    Menu_2();
                    break;
                case "3":
                    Console.Clear();
                    Menu_3();
                    break;
                case "99":
                    Console.Clear();
                    new Indosay();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Dial_123();
                    break;
            }
        }

        private static void Menu_1()
        {
            Console.WriteLine("Freedom Kuota Harian 1GB/hr (Rp2rb utk COVID-19)");
            Console.WriteLine(
                "1. Mau \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    if(pulsa <= 2000)
                    {
                        Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
                    }
                    else
                    {
                        pulsa -= 2000;
                        pakets.Add(new Paket() { PaketID = 1, PaketName = "Freedom Kuota 1GB", PaketDate = (DateTime.Now).ToShortDateString() });
                        Console.WriteLine("Paket anda telah di proses. \n");
                    }
                    Dial_123();
                    break;
                case "99":
                    Console.Clear();
                    Dial_123();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_1();
                    break;
            }
        }

        private static void Menu_2()
        {
            Console.WriteLine("Freedom Kuota Bulanan");
            Console.WriteLine(
                "1. 30GB, 100rb \n" +
                "2. 21GB, 75rb \n" +
                "3. 13GB, 50rb \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    if(pulsa <= 100000)
                    {
                        Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
                    }
                    else
                    {
                        pulsa -= 100000;
                        date = (DateTime.Now).AddDays(29).ToShortDateString();
                        pakets.Add(new Paket() { PaketID = 2, PaketName = "Freedom Kuota 30GB", PaketDate = date });
                        Console.WriteLine("Paket anda telah di proses. \n");
                    }
                    Dial_123();
                    break;
                case "2":
                    Console.Clear();
                    if(pulsa <= 75000)
                    {
                        Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
                    }
                    else
                    {
                        pulsa -= 75000;
                        date = (DateTime.Now).AddDays(29).ToShortDateString();
                        pakets.Add(new Paket() { PaketID = 3, PaketName = "Freedom Kuota 21GB", PaketDate = date });
                        Console.WriteLine("Paket anda telah di proses. \n");
                    }
                    Dial_123();
                    break;
                case "3":
                    Console.Clear();
                    if(pulsa <= 50000)
                    {
                        Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
                    }
                    else
                    {
                        pulsa -= 50000;
                        date = (DateTime.Now).AddDays(29).ToShortDateString();
                        pakets.Add(new Paket() { PaketID = 4, PaketName = "Freedom Kuota 13GB", PaketDate = date });
                        Console.WriteLine("Paket anda telah di proses. \n");
                    }
                    Dial_123();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_2();
                    break;
            }
        }

        private static void Menu_3()
        {
            Console.WriteLine("Cek paketmu disini! \n" +
                "1. Cek Nomer \n" +
                "2. Cek Kuota \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    CheckNumber();
                    break;
                case "2":
                    Console.Clear();
                    CheckPaket();
                    break;
                case "99":
                    Console.Clear();
                    Dial_123();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_3();
                    break;
            }
        }

        private static void CheckNumber()
        {
            string str = "Indosay";
            uint number = (uint)Convert.ToInt32(str.GetHashCode());
            Console.WriteLine($"Nomer kartu perdana anda adalah 085{number} dengan tarif prabayar aktif. \n" +
                $"99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "99":
                    Console.Clear();
                    Menu_3();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    CheckNumber();
                    break;
            }
        }

        private static void CheckPaket()
        {
            Console.Clear();
            if (pakets.Count() == 0)
            {
                Console.WriteLine("Kamu tidak memiliki paket apapun");
                Console.WriteLine();
                Dial_123();
            }
            else
            {
                Console.WriteLine("Kamu memiliki paket berikut:");
                foreach (var i in pakets)
                {
                    Console.WriteLine($"- {i.PaketName} berlaku hingga {i.PaketDate}");
                }
                Console.WriteLine("99. Kembali");
                Console.Write("Jawab: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "99":
                        Console.Clear();
                        Menu_3();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                        Console.WriteLine();
                        CheckPaket();
                        break;
                }
            }
        }
    }

    class Paket
    {
        public int PaketID { get; set; }
        public string PaketName { get; set; }
        public string PaketDate { get; set; }
    }
}
