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

namespace driversapp1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public int I;
        private int count = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\79686\source\repos\driversapp1\driversapp1\DriversDB.mdf; Integrated Security = True");
            I = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Authorization] WHERE Login ='" + textBoxLogin.Text + "' AND Password ='" + textBoxPassword.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            if (I == 0)
            {
                MessageBox.Show("ошибка");
                if (count++ == 5)
                {
                    MessageBox.Show("достигнуто максимальное кол-во попыток. в доступе отказано.");
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Drivers f = new Drivers();
                f.Show();
            }
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


