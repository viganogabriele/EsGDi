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

            Brush b = Brushes.Black;
            decimal x;
            decimal y;
            for (int i = 0; i < 5; i++)
            {
                for (float j = 0; j < Math.PI*2; j = j+ (float)0.1)
                {
                    x = Convert.ToDecimal(j * 100 + i*626);
                    y = Convert.ToDecimal(Math.Sin(j) * 100 + 500);
                    e.Graphics.FillEllipse(b, new Rectangle((int)x, (int)y, 2, 2));
                }

            }
        }
    }
}
