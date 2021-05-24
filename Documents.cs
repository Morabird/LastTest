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
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "facturaDataSet._Счёт_фактура". При необходимости она может быть перемещена или удалена.
            this.счёт_фактураTableAdapter.Fill(this.facturaDataSet._Счёт_фактура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nakladnayaDataSet.Накладнаая". При необходимости она может быть перемещена или удалена.
            this.накладнааяTableAdapter.Fill(this.nakladnayaDataSet.Накладнаая);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actRabotDataSet.Акт_выполнения_работ". При необходимости она может быть перемещена или удалена.
            this.акт_выполнения_работTableAdapter.Fill(this.actRabotDataSet.Акт_выполнения_работ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            Hide();
        }
    }
}
