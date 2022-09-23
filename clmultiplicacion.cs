using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacion
{
    internal class Clmultiplicacion
    {
        private int n1;
        private int n2;

        public Clmultiplicacion(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int multiplicar()
        {
            return n1 * n2;
        }
    }
}
