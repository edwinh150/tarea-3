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
    public partial class Cap3e4 : Form
    {
        public Cap3e4()
        {
            InitializeComponent();
        }

        private void buttonM6_Click(object sender, EventArgs e)
        {
            int numero;

            numero = Convert.ToInt32(textBoxNS.Text);

            if (numero == 1)
            {
                labelR1.Text = "Domingo";
            }
            if (numero == 2)
            {
                labelR1.Text = "Lunes";
            }
            if (numero == 3)
            {
                labelR1.Text = "Martes";
            }
            if (numero == 4)
            {
                labelR1.Text = "Miercoles";
            }
            if (numero == 5)
            {
                labelR1.Text = "Jueves";
            }
            if (numero == 6)
            {
                labelR1.Text = "Viernes";
            }
            if (numero == 7)
            {
                labelR1.Text = "Sabado";
            }

        }
    }
}
