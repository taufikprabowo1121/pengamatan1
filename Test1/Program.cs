using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            string alamat;
            int umur;
            string golongan;

            Console.Write("Masukan nama : ");
            nama = Console.ReadLine();
            Console.Write("Masukan Alamat : ");
            alamat = Console.ReadLine();
            Console.Write("Masukan Umur : ");
            umur = int.Parse(Console.ReadLine());
            Console.Write("Masukan Golongan Darah : ");
            golongan = Console.ReadLine();


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nama Anda: " + nama);
            Console.WriteLine("Alamat Anda: " + alamat);
            Console.WriteLine("Umur Anda: " + umur);
            Console.WriteLine("Golongan Darah: " + golongan);
            Console.WriteLine("-------------------------------");

            Console.ReadKey();
        }
    }
}
