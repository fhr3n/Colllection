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

            Console.ReadKey();

        }
    }
}
