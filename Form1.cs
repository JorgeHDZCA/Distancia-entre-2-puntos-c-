using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distancia_entre_2_puntos_c_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = 0;
            d = Math.Sqrt(Math.Pow(double.Parse(X1.Text) - double.Parse(X2.Text), 2) + Math.Pow(double.Parse(Y1.Text) - double.Parse(Y2.Text), 2));
            Dis.Text = d.ToString();
        }
    }
}
