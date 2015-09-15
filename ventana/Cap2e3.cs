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
    public partial class Cap2e3 : Form
    {
        public Cap2e3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonM2_Click(object sender, EventArgs e)
        {
            double grados,r;
            const double PI = 3.1416;
            
            grados= Convert.ToDouble(textBoxG.Text);

            r = grados * (180 / PI);

            textBoxR2.Text = Convert.ToString(r);
        }

        private void textBoxR2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelR_Click(object sender, EventArgs e)
        {

        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
