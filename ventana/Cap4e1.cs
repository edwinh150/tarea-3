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
    public partial class Cap4e1 : Form
    {
        public Cap4e1()
        {
            InitializeComponent();
        }

        private void buttonM6_Click(object sender, EventArgs e)
        {
            int numero, y = 1;
            int[] res = new int[10];

            numero = Convert.ToInt32(textBoxNu.Text);

            for(int x=0; x<10; x++)
            {
                res[x] = numero * y;
                y++;
            }

                labelRes1.Text = Convert.ToString(res[0]);
                labelRes2.Text = Convert.ToString(res[1]);
                labelRes3.Text = Convert.ToString(res[2]);
                labelRes4.Text = Convert.ToString(res[3]);
                labelRes5.Text = Convert.ToString(res[4]);
                labelRes6.Text = Convert.ToString(res[5]);
                labelRes7.Text = Convert.ToString(res[6]);
                labelRes8.Text = Convert.ToString(res[7]);
                labelRes9.Text = Convert.ToString(res[8]);
                labelRes10.Text = Convert.ToString(res[9]);

        }
    }
}
