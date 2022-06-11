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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void ورود_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection("server=DESKTOP-3TBI42A;database=Museum1;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "select * from users where uid ='" + textBox1.Text + "' and uPass ='" + textBox2.Text + "' ";
            c1.Connection = con1;
            SqlDataReader dr = c1.ExecuteReader();
            object[] x = new object[3];
            if (dr.Read())
            {
                dr.GetValues(x);
                if (x[2].ToString().Equals("admin"))
                {
                    frmAdmin f1 = new frmAdmin();
                    f1.ShowDialog();
                }
                else
                {
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("کاربر شناسایی نشد");
            }
            con1.Close();
        }

        private void خروج_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
