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
    public partial class Cap5e2 : Form
    {
        public Cap5e2()
        {
            InitializeComponent();
        }

        private void Cap5e2_Load(object sender, EventArgs e)
        {

        }

        private void GradoFareh()
        {
            double grados, r;

            grados = Convert.ToDouble(textBoxG5.Text);

            r = grados * 1.8 + 32;

            textBoxRG2.Text = Convert.ToString(r);
        }

        private void buttonMG2_Click(object sender, EventArgs e)
        {
            GradoFareh();
        }
    }
}
