using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dial_Up_Project
{
    class Indosay
    {
        static int pulsa = 120000;
        static string date = (DateTime.Now).AddDays(6).ToShortDateString();
        static List<Paket> pakets = new List<Paket>();
        static int paketIndosayID = new Paket().paketIndosayID;
        
        public static void Home()
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
                    Home();
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
                    Home();
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
            string paket = "Freedom";
            Console.WriteLine("{0} Kuota Harian 1GB/hr (Rp2rb utk COVID-19)", paket);
            Console.WriteLine(
                "1. Mau \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Paket(paket, 1, 2000);
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
            int menu = 2;
            string paket = "Freedom";
            Console.WriteLine("{0} Kuota Bulanan", paket);
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
                    ConfirmPaket(menu, paket, 30, 100000, 29, true);
                    break;
                case "2":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 21, 75000, 29, true);
                    break;
                case "3":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 13, 50000, 29, true);
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

        private static void ReffMenu(int menu)
        {
            string str = "Menu_" + menu;
            Type type = typeof(Indosay);
            MethodInfo myMethod = type.GetMethod(str);
            Indosay ind = new Indosay();
            myMethod.Invoke(ind, null);
        }

        private static void ConfirmPaket(int menu, string paket, int giga, int price, int duration = 0, bool expand = false)
        {
            Console.WriteLine("Anda akan membeli Paket {0} Kuota {1}GB/{2}hari \n" +
                "dengan harga Rp.{3}? \n" +
                "1. Beli \n" +
                "99. Kembali", paket, giga, duration + 1, price);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Paket(paket, giga, price, duration, expand);
                    break;
                case "99":
                    Console.Clear();
                    ReffMenu(menu);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    ConfirmPaket(menu, paket, giga, price, duration, expand);
                    break;
            }
        }

        private static void Paket(string paket, int giga, int price, int duration = 0, bool expand = false)
        {
            if (pulsa <= price) Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
            else
            {
                pulsa -= price;
                if(expand) date = (DateTime.Now).AddDays(duration).ToShortDateString();
                pakets.Add(new Paket() { PaketID = paketIndosayID, PaketName = $"{paket} Kuota {giga}GB", PaketDate = (DateTime.Now).AddDays(duration).ToShortDateString() });
                Console.WriteLine("Paket anda telah di proses. \n");
            }
            Dial_123();
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
            var checkPaket = from paket in pakets
                             where paket.PaketID == paketIndosayID
                             select paket;

            if (checkPaket.Count() == 0)
            {
                Console.WriteLine("Kamu tidak memiliki paket apapun");
                Console.WriteLine();
                Menu_3();
            }
            else
            {
                Console.WriteLine("Kamu memiliki paket berikut:");
                foreach (var i in checkPaket)
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
}
