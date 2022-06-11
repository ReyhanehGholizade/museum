using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Museum
{
    public partial class artist1 : Form
    {
        public artist1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void artist1_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Artist", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void درج_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into Artist values(N'" + textBox1.Text + "',N'" + textBox2.Text + "', N'" + textBox3.Text + "' ,N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "',N'" + textBox8.Text + "')";
            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("داده وارد شده صحیح نمی باشد");
            }

            SqlDataAdapter da = new SqlDataAdapter("select * from Artist", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void نمایش_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Artist", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void حذف_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "delete from Artist where Aname='" + textBox1.Text + "'";
            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("داده وارد شده صحیح نمی باشد");
            }

            con1.Close();
        }

        private void ویرایش_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "update Artist set Date_Born = N'" + textBox2.Text + "', Date_Died = N'" + textBox3.Text + "', Country_of_Origin = N'" + textBox4.Text + "',Epoch = N'" + textBox5.Text + "',Artist_Description = N'" + textBox6.Text + "',MainStyle = N'" + textBox8.Text + "' where Aname= '" + textBox1.Text + "'";
            c1.Connection = con1;

            try
            {
                c1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("داده وارد شده صحیح نمی باشد");
            }

            con1.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void خروج_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Artist where Aname ='" + textBox1.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Artist where Aname like '" + textBox7.Text + "%'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }
    }
}
