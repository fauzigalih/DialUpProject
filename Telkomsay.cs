using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dial_Up_Project
{
    class Telkomsay
    {
        static int pulsa = 15000;
        static int pulsaUsed = 0;
        static string date = DateTime.Now.AddDays(7).ToShortDateString();
        static List<Paket> pakets = new List<Paket>();
        static int paketTelkomsayID = new Paket().paketTelkomsayID;
        public delegate void Referrer(int menu);

        public static void Home()
        {
            Console.WriteLine("Selamat Datang di Layanan Telkomsay \n" +
                "Silakan melakukan dial up seperti *888# dan lainnya \n" +
                "99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "99":
                    Console.Clear();
                    new Program();
                    break;
                case "*888#":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Home();
                    break;
            }
        }
        private static void Dial_888()
        {
            Console.WriteLine(
                "1. Ketengan YouTube \n" +
                "2. Ketengan Instagram \n" +
                "3. Ketengan Facebook \n" +
                "4. Ketengan Utama \n" +
                "5. Cek Pulsa dan Kuota \n" +
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
                case "4":
                    Console.Clear();
                    Menu_4();
                    break;
                case "5":
                    Console.Clear();
                    Menu_5();
                    break;
                case "99":
                    Console.Clear();
                    Home();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Dial_888();
                    break;
            }
        }

        public static void Menu_1()
        {
            int menu = 1;
            string paket = "YouTube";
            Console.WriteLine("Kuota Ketengan {0} \n" +
                "1. 1GB/1hr, 2rb \n" +
                "2. 1GB/3hr, 3rb \n" +
                "3. 3GB/1hr, 5rb \n" +
                "4. 3GB/3hr, 7rb \n" +
                "5. 3GB/7hr, 10rb \n" +
                "99. Kembali", paket);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 2000);
                    break;
                case "2":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 3000, 2);
                    break;
                case "3":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 5000);
                    break;
                case "4":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 7000, 2);
                    break;
                case "5":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 10000, 6);
                    break;
                case "99":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_1();
                    break;
            }
        }

        public static void Menu_2()
        {
            int menu = 2;
            string paket = "Instagram";
            Console.WriteLine("Kuota Ketengan {0} \n" +
                "1. 1GB/1hr, 2rb \n" +
                "2. 1GB/3hr, 3rb \n" +
                "3. 3GB/1hr, 5rb \n" +
                "4. 3GB/3hr, 7rb \n" +
                "5. 3GB/7hr, 10rb \n" +
                "99. Kembali", paket);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 2000);
                    break;
                case "2":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 3000, 2);
                    break;
                case "3":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 5000);
                    break;
                case "4":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 7000, 2);
                    break;
                case "5":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 10000, 6);
                    break;
                case "99":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_2();
                    break;
            }
        }

        public static void Menu_3()
        {
            int menu = 3;
            string paket = "Facebook";
            Console.WriteLine("Kuota Ketengan {0}\n" +
                "1. 1GB/1hr, 2rb \n" +
                "2. 1GB/3hr, 3rb \n" +
                "3. 3GB/1hr, 5rb \n" +
                "4. 3GB/3hr, 7rb \n" +
                "5. 3GB/7hr, 10rb \n" +
                "99. Kembali", paket);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 2000);
                    break;
                case "2":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 3000, 2);
                    break;
                case "3":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 5000);
                    break;
                case "4":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 7000, 2);
                    break;
                case "5":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 10000, 6);
                    break;
                case "99":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_3();
                    break;
            }
        }

        public static void Menu_4()
        {
            int menu = 4;
            string paket = "Utama";
            Console.WriteLine("Kuota Ketengan {0} \n" +
                "1. 1GB/1hr, 3rb \n" +
                "2. 2GB/3hr, 5rb \n" +
                "3. 5GB/1hr, 8rb \n" +
                "4. 5GB/3hr, 12rb \n" +
                "5. 10GB/7hr, 20rb \n" +
                "99. Kembali", paket);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 2000);
                    break;
                case "2":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 1, 3000, 2);
                    break;
                case "3":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 5000);
                    break;
                case "4":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 7000, 2);
                    break;
                case "5":
                    Console.Clear();
                    ConfirmPaket(menu, paket, 3, 10000, 6);
                    break;
                case "99":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_4();
                    break;
            }
        }

        private static void Menu_5()
        {
            Console.WriteLine($"Sisa Pulsa Rp.{pulsa}. \n" +
                $"Penggunaan pulsa Rp.{pulsaUsed}. Aktif sd {date}. \n" +
                $"1. Cek Nomer \n" +
                $"2. Cek Kuota \n" +
                $"99. Kembali");
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
                    CheckKuota();
                    break;
                case "99":
                    Console.Clear();
                    Dial_888();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    Menu_5();
                    break;
            }
        }

        private static void ReffMenu(int menu)
        {
            string str = "Menu_" + menu;
            Type type = typeof(Telkomsay);
            MethodInfo myMethod = type.GetMethod(str);
            Telkomsay tel = new Telkomsay();
            myMethod.Invoke(tel, null);
        }

        private static void ConfirmPaket(int menu, string paket, int giga, int price, int duration = 0)
        {
            Console.WriteLine("Anda akan membeli Paket {0} {1}GB/{2}hari \n" +
                "dengan harga Rp.{3}? \n" +
                "1. Beli \n" +
                "99. Kembali", paket, giga, duration+1, price);
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Paket(paket, giga, price, duration);
                    break;
                case "99":
                    Console.Clear();
                    Referrer referrer = ReffMenu;
                    referrer(menu);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    ConfirmPaket(menu, paket, giga, price, duration);
                    break;
            }
        }

        private static void Paket(string paket, int giga, int price, int duration = 0)
        {
            if (pulsa <= price) Console.WriteLine("Pulsa kamu tidak cukup untuk membeli paket ini. \n");
            else
            {
                pulsa -= price;
                pulsaUsed += price;
                pakets.Add(new Paket() { PaketID = paketTelkomsayID, PaketName = $"Kuota Ketengan {paket} {giga}GB", PaketDate = (DateTime.Now).AddDays(duration).ToShortDateString() });
                Console.WriteLine("Paket anda telah di proses. \n");
            }
            Dial_888();
        }

        private static void CheckNumber()
        {
            string str = "Telkomsay";
            uint number = (uint)Convert.ToInt32(str.GetHashCode());
            Console.WriteLine($"Nomer kartu perdana anda adalah 081{number} dengan tarif prabayar aktif. \n" +
                $"99. Kembali");
            Console.Write("Jawab: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "99":
                    Console.Clear();
                    Menu_5();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                    Console.WriteLine();
                    CheckNumber();
                    break;
            }
        }

        private static void CheckKuota()
        {
            var checkKuota = from paket in pakets
                             where paket.PaketID == paketTelkomsayID
                             select paket;

            if (checkKuota.Count() == 0)
            {
                Console.WriteLine("Kamu tidak memiliki paket apapun");
                Console.WriteLine();
                Menu_5();
            }
            else
            {
                Console.WriteLine("Kamu memiliki paket berikut:");
                foreach (var i in checkKuota)
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
                        Menu_5();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Tidak ada menu tersedia yang kamu pilih");
                        Console.WriteLine();
                        CheckKuota();
                        break;
                }
            }
        }
    }
}
