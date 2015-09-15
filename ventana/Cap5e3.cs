using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana
{
    public partial class Cap5e3 : Form
    {
        public Cap5e3()
        {
            InitializeComponent();
        }

        private void Poligono()
        {
            double n, d, re2;
            n = Convert.ToDouble(textBoxN2.Text);
            d = Convert.ToDouble(textBoxD2.Text);

            re2 = n * d;

            textBoxR2.Text = Convert.ToString(re2);
        }

        private void buttonMP_Click(object sender, EventArgs e)
        {
            Poligono();
        }
    }
}
