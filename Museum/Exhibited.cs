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
    public partial class Exhibited : Form
    {
        public Exhibited()
        {
            InitializeComponent();
        }

        private void Exhibited_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Exhibited", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void خروج_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void درج_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into Art_object values(N'" + textBox1.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "')";
            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();
                c1.CommandText = "insert into Exhibition values(N'" + textBox2.Text + "',N'" + textBox10.Text + "',N'" + textBox11.Text + "')";
                c1.Connection = con1;
                try
                {
                    c1.ExecuteNonQuery();
                    c1.CommandText = "insert into Exhibited values(N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
                    c1.Connection = con1;
                    try
                    {
                        c1.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("داده وارد شده صحیح نمی باشد");
                    }

                }
                catch
                {
                    MessageBox.Show("داده وارد شده صحیح نمی باشد");
                }

            }
            catch
            {
                MessageBox.Show("داده وارد شده صحیح نمی باشد");
            }

            SqlDataAdapter da = new SqlDataAdapter("select * from Exhibited", con1);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from Exhibited", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void حذف_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "delete from Art_object where Id_No='" + textBox1.Text + "'";
            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();
                c1.CommandText = "delete from Exhibition where Aname='" + textBox2.Text + "'";
                try
                {
                    c1.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("داده وارد شده صحیح نمی باشد");
                }
            }
            catch
            {
                MessageBox.Show("داده وارد شده صحیح نمی باشد");
            }

            con1.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=DESKTOP-3TBI42A;database=Museum1;integrated security=true";
            con1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Exhibited where Id_No like '" + textBox7.Text + "%'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;



            con1.Close();
        }
    }
}
