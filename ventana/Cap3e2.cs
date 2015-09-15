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
    public partial class Cap3e2 : Form
    {
        public Cap3e2()
        {
            InitializeComponent();
        }

        private void tabPagec_Click(object sender, EventArgs e)
        {

        }

        private void buttonM3_Click(object sender, EventArgs e)
        {

        }

        private void buttonM5_Click(object sender, EventArgs e)
        {
            double grados3, r3;

            grados3 = Convert.ToDouble(textBoxG3.Text);

            r3 = grados3 * 1.8 + 32;

            textBoxR5.Text = Convert.ToString(r3);
        }

        private void buttonM4_Click(object sender, EventArgs e)
        {
            double fahre, r4;

            fahre = Convert.ToDouble(textBoxG3.Text);

            r4 = (fahre - 32) * 5 / 9 ;

            textBoxR4.Text = Convert.ToString(r4);
        }
    }
}
