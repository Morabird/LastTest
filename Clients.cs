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

namespace Laundry_Dry_Cleaning
{

    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yurLicaDataSet.Юр_лица". При необходимости она может быть перемещена или удалена.
            this.юр_лицаTableAdapter.Fill(this.yurLicaDataSet.Юр_лица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yurLicaDataSet.Юр_лица". При необходимости она может быть перемещена или удалена.
            this.юр_лицаTableAdapter.Fill(this.yurLicaDataSet.Юр_лица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fizLicaDataSet.Физ_лица". При необходимости она может быть перемещена или удалена.
            
            textBox1.Text = "Поиск..";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add f = new Add();
            f.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdClients f = new UpdClients();
            f.Update();
            f.Show();
            Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Поиск..")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Поиск..";
            }
        }
    }
}
