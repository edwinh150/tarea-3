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
    public partial class Cap5e1 : Form
    {
        public Cap5e1()
        {
            InitializeComponent();
        }

        private void Radianes()
        {
            double grados, re;
            const double PI = 3.1416;

            grados = Convert.ToDouble(textBoxG4.Text);

            re = grados * (180 / PI);

            textBoxRG.Text = Convert.ToString(re);
        }

        private void buttonMG_Click(object sender, EventArgs e)
        {
            Radianes();
        }
    }
}
