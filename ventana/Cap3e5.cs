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
    public partial class Cap3e5 : Form
    {
        public Cap3e5()
        {
            InitializeComponent();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            double n, l, res;
            n = Convert.ToDouble(textBoxNP.Text);
            l = Convert.ToDouble(textBoxLP.Text);

            res = n * l;

            textBoxR.Text = Convert.ToString(res);
        }

        private void buttonMA_Click(object sender, EventArgs e)
        {
            double n2, l2, res2;
            n2 = Convert.ToDouble(textBoxPA.Text);
            l2 = Convert.ToDouble(textBoxLA.Text);

            res2 = (n2 * l2) / 2;

            textBoxR2.Text = Convert.ToString(res2);
        }
    }
}
