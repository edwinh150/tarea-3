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
    public partial class Cap4e5 : Form
    {
        public Cap4e5()
        {
            InitializeComponent();
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            int promedio;
            int mayor = 0;
            int menor = 0;

            int numero1 = Convert.ToInt32(textBoxN1.Text);
            int numero2 = Convert.ToInt32(textBoxN2.Text);
            int numero3 = Convert.ToInt32(textBoxN3.Text);
            int numero4 = Convert.ToInt32(textBoxN4.Text);
            int numero5 = Convert.ToInt32(textBoxN5.Text);

            promedio = (numero1 + numero2 + numero3 + numero4 + numero5) / 5;

            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4 && numero1 > numero5)
            {
                mayor = numero1;
            }

            if (numero1 < numero2 && numero1 < numero3 && numero1 < numero4 && numero1 < numero5)
            {
                menor = numero1;
            }

            if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4 && numero2 > numero5)
            {
                mayor = numero2;
            }

            if (numero2 < numero1 && numero2 < numero3 && numero2 < numero4 && numero2 < numero5)
            {
                menor = numero2;

            }

            if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4 && numero3 > numero5)
            {
                mayor = numero3;
            }

            if (numero3 < numero1 && numero3 < numero2 && numero3 < numero4 && numero3 < numero5)
            {
                menor = numero3;
            }

            if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3 && numero4 > numero5)
            {
                mayor = numero4;
            }

            if (numero4 < numero1 && numero4 < numero2 && numero4 < numero3 && numero4 < numero5)
            {
                menor = numero4;
            }

            if (numero5 > numero1 && numero5 > numero2 && numero5 > numero3 && numero5 > numero4)
            {
                mayor = numero5;
            }

            if (numero5 < numero1 && numero5 < numero2 && numero5 < numero3 && numero5 < numero4)
            {
                menor = numero5;
            }

            labelMayor.Text = Convert.ToString(mayor);
            labelMenor.Text = Convert.ToString(menor);
            labelProm.Text = Convert.ToString(promedio);
        }
    }
}
