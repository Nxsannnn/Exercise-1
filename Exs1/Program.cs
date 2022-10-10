using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1
{
    internal class Program
    {
        //Deklarasi array int dengan ukuran 63
        private int[] ichsan = new int[63];
        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        //Fungsi / method untuk menerima masukan
        public void read ()
        {
            //Menerima angka untuk menentukan banyaknya data yg disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya element pada Array:  ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 63)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 63 elemen.\n");
            }
            //pengguna memasukkan elemen pada array
            Console.WriteLine("");
            Console.WriteLine("----------------");
            Console.WriteLine("Masukkan element array");
            Console.WriteLine("----------------");
            for (int i= 0; i < n; i++)
            {
                Console.WriteLine("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                ichsan[i] = Int32.Parse(s1);
            }
        }
        public void display ()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("----------------");
            for (int IA = 0; IA < n; IA++)
            {
                Console.WriteLine(ichsan[IA]);
            }
            Console.WriteLine("");

        }
        public void BubbleSortArray()
        {
            for (int i = 0; i < n; i++)// for n-1 passes
            {
                // pada pass i , bandingkan n -i element pertama dengan selanjutnya
                for (int IA = 0; IA < n; IA++)
                {
                   
                    if (ichsan[IA] > ichsan[IA + 1])// jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = ichsan[IA];
                        ichsan[IA] = ichsan[IA + 1];
                        ichsan[IA + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //buat objek kelas bubbleshot 
            Program mylist = new Program();
            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            //pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();
            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            //keluar
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
