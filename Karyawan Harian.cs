using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Karyawan_Harian : Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double upahPerJam { get; set; }
        public double jumlahJamKerja { get; set; }
        public override double gaji()
        {
            return upahPerJam * jumlahJamKerja;
        }
    }
}
