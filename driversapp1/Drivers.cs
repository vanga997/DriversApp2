using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driversapp1
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDBDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.driversDBDataSet.Driver);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Licenses f = new Licenses();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization t = new Authorization();
            t.Show();
        }
    }
}
