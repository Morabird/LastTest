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
    public partial class DirectorMain : Form
    {
        public DirectorMain()
        {
            InitializeComponent();
        }

        private void DirectorMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "facturaDataSet._Счёт_фактура". При необходимости она может быть перемещена или удалена.
            this.счёт_фактураTableAdapter.Fill(this.facturaDataSet._Счёт_фактура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nakladnayaDataSet.Накладнаая". При необходимости она может быть перемещена или удалена.
            this.накладнааяTableAdapter.Fill(this.nakladnayaDataSet.Накладнаая);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actRabotDataSet.Акт_выполнения_работ". При необходимости она может быть перемещена или удалена.
            this.акт_выполнения_работTableAdapter.Fill(this.actRabotDataSet.Акт_выполнения_работ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yurLicaDataSet.Юр_лица". При необходимости она может быть перемещена или удалена.
            this.юр_лицаTableAdapter.Fill(this.yurLicaDataSet.Юр_лица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.zakazDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fizLicaDataSet.Физ_лица". При необходимости она может быть перемещена или удалена.

            textBox1.Text = "Поиск..";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                        if (dataGridView3.Rows[i].Cells[j].Value != null)
                            if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView3.Rows[i].Selected = true;
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

                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    dataGridView4.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView4.ColumnCount; j++)
                        if (dataGridView4.Rows[i].Cells[j].Value != null)
                            if (dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView4.Rows[i].Selected = true;
                                break;
                            }
                }

                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    dataGridView5.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView5.ColumnCount; j++)
                        if (dataGridView5.Rows[i].Cells[j].Value != null)
                            if (dataGridView5.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView5.Rows[i].Selected = true;
                                break;
                            }
                }

                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    dataGridView6.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView6.ColumnCount; j++)
                        if (dataGridView6.Rows[i].Cells[j].Value != null)
                            if (dataGridView6.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView6.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Поиск..")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поиск..";
            }
        }
    }
}

