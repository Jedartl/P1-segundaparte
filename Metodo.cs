using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaParte.Algoritmo
{
    internal class metodo
    {
        // Método para calcular el valor de u utilizando los generadores congruenciales
        public int formulas(int a, int x, int c)
        {
            // Calcular el valor de xi utilizando el generador congruencial con el multiplicador (a) y la constante aditiva (c)
            int xi = (a * x - 1) % c;

            // Calcular el valor de y utilizando otro generador congruencial con el mismo valor de xi y diferentes valores para a y c
            int y = ((a + 1) * xi - 1) % (c + 1);

            // Calcular el valor de z utilizando otro generador congruencial con el mismo valor de xi y diferentes valores para a y c
            int z = ((a + 2) * xi - 1) % (c + 2);

            // Calcular el valor de u sumando los valores de xi, y, y z
            int u = xi + y + z;
            return u;
        }
    }
}

