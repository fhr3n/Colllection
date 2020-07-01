using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            "Without CRUD"
            Karyawan_Harian karyawan1 = new Karyawan_Harian();
            Karyawan_Tetap karyawan2 = new Karyawan_Tetap();
            Sales karyawan3 = new Sales();

            karyawan1.nik = "19112876";
            karyawan1.nama = "Fahren Ridho Septiawan";
            karyawan1.upahPerJam = 40000;
            karyawan1.jumlahJamKerja = 10;
            karyawan2.nik = "35674323";
            karyawan2.nama = "Giorno Giovana";
            karyawan2.gajiBulanan = 8000000;
            karyawan3.nik = "68964435";
            karyawan3.nama = "Dio Brando";
            karyawan3.jumlahPenjualan = 300;
            karyawan3.komisi = 5000;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            listKaryawan.Add(karyawan1);
            listKaryawan.Add(karyawan2);
            listKaryawan.Add(karyawan3);
            int counter = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(counter + " NIK : " + karyawan.nik + ", Nama : " + karyawan.nama + ", Gaji : " + karyawan.gaji() + " \n ");
                counter++;
            }

            Console.ReadKey(); */
            
            List<Karyawan_Tetap> karyawantetap = new List<Karyawan_Tetap>();
            List<Karyawan_Harian> karyawanharian = new List<Karyawan_Harian>();
            List<Sales> sales = new List<Sales>();

            menu:
            Console.WriteLine("1. Input Data Karyawan");
            Console.WriteLine("2. Lihat Data Karyawan");
            Console.WriteLine("3. Hapus Data Karyawan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            Console.Write("Silahkan Pilih [1-4] : ");
            int pilihan;
            int pil;
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("\n1. Input Data Karyawan Tetap");
                Console.WriteLine("2. Input Data Karyawan Harian");
                Console.WriteLine("3. Input Data Sales");
                Console.WriteLine();
                Console.Write("Silahkan Pilih [1-3] : ");
                pil = int.Parse(Console.ReadLine());

                if (pil == 1)
                {
                    string nik, nama;
                    double gajibulanan;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Gaji Bulanan : ");
                    gajibulanan = int.Parse(Console.ReadLine());

                    karyawantetap.Add(new Karyawan_Tetap() { nik = nik, nama = nama, gajiBulanan = gajibulanan });
                }

                else if (pil == 2)
                {
                    string nik, nama;
                    double jam;
                    double upah;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Jam : ");
                    jam = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Jumlah Upah : ");
                    upah = int.Parse(Console.ReadLine());

                    karyawanharian.Add(new Karyawan_Harian() { nik = nik, nama = nama, jumlahJamKerja = jam, upahPerJam = upah });
                }

                else if (pil == 3)
                {
                    string nik, nama;
                    double jual;
                    double komisi;
                    Console.WriteLine("Masukan Nik : ");
                    nik = Console.ReadLine();
                    Console.WriteLine("Masukan Nama : ");
                    nama = Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Penjualan : ");
                    jual = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Komisi : ");
                    komisi = int.Parse(Console.ReadLine());

                    sales.Add(new Sales() { nik = nik, nama = nama, jumlahPenjualan = jual, komisi = komisi });
                }
                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            else if (pilihan == 2)
            {
                Console.WriteLine("Data Karyawan");
                Console.WriteLine();
                int no = 1;
                foreach (Karyawan karyawan in karyawantetap)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Karyawan Tetap",
                    no, karyawan.nik, karyawan.nama, karyawan.gaji());
                    no++;
                }

                foreach (Karyawan karyawan in karyawanharian)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Karyawan Harian",
                    no, karyawan.nik, karyawan.nama, karyawan.gaji());
                    no++;
                }

                foreach (Karyawan karyawan in sales)
                {
                    Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3}, Sales",
                    no, karyawan.nik, karyawan.nama, karyawan.gaji());
                    no++;
                }

                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Hapus Karyawan");
                Console.WriteLine();
                string hapus;
                Console.WriteLine("Masukan Nik yang ingin dihapus : ");
                hapus = Console.ReadLine();
                int i = 0;
                foreach (Karyawan karyawan in karyawantetap)
                {
                    if (hapus == karyawan.nik)
                    {
                        karyawantetap.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in karyawanharian)
                {
                    if (hapus == karyawan.nik)
                    {
                        karyawanharian.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                i = 0;
                foreach (Karyawan karyawan in sales)
                {
                    if (hapus == karyawan.nik)
                    {
                        sales.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                Console.WriteLine("Data Berhasil dihapus");
                Console.WriteLine("Tekan Enter Untuk Lanjut");
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            else
            {
                Console.WriteLine("Terima Kasih");
            }

            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
