using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsGDi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
                // Crea un oggetto Brush di colore nero
                Brush b = Brushes.Black;

                // Riempie il punto alle coordinate (20, 10) con un raggio di 5 pixel
                e.Graphics.FillEllipse(b, new Rectangle(int.Parse(Math.Cos(3,14 /2)), int.Parse(Math.Sin(3,14 / 2), 5, 5)));
        }

        /*
                // Crea un oggetto Pen di colore nero
                Pen p = new Pen(Color.Black);

                // Disegna un punto alle coordinate (20, 10)
                e.Graphics.DrawEllipse(p, new Rectangle(20, 10, 1, 1));
        */
    }
}
