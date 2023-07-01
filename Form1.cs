using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEGA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuenta=textBox1.Text;
            string password=textBox2.Text;

            if (cuenta == "burger" && password == "123")
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
