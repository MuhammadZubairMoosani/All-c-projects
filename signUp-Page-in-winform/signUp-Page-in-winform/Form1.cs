using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp_Page_in_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string userName = "zubair";
            string userPass = "123";
            if (userName == UnameTB.Text.ToLower() && userPass == UPassTB.Text)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password");
                UnameTB.Text = "";
                UPassTB.Text = "";
                this.ActiveControl = UnameTB;
            }
        }
    }
}
