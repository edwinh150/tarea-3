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
    public partial class Cap3e1 : Form
    {
        public Cap3e1()
        {
            InitializeComponent();
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            int numero;

            numero = Convert.ToInt32(textBoxPI.Text);

            if(numero % 2 == 0)
            {
                labelRes.Text = "Es par";
            }else
            {
                labelRes.Text = "Es impar";
            }
        }
    }
}
