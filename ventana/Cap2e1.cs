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
    public partial class Cap2e1 : Form
    {
        public Cap2e1()
        {
            InitializeComponent();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            double n,l,r;
            n = Convert.ToDouble(textBoxN.Text);
            l = Convert.ToDouble(textBoxL.Text);

            r = n * l;

            textBoxR.Text = Convert.ToString(r);

        }

        private void textBoxL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
