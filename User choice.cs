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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Менеджер" && textBox1.Text == "1q2w3e")
            {
                Main f = new Main();
                f.Show();
                Hide();
            }

            //else if (comboBox1.Text == "Директор" && textBox1.Text == "4r5t6y")
            //{
                DirectorMain f = new DirectorMain();
                f.Show();
                Hide();
            //}

            //else MessageBox.Show("Неверный пароль");


        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            entrance.Visible = true;
            entrance.Enabled = true;
        }
    }
}


