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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable.s = 1;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Art_object", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (variable.s.Equals(1))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Art_object where Id_No like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(2))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Artist where Aname like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(3))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Exhibition where Ename like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(4))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from collection where Cname like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(5))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Painting where Paint_type like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(6))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from StatueORScupture where Material like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(7))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Other where OType like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(8))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Permanent where Data_acquired like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (variable.s.Equals(9))
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Borrowed where Data_Borrowed like '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variable.s = 2;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Artist", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            variable.s = 3;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Exhibition", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            variable.s = 4;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from collection", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            variable.s = 5;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Painting", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            variable.s = 6;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from StatueORScupture", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            variable.s = 7;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Other", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            variable.s = 8;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Permanent", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            variable.s = 9;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Borrowed", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }
    }
}
