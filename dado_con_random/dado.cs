using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dado_con_random
{
    class dado
    {
        public int jugar()
        {
            Random dado = new Random();
            int numero = dado.Next(1, 7);

            return (numero);
        }
    }
}
