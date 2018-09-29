using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Forma : Form
    {
        List<Kwadrat> kwadrat = new List<Kwadrat>()
        { new Kwadrat(0, 0), new Kwadrat(0, 20), new Kwadrat(0, 40), new Kwadrat(20, 40)};

        List<Kwadrat> bloki = new List<Kwadrat>();

        public Forma()
        {
            InitializeComponent();
        }

        private void Forma_Paint(object sender, PaintEventArgs e)
        {
            Kontroluj.WarunekSpadniecia(kwadrat);

            foreach (Kwadrat item in kwadrat)
                item.Rysuj(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
