using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_TrapesiumSiku
{
    class TrapesiumSiku
    {
        public double sisiA, sisiB, sisiC, sisiD, tinggi;

        public void construct(double sisiA, double sisiB, double sisiC, double sisiD, double tinggi)
        {
            this.sisiA = sisiA;
            this.sisiB = sisiB;
            this.sisiC = sisiC;
            this.sisiD = sisiD;
            this.tinggi = tinggi;
        }

        public double luas()
        {
            return this.sisiB + this.sisiD * this.tinggi / 2;
        }

        public double keliling()
        {
            return this.sisiA + this.sisiB + this.sisiC + this.sisiD;
        }
    }
}
