using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class Kwadrat : ICloneable
    {
        private int x, y, rozmiar;
        private Brush kolor;

        public Kwadrat()
        {x = y = 0; rozmiar = 19; kolor = Brushes.White; }

        public Kwadrat(int x, int y)
        { this.x = x; this.y = y; rozmiar = 19; kolor = Brushes.White; }

        public void RysujWRuchu(PaintEventArgs e)
        { Spadanie(); e.Graphics.FillRectangle(kolor, x, y, rozmiar, rozmiar); }

        public void Rysuj(PaintEventArgs e)
        { e.Graphics.FillRectangle(kolor, x, y, rozmiar, rozmiar); }

        private void Spadanie()
        { if(Kontroluj.czyWDol) y += Kontroluj.przesuniecie; }

        public int ZwracajX() => x;
        public int ZwracajY() => y;

        public object Clone()
        { return MemberwiseClone(); }
    }
}
