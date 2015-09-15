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
    public partial class Cap3e3 : Form
    {
        public Cap3e3()
        {
            InitializeComponent();
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            double resultado = 0,imp1,imp2;
            double producto = Convert.ToDouble(textBoxPro.Text);

            if(radioButtonM.Checked)
            {
                imp1 = producto * 0;
                resultado = producto + imp1;
            }

            if(radioButtonO.Checked)
            {
                imp2 = producto * 0.18;
                resultado = producto + imp2;
            }

            textBoxRPro.Text = Convert.ToString(resultado);
        }
    }
}
