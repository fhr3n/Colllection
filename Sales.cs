using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Sales : Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double jumlahPenjualan { get; set; }
        public double komisi { get; set; }
        public override double gaji()
        {
            return (jumlahPenjualan * komisi);
        }
    }
}
