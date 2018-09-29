using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class Kwadrat
    {
        private int x, y, rozmiar, przesuniecie;
        private Brush kolor;

        public Kwadrat()
        {x = y = 0; rozmiar = 19; kolor = Brushes.White; przesuniecie = 20; }

        public Kwadrat(int x, int y)
        { this.x = x; this.y = y; rozmiar = 19; kolor = Brushes.White; przesuniecie = 20; }

        public void Rysuj(PaintEventArgs e)
        { Spadanie(); e.Graphics.FillRectangle(kolor, x, y, rozmiar, rozmiar); }

        private void Spadanie()
        { if(Kontroluj.CzyWDol) y += przesuniecie; }

        public int ZwracajX() => x;
        public int ZwracajY() => y;
    }
}
