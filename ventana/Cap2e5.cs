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
    public partial class Cap2e5 : Form
    {
        public Cap2e5()
        {
            InitializeComponent();
        }

        private void buttonMDE_Click(object sender, EventArgs e)
        {
            double cifra = Convert.ToDouble(textBoxNDE.Text);
            double dolares;
            double euro;

            if(radioButtonD.Checked)
            {
                dolares = cifra * 1.13;
                textBoxRDE.Text = Convert.ToString(dolares + " Euros");
            }

            if(radioButtonE.Checked)
            {
                euro = cifra * 0.88;
                textBoxRDE.Text = Convert.ToString(euro + " Dolares");
            }
        }
    }
}
