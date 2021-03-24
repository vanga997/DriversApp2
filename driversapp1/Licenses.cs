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
    public partial class Licenses : Form
    {
        public Licenses()
        {
            InitializeComponent();
        }

        private void driversLicenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversLicenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDBDataSet);

        }

        private void Licenses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDBDataSet.DriversLicense". При необходимости она может быть перемещена или удалена.
            this.driversLicenseTableAdapter.Fill(this.driversDBDataSet.DriversLicense);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Drivers d = new Drivers();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization t = new Authorization();
            t.Show();
        }
    }
}
