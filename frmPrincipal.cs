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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionarMenu gestionarMenu=new GestionarMenu();
            gestionarMenu.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            gestionarPedido gestionar=new gestionarPedido();
            gestionar.ShowDialog();
        }
    }
}
