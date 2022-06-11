using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;


namespace Museum
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }



        private void مجسمه_Click(object sender, EventArgs e)
        {
            statue1 f1 = new statue1();
            f1.ShowDialog();
        }

        private void اشیا_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=DESKTOP-3TBI42A;database=Museum1;integrated security=true");
            con1.Open();
            object1 f1 = new object1();
            f1.ShowDialog();
            con1.Close();
        }

        private void هنرمند_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=DESKTOP-3TBI42A;database=Museum1;integrated security=true");
            con1.Open();
            artist1 f1 = new artist1();
            f1.ShowDialog();
            con1.Close();
        }

        private void نمایشگاه_Click(object sender, EventArgs e)
        {
            exhibition1 f1 = new exhibition1();
            f1.ShowDialog();
        }

        private void مجموعه_Click(object sender, EventArgs e)
        {
            collection1 f1 = new collection1();
            f1.ShowDialog();
        }

        private void نقاشی_Click(object sender, EventArgs e)
        {
            painting1 f1 = new painting1();
            f1.ShowDialog();
        }

        private void سایر_Click(object sender, EventArgs e)
        {
            other1 f1 = new other1();
            f1.ShowDialog();
        }

        private void دایمی_Click(object sender, EventArgs e)
        {
            permanent1 f1 = new permanent1();
            f1.ShowDialog();
        }

        private void امانت_Click(object sender, EventArgs e)
        {
            borrowed1 f1 = new borrowed1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void توسط_Click(object sender, EventArgs e)
        {
            MadeBy f1 = new MadeBy();
            f1.ShowDialog();
        }

        private void نمایش_Click(object sender, EventArgs e)
        {
            Exhibited f1 = new Exhibited();
            f1.ShowDialog();
        }

        private void queries_Click(object sender, EventArgs e)
        {
            queries f1 = new queries();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Backup f1 = new Backup();
            f1.ShowDialog();
        }
    }
}
