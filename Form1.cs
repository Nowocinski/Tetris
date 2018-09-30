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
        List<Kwadrat> kwadrat = new List<Kwadrat>();
        List<Kwadrat> bloki = new List<Kwadrat>();

        public Forma()
        {
            InitializeComponent();
        }

        private void Forma_Paint(object sender, PaintEventArgs e)
        {
            if(!kwadrat.Any())
            {
                kwadrat.Add(new Kwadrat(0, 0));
                kwadrat.Add(new Kwadrat(0, 20));
                kwadrat.Add(new Kwadrat(0, 40));
                kwadrat.Add(new Kwadrat(20, 40));
            }

            Kontroluj.WarunekSpadniecia(kwadrat, bloki, ClientSize.Height);

            foreach (Kwadrat item in kwadrat)
                item.RysujWRuchu(e);

            if (!Kontroluj.czyWDol)
            {
                foreach (Kwadrat item in kwadrat)
                    bloki.Add((Kwadrat)item.Clone());
                kwadrat.Clear();
            }

            foreach (Kwadrat item in bloki)
                item.Rysuj(e);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Forma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { }
            if (e.KeyCode == Keys.Right) { }
            if (e.KeyCode == Keys.Up) { }
            if (e.KeyCode == Keys.Down) { }
        }
    }
}
