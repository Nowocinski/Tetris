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
        public static int przesuniecie = 20;
        public static bool czyWDol, czyWLewo, czyWPrawo;

        public static bool WarunekSpadniecia(List<Kwadrat> kwadrat, List<Kwadrat> bloki, int w)
        {
            foreach (Kwadrat k in kwadrat)
            {
                if (k.ZwracajY() > w - 39)
                    return czyWDol = false;

                foreach (Kwadrat b in bloki)
                    if (k.ZwracajX() == b.ZwracajX() && k.ZwracajY() + przesuniecie == b.ZwracajY())
                        return czyWDol = false;
            }

            return czyWDol = true;
        }

        //public static void Sterowanie()

        //public static void SprawdzCzyUsunąćPoziom()
    }
}
