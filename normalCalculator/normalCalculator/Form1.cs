using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace normalCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            plus.Text = Convert.ToString(value1 + value2);
            multiply.Text = Convert.ToString(value1 * value2);
            minus.Text = Convert.ToString(value1 - value2);
            divid.Text = Convert.ToString(value1 / value2);

        }
    }
}
