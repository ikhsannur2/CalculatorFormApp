using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHitung_click(object sender, EventArgs e)
        {
            var a = float.Parse(txtNilaiA.Text);
            var b = float.Parse(txtNilaiB.Text);

            double hasil;

            switch (Operasi.SelectedIndex)
            {
                case 0:
                    hasil = a - b;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = a + b;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = a / b;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = a * b;
                    txtHasil.Text = Convert.ToString(hasil);
                    break;

            }
        }
    }
}
