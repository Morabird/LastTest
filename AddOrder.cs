using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Dry_Cleaning
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order f = new Order();
            f.Show();
            Hide();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uslugaDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.uslugaDataSet.Услуга);

        }
    }
}
