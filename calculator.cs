using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percobaan1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih, a, b, hasrang, hasbah, hasli;
            double hasbag;
            Console.WriteLine(" ========  MENU ========"); // note : Fungsi WriteLine() akan menampilkan teks dalam satu baris atau baris baru
                                                           // sedangkan Write() tidak akan membuat baris baru.
            Console.WriteLine("1. PENAMBAHAN");
            Console.WriteLine("2. PENGURANGAN");
            Console.WriteLine("3. PERKALIAN");
            Console.WriteLine("4. PEMBAGIAN");
            Console.WriteLine("5. KELUAR");
            Console.WriteLine("=========================");
            Console.Write("Pilih Nomer 1 - 4 : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            switch(pilih)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("PENAMBAHAN");
                    Console.Write("Masukan Input Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Input Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    hasbah = a + b;
                    Console.WriteLine("Total " + a + " + "+ b + " = " + hasbah);
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk keluar");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("PENGURANGAN");
                    Console.Write("Masukan Input Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Input Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    hasrang = a - b;
                    Console.WriteLine("Total " + a + " - "+ b + " = " + hasrang);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("PERKALIAN");
                    Console.Write("Masukan Input Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Input Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    hasli = a * b;
                    Console.WriteLine("Total " + a + " x " + b + " = " + hasli);
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk keluar");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("PEMBAGIAN");
                    Console.Write("Masukan Input Nilai a : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Input Nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    hasbag = a / b;
                    Console.WriteLine("Total " + a + " : " + b + " = " + hasbag);
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk keluar");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("TERIMA KASIH");
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk keluar");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("MAAF INPUT SALAH");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
