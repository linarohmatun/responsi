using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        static Penjualan jual = new Penjualan();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            jual = new Penjualan();
            string TK;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.Write("Nota        : ");
            jual.Nota = Console.ReadLine();
            Console.Write("Tanggal     : ");
            jual.Tanggal = Console.ReadLine();
            Console.Write("Customer    : ");
            jual.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            TK = Console.ReadLine();
            if (TK == "T")
            {
                jual.Jenis = "Tunai";
            } else if (TK == "K")
            {
                jual.Jenis = "Kredit";
            }
            Console.Write("Total Nota  : ");
            jual.Total = Console.ReadLine();
            daftarPenjualan.Add(jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Penjualan");
            Console.WriteLine();
            foreach (Penjualan objJual in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", no, objJual.Nota, objJual.Tanggal, objJual.Customer, objJual.Jenis, objJual.Total);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
