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
    public partial class Cap5e4 : Form
    {
        public Cap5e4()
        {
            InitializeComponent();
        }

        private void Factorial()
        {
            int numero, resultado = 1;

            numero = Convert.ToInt32(textBoxF.Text);

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            textBoxRF.Text = Convert.ToString(resultado);
        }

        private void buttonMF_Click(object sender, EventArgs e)
        {
            Factorial();
        }
    }
}
