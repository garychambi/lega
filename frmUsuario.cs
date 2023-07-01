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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select cuenta,password,nombre_com,ci,fecha_nac,rol,salario from usuario", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
                label1.Text = dateTimePicker1.Value.ToShortDateString();

                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                
                SqlCommand cmd = new SqlCommand("insert into usuario(ci,cuenta,fecha_nac,nombre_com,password,rol,salario,id_usuario) values ('"+textBox4.Text+"','"+ textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text+"','" + textBox6.Text+"','"+textBox4.Text+"')",cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select cuenta,password,nombre_com,ci,fecha_nac,rol,salario from usuario", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update usuario set ci='" + textBox4.Text + "', cuenta='" + textBox1.Text + "',fecha_nac='" + dateTimePicker1.Value.ToShortDateString() + "',nombre_com='" + textBox3.Text + "',password='" + textBox2.Text + "',rol='" + textBox5.Text + "',salario='" + textBox6.Text + "',id_usuario='" + textBox4.Text + "' where id_usuario='"+label1.Text+"'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select cuenta,password,nombre_com,ci,fecha_nac,rol,salario from usuario", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView2.DataSource = dt;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                label1.Text = textBox4.Text;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-5NR4173;Initial Catalog=lega;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("delete from usuario where id_usuario='" + textBox4.Text+"'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select cuenta,password,nombre_com,ci,fecha_nac,rol,salario from usuario", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);

                dataGridView2.DataSource = dt;

            }
        }
    }
}
