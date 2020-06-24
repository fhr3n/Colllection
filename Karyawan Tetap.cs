using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Karyawan_Tetap : Karyawan
    {
        public override string nik { get; set; }
        public override string nama { get; set; }
        public double gajiBulanan { get; set; }
        public override double gaji()
        {
            return this.gajiBulanan;
        }
    }
}
