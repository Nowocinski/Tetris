using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    static class Kontroluj
    {
        /* !!! */
        public static bool CzyWDol;

        public static bool WarunekSpadniecia(List<Kwadrat> k)
        {
            /* Dziwnie wygląda to 420 :/// */
            foreach (Kwadrat item in k)
                if (item.ZwracajY() > 420)
                    return CzyWDol = false;

            /* Kolejny warunek: Czy pod spodem jest obiekt z listy blok */
            /* Jeśli tak: dodaj obiekty z listy kwadrat do listy blok */
            /* i utwórz nową liste kwadrat */

            return CzyWDol = true;
        }

        //public static void Sterowanie()

        //public static void SprawdzCzyUsunąćPoziom()
    }
}
