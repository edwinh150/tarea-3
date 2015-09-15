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
    public partial class Cap4e2 : Form
    {
        public Cap4e2()
        {
            InitializeComponent();
        }

        private void buttonMEl_Click(object sender, EventArgs e)
        {
            double numero, resE, expo;

            numero = Convert.ToDouble(textBoxNu1.Text);
            expo = Convert.ToDouble(textBoxEl.Text);

            resE = Math.Pow(numero, expo);

            textBoxREl.Text = Convert.ToString(resE);
        }
    }
}
