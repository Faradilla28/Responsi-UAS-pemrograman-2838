using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

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
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
			Console.WriteLine("Pilih Menu Aplikasi\n");
			Console.WriteLine("1. Tambah Mahasiswa");
			Console.WriteLine("2. Hapus Mahasiswa");
			Console.WriteLine("3. Tampilkan Mahasiswa");
			Console.WriteLine("4. Keluar")
            
        }

        static void TambahMahasiswa()
        {
       mahasiswa mahasiswa= new mahasiswa();
      Console.WriteLine("Tambah Mahasiswa \n");
      Console.Write("NIM : ");
      mahasiswa.NIM = Console.ReadLine();
      Console.Write("Nama  : ");
      mahasiswa.Nama = Console.ReadLine();
      Console.Write("Jenis Kelamin [L/P] : ");
      string jenis kelamin = (Console.ReadLine());
	  mahasiswa.Jeniskelamin = (jeniskelamin== "L" || jeniskelamin == "P") 
      Console.Write("IPK  : ");
      mahasiswa.IPK = double.Parse(Console.ReadLine());
      daftarProduk.Add(produk);

			
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            int nomor = -1, hapus = -1;
            Console.WriteLine();
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            string nimMahasiswa = Console.ReadLine();
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                nomor++;
                if (mahasiswa.Nim == nimMahasiswa)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine(" Data Mahasiswa Berhasil Dihapus ");
            }
            else
            {
                Console.WriteLine("\nNIM Tidak Ditemukan ");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

             int urutan = 0;
      Console.WriteLine("Data Mahasiswa\n");
      foreach (Mahasiswa in daftarMahasiswa)
      {
        urutan++;
        Console.WriteLine("{0}. NIM  : {1} \n   Nama Mahasiswa  : {2} \n   jenis kelamin   : {3} \n   IPK   : {4}", urutan, Mahasiswa.NIM, Mahasiswa.Nama, Mahasiswa.kelamin, Mahasiswa.IPK);
      }
      if (urutan<1)
      {
        Console.WriteLine("\nData Mahasiswa \n");
      }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
