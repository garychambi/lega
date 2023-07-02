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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select id_producto,nombre_prod,descripcion,tipo,cantidad,costo,precio_ven from menu", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            dataGridView2.Columns.Add("", "id_producto");
            dataGridView2.Columns.Add("", "nombre");
            dataGridView2.Columns.Add("", "descripcion");
            dataGridView2.Columns.Add("", "tipo");
            dataGridView2.Columns.Add("", "cantidad");
            dataGridView2.Columns.Add("", "costo");
            dataGridView2.Columns.Add("", "precio");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                label3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                label4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                label5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                label6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                label7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                /*dataGridView2.CurrentRow.Cells[0].Value = label1.Text;
                dataGridView2.CurrentRow.Cells[1].Value = label2.Text;
                dataGridView2.CurrentRow.Cells[2].Value = label3.Text;
                dataGridView2.CurrentRow.Cells[3].Value = label4.Text;
                dataGridView2.CurrentRow.Cells[4].Value = label5.Text;
                dataGridView2.CurrentRow.Cells[5].Value = label6.Text;
                dataGridView2.CurrentRow.Cells[6].Value = label7.Text;*/          
                
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.Rows.Count==1)
            {
                
                if (label1.Text!="vacio")
                {
                    dataGridView2.Rows.Add(label1.Text, label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
                    //label8.Text= dataGridView2.Rows[0].Cells[0].Value.ToString();
                }                
            }
            else
            {

                int cont = 0;
                for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                {
                    
                    
                    string valor = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    //label8.Text = valor;
                    if (valor != label1.Text && cont<1)
                    {
                        dataGridView2.Rows.Add(label1.Text, label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
                        cont++;
                        label8.Text = Convert.ToString(cont);
                    }
                       

                }
            }
                
        }
    }
}
