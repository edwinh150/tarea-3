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
    public partial class Cap2e4 : Form
    {
        public Cap2e4()
        {
            InitializeComponent();
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            double grados2, r2;

            grados2 = Convert.ToDouble(textBoxG2.Text);

            r2 = grados2 * 1.8 + 32;

            textBoxR3.Text = Convert.ToString(r2);

        }
    }
}
