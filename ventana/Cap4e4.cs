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
    public partial class Cap4e4 : Form
    {
        public Cap4e4()
        {
            InitializeComponent();
        }

        private void buttonMPri_Click(object sender, EventArgs e)
        {
            int cont1 = 1;
            int cont2 = 0;

            for(int x = 3; x < 1000; x++)
            {
                for(int y = 2; y < x; y++)
                {
                    if(x % y == 0)
                    {
                        cont2++;
                    }

                    if(cont2 == 0)
                    {
                        richTextBoxPri.Text += Convert.ToString(x) + "\n";
                        cont1++;
                    }
                    cont2 = 0;
                }
            }
        }
    }
}
