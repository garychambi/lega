using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEGA
{
    public partial class gestionarPedido : Form
    {
        public gestionarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.ShowDialog();
        }

        private void gestionarPedido_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from pedido", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;



            }
        }
    }
}
