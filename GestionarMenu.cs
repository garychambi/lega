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
    public partial class GestionarMenu : Form
    {
        public GestionarMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionarMenu_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {

                SqlCommand cmd = new SqlCommand("insert into menu (costo,descripcion,nombre_prod,precio_ven,tipo,id_producto,cantidad) values ('" + textBox5.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox4.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id_producto,nombre_prod,descripcion,tipo,cantidad,costo,precio_ven from menu", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update menu set id_producto='" + textBox1.Text + "', nombre_prod='" + textBox2.Text + "',descripcion='" + textBox3.Text + "',tipo='" + comboBox1.Text + "',cantidad='" + textBox4.Text + "',costo='" + textBox5.Text + "',precio_ven='" + textBox6.Text + "' where id_producto='" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id_producto,nombre_prod,descripcion,tipo,cantidad,costo,precio_ven from menu", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                label9.Text = textBox1.Text;
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("delete from menu where id_producto='" + textBox1.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select id_producto,nombre_prod,descripcion,tipo,cantidad,costo,precio_ven from menu", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
